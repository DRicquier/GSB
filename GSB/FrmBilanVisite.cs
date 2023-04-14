using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lesClasses;
using MySqlX.XDevAPI.Relational;

namespace GSB
{
    public partial class FrmBilanVisite : FrmBase
    {
        private Visite laVisite;
        public FrmBilanVisite()
        {
            InitializeComponent();
        }

        private void FrmBilanVisite_Load(object sender, EventArgs e)
        {
            //On met tous les champs vides
            premierMedocBox.SelectedItem = null;
            secondMedocBox.SelectedItem = null;
            medicamentsBox.SelectedItem = null;
            dgvMedicament.Rows.Clear();
            bilanBox.Text = string.Empty;


            foreach (Medicament unMedoc in Globale.lesMedicaments)
            {
                premierMedocBox.Items.Add(unMedoc);
            }
            foreach (Medicament unMedoc in Globale.lesMedicaments)
            {
                secondMedocBox.Items.Add(unMedoc);
            }

            foreach(Medicament unMedoc in Globale.lesMedicaments) {
                medicamentsBox.Items.Add(unMedoc);
            }

            //Affichage des Commandes dans le datagridView
            dgvMedicament.RowHeadersVisible = false;
            dgvMedicament.ColumnCount = 5;

            dgvMedicament.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvMedicament.Columns[0].Name = "Médicament";
            dgvMedicament.Columns[0].Width = 100;
            dgvMedicament.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMedicament.Columns[1].Name = "Quantité";
            dgvMedicament.Columns[1].Width = 100;
            dgvMedicament.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMedicament.Columns[2].Name = "+";
            dgvMedicament.Columns[2].Width = 100;
            dgvMedicament.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMedicament.Columns[3].Name = "-";
            dgvMedicament.Columns[3].Width = 100;
            dgvMedicament.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMedicament.Columns[4].Name = "X";
            dgvMedicament.Columns[4].Width = 100;
            dgvMedicament.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            

            foreach(Visite uneVisite in Globale.mesVisites) {
                if(uneVisite.Bilan == null) {
                    laVisite = uneVisite;
                    dateLabel.Text = uneVisite.DateEtHeure.ToString("dd/MM/yyyy");
                    lieuLabel.Text = uneVisite.LePraticien.Ville;
                    motifLabel.Text = uneVisite.LeMotif.Libelle;
                    praticienLabel.Text = uneVisite.LePraticien.Nom + " " + uneVisite.LePraticien.Prenom;
                    if(uneVisite.LePraticien.Type != null) {
                        typePraticienLabel.Text = uneVisite.LePraticien.Type.ToString();
                    }
                    else {
                        typePraticienLabel.Text = " ";
                    }
                    Medicament premierModoc = uneVisite.PremierMedicament;
                    premierMedocBox.SelectedItem = premierModoc;
                    Medicament secondMedoc = uneVisite.SecondMedicament;
                    secondMedocBox.SelectedItem =  secondMedoc;
                    break;

                    /*foreach(Medicament unMedicament in laVisite.lesEchantillons) {
                        dgvMedicament.Rows.Add(unMedicament.Id, unMedicament.);
                    }
                    */
                }
            }

        }

        private void brnAjouter_Click(object sender, EventArgs e) {

            DataGridViewRow row = new DataGridViewRow();

            DataGridViewTextBoxCell medicament = new DataGridViewTextBoxCell();
            medicament.Value = medicamentsBox.Text;

            DataGridViewTextBoxCell quantite = new DataGridViewTextBoxCell();
            if(Int32.Parse(quantiteBox.Text) == 0) {
                quantite.Value = 1;
            }else {
                quantite.Value = quantiteBox.Text;
            }
            

            DataGridViewImageCell plusCell = new DataGridViewImageCell(false);
            plusCell.Value = Properties.Resources.plus;
           
            plusCell.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageCell moinsCell = new DataGridViewImageCell(false);
            moinsCell.Value = Properties.Resources.moins;
            moinsCell.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageCell deleteCell = new DataGridViewImageCell(false);
            deleteCell.Value = Properties.Resources.annuler;
            deleteCell.ImageLayout = DataGridViewImageCellLayout.Zoom;

            //dgvMedicament.Rows.Add(medicamentsBox.Text, quantiteBox.Value, plusCell, Properties.Resources.moins, Properties.Resources.annuler);
            row.Cells.AddRange(medicament, quantite, plusCell, moinsCell, deleteCell);
            dgvMedicament.Rows.Add(row);
            


        }

        private void btnEnregistrer_Click(object sender, EventArgs e) {
            /* premier médicament obligatoire, deuxième non obligatoire
             * Le bouton 'Enregistrer' va mettre à jour l'objet Visite au niveau de ses propriétés Bilan, 
                PremierMedicament et SecondMedicament et demander à la classe passerelle de lancer la procédure 
                stockée de mise à jour
            */


            laVisite.Bilan = bilanBox.Text;
            if(premierMedocBox.SelectedItem is null) {
                MessageBox.Show("Vous devez obligatoirement sélectionner un premier médicament !");
            } else {
                laVisite.PremierMedicament = (Medicament)premierMedocBox.SelectedItem;
            }
            
            
            laVisite.SecondMedicament = (Medicament)secondMedocBox.SelectedItem;
            
           
            Passerelle.enregistrerBilan(laVisite, out string message);

            int laQuantite;
           

            foreach (DataGridViewRow row in dgvMedicament.Rows) {
                 laQuantite = int.Parse(row.Cells[1].Value.ToString());

                Medicament medicament = Globale.lesMedicaments.Find(i => i.Id == row.Cells[0].Value.ToString());

                Console.Write(row.Cells[0].Value.ToString());
                Passerelle.ajouterEchantillon(laVisite.Id, medicament.Id, laQuantite, out string leMessage);
                
            }
            MessageBox.Show("Le bilan a bien été enregistré");

            FrmBilanVisite_Load(sender, e);
        }

        private void dgvMedicament_CellClick(object sender, DataGridViewCellEventArgs e) {  
            DataGridViewRow laLigne = dgvMedicament.Rows[e.RowIndex];
            int laQuantite = int.Parse(laLigne.Cells[1].Value.ToString());
            
            if (e.ColumnIndex == 2 ) {
                laQuantite += 1;
                laLigne.Cells[1].Value = laQuantite;
            }
            else if (e.ColumnIndex == 3) {
                laQuantite -= 1;
                laLigne.Cells[1].Value = laQuantite;
            } else if (e.ColumnIndex == 4) {
                dgvMedicament.Rows.Remove(laLigne);
            }
        }
    }
}
