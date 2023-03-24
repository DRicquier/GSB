﻿using System;
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
    public partial class FrmBilanVisite : FrmBase
    {
        public FrmBilanVisite()
        {
            InitializeComponent();
        }

        private void FrmBilanVisite_Load(object sender, EventArgs e)
        {

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
                    dateLabel.Text = uneVisite.DateEtHeure.ToString("dd/MM/yyyy");
                    lieuLabel.Text = uneVisite.LePraticien.Ville;
                    motifLabel.Text = uneVisite.LeMotif.Libelle;
                    praticienLabel.Text = uneVisite.LePraticien.Nom + " " + uneVisite.LePraticien.Prenom;
                    Medicament premierModoc = uneVisite.PremierMedicament;
                    premierMedocBox.SelectedItem = premierModoc;
                    Medicament secondMedoc = uneVisite.SecondMedicament;
                    secondMedocBox.SelectedItem =  secondMedoc;
                    break;
                }
            }

        }

        private void brnAjouter_Click(object sender, EventArgs e) {

            Icon icoPlus = new Icon("../../Resources/plus.ico");
            Icon icoMoins = new Icon("../../Resources/moins.ico");
            Icon icoCroix = new Icon("../../Resources/croix.ico");

            dgvMedicament.Rows.Add(medicamentsBox.Text, quantiteBox.Value,icoPlus, icoMoins, icoCroix);
        }

    }
}
