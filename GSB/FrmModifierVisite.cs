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
    public partial class FrmModifierVisite : FrmBase
    {
        public FrmModifierVisite()
        {
            InitializeComponent();
        }

        private void FrmVisiteModif_Load(object sender, EventArgs e)
        {
            // On réinitialise les données
            dateEtHeure.Value = DateTime.Today;

            // Pour afficher les heures en format 24h et non en format am/pm
            dateEtHeure.Format = DateTimePickerFormat.Custom;
            dateEtHeure.CustomFormat = "dd/MM/yyyy HH:mm";
            
            dgvVisites.ClearSelection();
            dgvVisites.Rows.Clear();
            dgvVisites.Columns.Clear();

            dgvVisites.RowHeadersVisible = false;
            dgvVisites.ColumnCount = 5;

            dgvVisites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvVisites.Columns[0].Visible = false;
            dgvVisites.Columns[0].Name = "Id";

            // todo Ajouter un bouton pour supprimer une visite

            dgvVisites.Columns[1].Name = "programmée le";
            dgvVisites.Columns[1].Width = 100;
            dgvVisites.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisites.Columns[2].Name = "à";
            dgvVisites.Columns[2].Width = 25;
            dgvVisites.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisites.Columns[3].Name = "sur";
            dgvVisites.Columns[3].Width = 50;
            dgvVisites.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisites.Columns[4].Name = "chez";
            dgvVisites.Columns[4].Width = 100;
            dgvVisites.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Pour s'assurer qu'on puisse modifier qu'1 seule visite à la fois
            dgvVisites.MultiSelect = false;

            Globale.mesVisites.ForEach(visite =>
            {
                string date = visite.DateEtHeure.ToString("dddd d MMMM yyyy");
                string heuresEtMinutes = visite.DateEtHeure.ToString("HH:mm");

                Praticien praticien = visite.LePraticien;
                string ville = praticien.Ville;
                string nomPrenom = praticien.NomPrenom;

                dgvVisites.Rows.Add(visite.Id, date, heuresEtMinutes, ville, nomPrenom);
            });
            
            // Par défaut, sélectionner la première visite si elle existe
            if (dgvVisites.RowCount > 0)
            {
                // On force le clique sur la cellule de la première ligne de première colonne
                onCellContentClick(sender, new DataGridViewCellEventArgs(0, 0));
            }
        }

        private void onCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si on clique sur la ligne des colonnes (index = -1) on annule
            if (e.RowIndex <= -1)
            {
                return;
            }

            // On récupère la ligne sélectionnée
            DataGridViewRow row = dgvVisites.Rows[e.RowIndex];

            // On récupère la première cell de la ligne
            // Première cell (0) = id 
            DataGridViewCell idCell = row.Cells[0];
            int idVisite = (int)idCell.Value;

            Visite visite = Globale.mesVisites.Find(x => x.Id.Equals(idVisite));

            // Ne devrait pas arriver mais sait-on jamais
            if (visite == null)
            {
                Console.WriteLine("Visite avec l'id " + idVisite + " non trouvée dans Globale");
                return;
            }

            // On alimente les champs
            nomPrenomLabel.Text = visite.LePraticien.NomPrenom;
            
            string date = visite.DateEtHeure.ToString("dddd d MMMM yyyy");
            string heuresEtMinutes = visite.DateEtHeure.ToString("HH:mm");
            dateEtHeureLabel.Text = date + " à " + heuresEtMinutes;
            
            dateEtHeure.Value = visite.DateEtHeure;

            // On selectionne la ligne
            row.Selected = true;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Aucune ligne sélectionnée
            if (dgvVisites.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Vous devez sélectionner une visite !");
                return;
            }

            // On récupère la premiere ligne sélectionnée
            DataGridViewRow selectedRow = dgvVisites.SelectedRows[0];

            // On récupère la première cell de la ligne
            // Première cell (0) = id 
            DataGridViewCell idCell = selectedRow.Cells[0];
            int idVisite = (int)idCell.Value;

            // La nouvelle date que l'utilisateur a sélectionnée
            DateTime date = dateEtHeure.Value;

            bool success = Passerelle.modifierRendezVous(idVisite, date, out string message);

            // L'opération a échoué
            if (!success)
            {
                // temporaire pour le debug
                Console.WriteLine(message);

                MessageBox.Show(this, message);
                return;
            }
            
            // On met à jour le cache
            Visite visite = Globale.mesVisites.Find(x => x.Id.Equals(idVisite));

            // Ne devrait pas arriver mais sait-on jamais
            if (visite == null)
            {
                Console.WriteLine("Visite avec l'id " + idVisite + " non trouvée dans Globale");
                return;
            }

            visite.deplacer(date);
            
            // On met à jour le data grid view
            FrmVisiteModif_Load(sender, e);

            MessageBox.Show(this, "Visite déplacée au " + date);
        }

        private void btnSupp_Click(object sender, EventArgs e) {

            // Aucune ligne sélectionnée
            if (dgvVisites.SelectedRows.Count == 0) {
                MessageBox.Show(this, "Vous devez sélectionner une visite !");
                return;
            }

            // On récupère la premiere ligne sélectionnée
            DataGridViewRow selectedRow = dgvVisites.SelectedRows[0];

            // On récupère la première cell de la ligne
            // Première cell (0) = id 
            DataGridViewCell idCell = selectedRow.Cells[0];
            int idVisite = (int)idCell.Value;

            bool success = Passerelle.supprimerRendezVous(idVisite, out string message);
        }
    }
}
