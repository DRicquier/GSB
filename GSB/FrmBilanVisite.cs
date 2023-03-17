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
                premierMedoc.Items.Add(unMedoc);
            }
            foreach (Medicament unMedoc in Globale.lesMedicaments)
            {
                secondMedoc.Items.Add(unMedoc);
            }

            //Affichage des Commandes dans le datagridView
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 5;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns[0].Name = "Médicament";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[1].Name = "Quantité";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[2].Name = "+";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[3].Name = "-";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[4].Name = "X";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }

        private void brnAjouter_Click(object sender, EventArgs e) {

            Icon icoPlus = new Icon("Ressources/plus.ico");
            Icon icoMoins = new Icon("Ressources/moins.ico");
            Icon icoCroix = new Icon("Ressource/croix.ico");

            dataGridView1.Rows.Add(lesMedicamentss.Text, quantite.Value,icoPlus , icoMoins, icoCroix);
        }
    }
}
