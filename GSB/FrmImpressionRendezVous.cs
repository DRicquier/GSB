using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GSB
{
    public partial class FrmImpressionRendezVous : FrmBase
    {
        public FrmImpressionRendezVous()
        {
            InitializeComponent();
        }

        private void FrmImpressionRendezVous_Load(object sender, EventArgs e)
        {
            parametrerComposant();
        }

        private void parametrerComposant()
        {
            WindowState = FormWindowState.Normal;
            Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            MaximizeBox = false;
            MinimizeBox = false;
        }
        private void btnAperçu_Click(object sender, EventArgs e)
        {
            apercuXml2.Document = printXml;
            apercuXml2.WindowState = FormWindowState.Maximized;
            apercuXml2.ShowDialog();
        }

        private void printXml_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // utilisation d'une police non proportionnelle pour assurer un centrage "aligné"
            // tester avec la police Arial pour voir la différence
            Font unePolice = new Font("Courier New", 16);
            // Défintion de la couleur des textes à l'intérieur d'une forme graphique 
            SolidBrush unStyle = new SolidBrush(Color.Black);

            // coordonnées du rectangle pour le titre
            // l'unité est le pixel en A4 : 827 * 1170 (100 dpi)
            float x = 50.0F;
            float y = 30.0F;
            float largeur = 727.0F;
            float hauteur = 30.0F;
            RectangleF unRectangle = new RectangleF(x, y, largeur, hauteur);
            Pen styleTrait = new Pen(Color.Black);

            // dessine le cadre du titre de la page
            e.Graphics.DrawRectangle(styleTrait, x, y, largeur, hauteur);

            // affiche le titre centré dans le cadre 
            StringFormat unFormat = new StringFormat();
            unFormat.Alignment = StringAlignment.Center;
            unFormat.LineAlignment = StringAlignment.Center;
            string texteAImprimer = " Liste des étudiants ";
            e.Graphics.DrawString(texteAImprimer, unePolice, unStyle, unRectangle, unFormat);

            // affiche l'entête du tableau
            // Chaque colonne est associée à un rectangle pour permettre un alignement de son contenu
            unePolice = new Font("Courier New", 10);
            // colonne id  x = 827 - (30 + 150 + 150 + 100) / 2
            x = 150.0F;
            y = 70.0F;
            largeur = 30.0F;
            hauteur = 20.0F;
            texteAImprimer = "Id";
            unRectangle = new RectangleF(x, y, largeur, hauteur);
            e.Graphics.DrawString(texteAImprimer, unePolice, unStyle, unRectangle, unFormat);

            // colonne Nom
            x = 180.0F;
            largeur = 100.0F;
            texteAImprimer = "Nom";
            unFormat.Alignment = StringAlignment.Near;
            unRectangle = new RectangleF(x, y, largeur, hauteur);
            e.Graphics.DrawString(texteAImprimer, unePolice, unStyle, unRectangle, unFormat);

            // colonne Prénom
            x = 330.0F;
            texteAImprimer = "Prénom";
            unRectangle = new RectangleF(x, y, largeur, hauteur);
            e.Graphics.DrawString(texteAImprimer, unePolice, unStyle, unRectangle, unFormat);

            // colonne Option
            x = 480.0F;
            texteAImprimer = "Option";
            unFormat.Alignment = StringAlignment.Center;
            largeur = 100.0F;
            unRectangle = new RectangleF(x, y, largeur, hauteur);
            e.Graphics.DrawString(texteAImprimer, unePolice, unStyle, unRectangle, unFormat);

            // Impression du trait séparant l'entête du tableau du corps
            styleTrait = new Pen(Color.Black, 3);
            Point point1 = new Point(150, 100);
            Point point2 = new Point(600, 100);
            e.Graphics.DrawLine(styleTrait, point1, point2);

            // Impression des lignes à partir de la lecture du fichier XML etudiant
            XmlDocument unDocument = new XmlDocument();
            unDocument.Load("etudiant.xml");
            XmlNodeList lesEtudiants = unDocument.GetElementsByTagName("etudiant");
            foreach (XmlNode unEtudiant in lesEtudiants)
            {
                point1 += new Size(0, 10);
                // on centre l'id
                largeur = 30.0F;
                unRectangle = new RectangleF(point1.X, point1.Y, largeur, hauteur);
                e.Graphics.DrawString(unEtudiant.Attributes[0].InnerText, unePolice, unStyle, unRectangle, unFormat);
                // on affiche le nom               
                point1 += new Size(30, 0);
                e.Graphics.DrawString(unEtudiant.ChildNodes[0].InnerText, unePolice, unStyle, point1);
                // on affiche le prénom
                point1 += new Size(150, 0);
                e.Graphics.DrawString(unEtudiant.ChildNodes[1].InnerText, unePolice, unStyle, point1);
                point1 += new Size(150, 0);
                // on centre l'option
                largeur = 100.0F;
                unRectangle = new RectangleF(point1.X, point1.Y, largeur, hauteur);
                e.Graphics.DrawString(unEtudiant.ChildNodes[2].InnerText, unePolice, unStyle, unRectangle, unFormat);
                // on se place au début de la ligne suivante 
                point1 += new Size(-330, 15);
            }
        }
    }
}
