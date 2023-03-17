using System;
using System.Linq;
using System.Windows.Forms;
using lesClasses;

namespace GSB {
    public partial class FrmAjouterPraticien : FrmBase {
        public FrmAjouterPraticien() {
            InitializeComponent();
        }

        private void FrmAjoutPraticien_Load(object sender, EventArgs e) {
            // On réinitialise les données
            nomChamp.Text = "";
            prenomChamp.Text = "";
            rueChamp.Text = "";
            villeChamp.Text = "";
            telChamp.Text = "";
            mailChamp.Text = "";
            lesTypesBox.Items.Clear();
            lesSpecialitesBox.Items.Clear();

            // Auto completion pour les villes
            AutoCompleteStringCollection villeAutoComplete = new AutoCompleteStringCollection();
            villeAutoComplete.AddRange(Globale.mesVilles.Select(ville => ville.Nom).ToArray());
            villeChamp.AutoCompleteCustomSource = villeAutoComplete;
            villeChamp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            villeChamp.AutoCompleteSource = AutoCompleteSource.CustomSource;
            villeChamp.Visible = true;

            // On ajoute les données à partir de la classe Globale
            Globale.lesTypes.ForEach(praticien => lesTypesBox.Items.Add(praticien));
            Globale.lesSpecialites.ForEach(specialite => lesSpecialitesBox.Items.Add(specialite));
        }

        private void btnAjouter_Click(object sender, EventArgs e) {
            // On contrôle la sélection
            
            if (!Globale.mesVilles.Any(x => x.Nom.Equals(villeChamp.Text, StringComparison.InvariantCultureIgnoreCase))) {
                MessageBox.Show(this, "Cette ville n'est pas valide !");
                return;
            }

            // L'utilisateur n'a pas sélectionné de type praticien
            if (lesTypesBox.SelectedItem == null) {
                MessageBox.Show(this, "Vous devez sélectionner un type de praticien !");
                return;
            }

            // L'utilisateur n'a pas sélectionén de spécialité
            if (lesSpecialitesBox.SelectedItem == null) {
                MessageBox.Show(this, "Vous devez sélectionner une spécialité !");
                return;
            }

            string nom = nomChamp.Text;
            string prenom = prenomChamp.Text;
            string rue = rueChamp.Text;
            string tel = telChamp.Text;
            string email = mailChamp.Text;
            Ville ville = Globale.mesVilles.First(x => x.Nom.Equals(villeChamp.Text, StringComparison.InvariantCultureIgnoreCase));
            TypePraticien type = (TypePraticien)lesTypesBox.SelectedItem;
            Specialite specialite = (Specialite)lesSpecialitesBox.SelectedItem;

            int idPraticien = Passerelle.ajouterPraticien(nom, prenom, rue, ville.Code, ville.Nom, tel, email, type.Id,
                specialite.Id, out string message);

            // Le message est vide il n'y a donc pas eu d'erreur lors de l'ajout du praticien
            if (message.Length == 0) {
                // On crée un objet Praticien à partir de l'id renvoyé par la procédure
                Praticien praticien = new Praticien(idPraticien, nom, prenom, rue, ville.Code, ville.Nom, tel, email,
                    type, specialite);

                // On ajoute l'objet à la liste globale
                Globale.mesPraticiens.Add(praticien);

                FrmAjoutPraticien_Load(sender, e);

                MessageBox.Show("Praticien ajouté !");
                return;
            }

            MessageBox.Show("Une erreur est survenue lors de l'ajout du praticien ! " + message);
        }
    }
}