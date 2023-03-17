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

namespace GSB {
    public partial class FrmListeVisite : FrmBase {
        public FrmListeVisite() {
            InitializeComponent();
        }

        private void FrmVisites_Load(object sender, EventArgs e) {
            // Affichage des praticiens dans le datagridview

            // Parametrage du datagridview
            dgvVisites.AllowUserToResizeColumns = false;
            dgvVisites.AllowUserToResizeRows = false;
            dgvVisites.AllowUserToAddRows = false;
            dgvVisites.AllowUserToDeleteRows = false;
            dgvVisites.MultiSelect = false;

            dgvVisites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvVisites.RowHeadersVisible = false;
            dgvVisites.ColumnCount = 4;

            dgvVisites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            // Cette colonne sert à stocker l'object Visite pour le manipuler après
            // Il n'est donc pas utile de l'afficher, on a juste besoin de la donnée
            dgvVisites.Columns[0].Visible = false;
            dgvVisites.Columns[0].Name = "Visite";

            dgvVisites.Columns[1].Name = "programmée le";
            dgvVisites.Columns[1].Width = 150;
            dgvVisites.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisites.Columns[2].Name = "à";
            dgvVisites.Columns[2].Width = 50;
            dgvVisites.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisites.Columns[3].Name = "sur";
            dgvVisites.Columns[3].Width = 150;
            dgvVisites.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            // On alimente le datagridview avec les visites
            Globale.mesVisites.ForEach(visite =>
            {
                string date = visite.DateEtHeure.ToString("dddd d MMMM yyyy");
                string heuresEtMinutes = visite.DateEtHeure.ToString("HH:mm");
                string ville = visite.LePraticien.Ville;

                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell visiteCell = new DataGridViewTextBoxCell();
                visiteCell.Value = visite;

                DataGridViewCell dateCell = new DataGridViewTextBoxCell();
                dateCell.Value = date; 
                
                DataGridViewCell heureCell = new DataGridViewTextBoxCell();
                heureCell.Value = heuresEtMinutes;  
                
                DataGridViewCell lieuCell = new DataGridViewTextBoxCell();
                lieuCell.Value = ville;

                // Le bilan a été renseigné
                if (visite.Bilan != null) {
                    row.DefaultCellStyle.ForeColor = Color.Green;
                }
                
                row.Cells.AddRange(visiteCell, dateCell, heureCell, lieuCell);
                dgvVisites.Rows.Add(row);
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
            
            // On remet les valeurs par défaut
            nomPrenomLabel.Text = "";
            rueLabel.Text = "";
            telephoneLabel.Text = "";
            emailLabel.Text = "";
            typePraticienLabel.Text = "";
            specialiteLabel.Text = "";
            motifLabel.Text = "";
            bilanBox.Text = "";
            medicamentBox.Items.Clear();

            // On récupère la ligne sélectionnée
            DataGridViewRow row = dgvVisites.Rows[e.RowIndex];

            // On récupère la première cell de la ligne
            // Première cell (0) = id 
            DataGridViewCell visiteCell = row.Cells[0];
            Visite visite = (Visite)visiteCell.Value;

            // On alimente les champs
            Praticien praticien = visite.LePraticien;
            
            nomPrenomLabel.Text = praticien.NomPrenom;
            rueLabel.Text = praticien.Rue;
            telephoneLabel.Text = praticien.Telephone;
            emailLabel.Text = praticien.Email;
            typePraticienLabel.Text = praticien.Type.Libelle;
            motifLabel.Text = visite.LeMotif.Libelle;
            bilanBox.Text = visite.Bilan ?? "";

            if (praticien.Specialite != null) { 
                specialiteLabel.Text = praticien.Specialite.Libelle;
            }

            if (visite.PremierMedicament != null) {
                medicamentBox.Items.Add(visite.PremierMedicament.Nom);
            }

            if (visite.SecondMedicament != null) {
                medicamentBox.Items.Add(visite.SecondMedicament.Nom);
            }
            
            // On selectionne la ligne
            row.Selected = true;
        }
        
        private void onSelectionChanged(object sender, EventArgs e)
        {
            // Aucune ligne n'est sélectionnée
            if (dgvVisites.SelectedRows.Count == 0) {
                return;
            }

            // On récupère la premiere ligne sélectionnée
            DataGridViewRow row = dgvVisites.SelectedRows[0];
            
            // On force le clique sur la cellule de la ligne sur la première colonne
            onCellContentClick(sender, new DataGridViewCellEventArgs(0, row.Index));
        }
    }
}