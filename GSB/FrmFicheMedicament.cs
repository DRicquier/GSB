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
    public partial class FrmFicheMedicament : FrmBase
    {
        public FrmFicheMedicament()
        {
            InitializeComponent();
        }

        private void FrmFicheMedicament_Load(object sender, EventArgs e)
        {
            // Charger les données à partir de Globale
            
            // Auto completion pour les médicaments
            // Attention, lorsque DropDownStyle = DropDownList et que AutoCompleteSource = ListItems
            // alors AutoCompleteMode doit obligatoirement être = None
            
            Globale.lesMedicaments.ForEach(medicament => lesMedicaments.Items.Add(medicament));
            lesMedicaments.DropDownStyle = ComboBoxStyle.DropDown;
            lesMedicaments.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            lesMedicaments.AutoCompleteSource = AutoCompleteSource.ListItems;

            // La proprité ReadOnly permet d'empêcher l'utilisateur de modifier la valeur
            familleMedoc.ReadOnly = true;
            compoMedoc.ReadOnly = true;
            effetMedoc.ReadOnly = true;
            contreIndicMedoc.ReadOnly = true;
            
            // Par défaut on selectionne le premier médicament si il existe
            if (lesMedicaments.Items.Count > 0)
            {
                lesMedicaments.SelectedIndex = 0;
            }
        }

        private void lesMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mesure de sécurité
            if (lesMedicaments.SelectedItem == null)
            {
                return;
            }
            
            Medicament medicament = (Medicament)lesMedicaments.SelectedItem;

            familleMedoc.Text = medicament.LaFamille.Libelle;
            compoMedoc.Text = medicament.Composition;
            effetMedoc.Text = medicament.Effets;
            contreIndicMedoc.Text = medicament.ContreIndication;
        }
    }
}
