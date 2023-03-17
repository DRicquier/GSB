using lesClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lesClasses;

namespace GSB
{
    public partial class FrmModifierPraticien : FrmBase
    {
        public FrmModifierPraticien()
        {
            InitializeComponent();
        }

        private void FrmModifPraticien_Load(object sender, EventArgs e)
        {
            // On réinitialise les données
            lesPraticiens.Items.Clear();
            nomChamp.Text = "";
            prenomChamp.Text = "";
            rueChamp.Text = "";
            villeChamp.Text = "";
            telChamp.Text = "";
            mailChamp.Text = "";
            lesTypes.Items.Clear();
            lesSpecialités.Items.Clear();

            // Auto completion des villes
            AutoCompleteStringCollection villeAutoComplete = new AutoCompleteStringCollection();
            villeAutoComplete.AddRange(Globale.mesVilles.Select(ville => ville.Nom).ToArray());
            villeChamp.AutoCompleteCustomSource = villeAutoComplete;
            villeChamp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            villeChamp.AutoCompleteSource = AutoCompleteSource.CustomSource;
            villeChamp.Visible = true;

            // On ajoute les données à partir de la classe Globale
            Globale.mesPraticiens.ForEach(praticien => lesPraticiens.Items.Add(praticien));
            Globale.lesTypes.ForEach(praticien => lesTypes.Items.Add(praticien));
            Globale.lesSpecialites.ForEach(specialite => lesSpecialités.Items.Add(specialite));

            // todo Griser la text box du nom pour ne pas pouvoir modifier le nom d'un praticien
        }

        private void lesPraticiens_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mesure de sécurité
            if (lesPraticiens.SelectedItem == null)
            {
                return;
            }

            Praticien praticien = (Praticien)lesPraticiens.SelectedItem;

            nomChamp.Text = praticien.Nom;
            prenomChamp.Text = praticien.Prenom;
            rueChamp.Text = praticien.Rue;
            villeChamp.Text = praticien.Ville;
            telChamp.Text = praticien.Telephone;
            mailChamp.Text = praticien.Email;
            lesTypes.SelectedItem = praticien.Type;
            lesSpecialités.SelectedItem = praticien.Specialite;
        }

        private void btnModifer_Click(object sender, EventArgs e)
        {
            // Si l'utilisateur n'a pas sélectionné de praticien
            if (lesPraticiens.SelectedItem == null)
            {
                MessageBox.Show(this, "Vous devez sélectionner un praticien !");
                return;
            }

            Praticien praticien = (Praticien)lesPraticiens.SelectedItem;
            int idPraticien = praticien.Id;
            string nom = nomChamp.Text;
            string prenom = prenomChamp.Text;
            string rue = rueChamp.Text;

            // Il faut vérifier que la ville existe
            string villeName = villeChamp.Text;
            if (!Globale.mesVilles.Exists(x => x.Nom.Equals(villeName)))
            {
                MessageBox.Show(this, "La ville entrée n'existe pas !");
                return;
            }
            Ville ville = Globale.mesVilles.Find(x => x.Nom.Equals(villeName));

            string telephone = telChamp.Text;
            string email = mailChamp.Text;

            TypePraticien typePraticien = (TypePraticien)lesTypes.SelectedItem;
            Specialite specialite = (Specialite)lesSpecialités.SelectedItem;

            bool success = Passerelle.modifierPraticien(idPraticien, nom, prenom, rue, ville.Code, ville.Nom, telephone, email, typePraticien.Id, specialite.Id,
                out string message);

            // L'opération a échoué
            if (!success)
            {
                // temporaire pour le debug
                Console.WriteLine(message);

                MessageBox.Show(this, message);
                return;
            }

            // On modifie le praticien du cache
            // Ici on peut directement modifier l'objet Praticien car
            // ce dernier est chargé à partir de la collection dans Globale.
            // Autre solution: Charger le praticien à partir de la base de données
            // Envisageable si une procédure ou un trigger modifient 
            // les données modifiées.

            // On ne modifie pas le nom car il n'est pas sensé être modifiable par l'utilisateur
            // Si par la suite on autorise l'utilisateur à modifier le nom
            // alors décommenter cette ligne.

            // praticien.Nom = nom;

            praticien.Prenom = prenom;
            praticien.Rue = rue;
            praticien.Ville = ville.Nom;
            praticien.Telephone = telephone;
            praticien.Email = email;
            praticien.Type = typePraticien;
            praticien.Specialite = specialite;


            // On recharge les données
            FrmModifPraticien_Load(sender, e);

            MessageBox.Show("Praticien modifié !");
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            // Si l'utilisateur n'a pas sélectionné de praticien
            if (lesPraticiens.SelectedItem == null)
            {
                MessageBox.Show(this, "Vous devez sélectionner un praticien !");
                return;
            }

            Praticien praticien = (Praticien)lesPraticiens.SelectedItem;

            bool success = Passerelle.supprimerPraticien(praticien.Id, out string message);

            // L'opération a échoué
            if (!success)
            {
                // temporaire pour le debug
                Console.WriteLine(message);

                MessageBox.Show(this, message);
                return;
            }

            // On supprime le praticien du cache
            // Autre solution: recharger les données à partir de la base de données
            Globale.mesPraticiens.RemoveAll(x => x.Id.Equals(praticien.Id));

            // On recharge les données
            FrmModifPraticien_Load(sender, e);

            MessageBox.Show("Praticien supprimé !");
        }
    }
}
