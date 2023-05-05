using lesClasses;
using LesClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB {
    public partial class FrmPresentation : FrmBase {

        
        public FrmPresentation() {
            InitializeComponent();
        }

        private void FrmPresentation_Load(object sender, EventArgs e) {

            parametrerDgv(dgvPresentation);

            // remplir le datagridView
            foreach (Presentation presentation in Globale.lesPresentations) {
                dgvPresentation.Rows.Add(presentation, presentation.Date.ToString("dd/MM/yyyy"), presentation.Sujet);
            }

            // ajuster la largeur du datagrigview à la somme des largeur de ses colonnes
            int largeur = 0;
            foreach (DataGridViewColumn colonne in dgvPresentation.Columns) {
                if (colonne.Visible) largeur += colonne.Width + 1;
            }
            dgvPresentation.Width = largeur;

            // ajuster la hauteur du composant
            // Dimensionner la hauteur du DataGridview en fonction du nombre de lignes
            dgvPresentation.Height = Globale.lesPresentations.Count * (dgvPresentation.RowTemplate.Height + 1) + dgvPresentation.ColumnHeadersHeight;

            // centrer le composant horizontalement
            dgvPresentation.Left = (this.Width - dgvPresentation.Width) / 2;

            // Centrer verticalement
            dgvPresentation.Top = (this.Height - dgvPresentation.Height) / 2;


           
        }

        private void parametrerDgv(DataGridView dgv) {
            #region paramètrage au niveau du composant

            // accessibilité du composant
            dgv.Enabled = true;

            // permissions
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowDrop = false;
            dgv.AllowUserToOrderColumns = false;

            // largeur du composant ici elle sera calculé une fois le composant rempli les colonnes s'ajustant à leur contenu
            // dgv.Width = 322;


            //  bordures extérieures
            dgv.BorderStyle = BorderStyle.FixedSingle;

            // Bordure au niveau des cellules
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Couleur de fond 
            dgv.BackgroundColor = Color.White;

            // Couleur de texte  
            dgv.ForeColor = Color.Black;

            // Mode de sélection : FullRowSelect, CellSelect ...
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;

            // sélection multiple 
            dgv.MultiSelect = false;

            // Police de caractère des cellules
            dgv.DefaultCellStyle.Font = new Font("Georgia", 10);


            // L'utilisateur peut-il modifier le contenu des cellules ou est-elle réservée à la programmation ?
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;

            #endregion

            #region paramètrage des lignes

            // Hauteur 
            dgv.RowTemplate.Height = 30;

            // Entête de chaque ligne : visibilité et bordure 
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // couleur du texte
            dgv.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // style de bordure 
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // couleur de fond, ne pas utiliser transparent car la couleur de la ligne sélectionnée restera après sélection
            dgv.RowsDefaultCellStyle.BackColor = Color.White;

            // Couleur alternative appliquée une ligne sur deux
            // dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 238, 238, 238);

            // Couleur de fond de la ligne sélectionnée : mettre la même que les cellules si on ne veut pas mettre la zone en évidence 
            dgv.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dgv.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            #endregion

            #region paramétrage des colonnes

            // Nombre de colonne sans compter les colonnes ajoutées par la méthode Add
            dgv.ColumnCount = 3;

            // Entête des colonnes : visibilité, hauteur et style des bordure 
            dgv.ColumnHeadersVisible = true;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // style  [à adapter] (ici : noir sur fond transparent sans mise en évidence de la sélection)
            dgv.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.WhiteSmoke;
            style.ForeColor = Color.Black;
            style.SelectionBackColor = Color.WhiteSmoke;    // même couleur que backColor pour ne pas mettre en évidence la colonne sélectionnée
            style.SelectionForeColor = Color.Black;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.Font = new Font("Georgia", 12, FontStyle.Bold);

            // définition de l'ajustement de la taille des colonnes (Fill, AllCells …) 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            #endregion

            #region Définition du contenu des colonnes

            // l'objet Presentation 
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].HeaderText = "Date";
            dgv.Columns[1].Name = "Date";
            dgv.Columns[1].Width = 100;
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.Columns[2].HeaderText = "Sujet";
            dgv.Columns[2].Name = "Sujet";
            dgv.Columns[2].Width = 600;
            dgv.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            // bouton pour s'inscrire 
            DataGridViewButtonColumn uneColonneBouton = new DataGridViewButtonColumn();
            uneColonneBouton.HeaderText = "Action";
            uneColonneBouton.Name = "Action";
            uneColonneBouton.Text = "S'inscrire";
            uneColonneBouton.UseColumnTextForButtonValue = true;
            dgv.Columns.Add(uneColonneBouton);


            #endregion
        }

        private void dgvPresentation_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.ColumnIndex == 3) {
                DataGridViewRow laLigne = dgvPresentation.Rows[e.RowIndex];

                
                Presentation presentation = (Presentation) laLigne.Cells[0].Value;


                Passerelle.ajouterInscription(presentation.Id, out string message);

                if(message == string.Empty) {
                    MessageBox.Show("Vous êtes inscrit");
                } else {
                    MessageBox.Show(message);
                }

                
            }
        }
    }

}
