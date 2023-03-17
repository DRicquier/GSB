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

namespace GSB {
    public partial class FrmImpressionRendezVous : FrmBase {
        public FrmImpressionRendezVous() {
            InitializeComponent();
        }

        private void FrmImpressionRendezVous_Load(object sender, EventArgs e) {
            parametrerComposant();
        }

        private void parametrerComposant() {
            WindowState = FormWindowState.Normal;
            Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            MaximizeBox = false;
            MinimizeBox = false;
        }
        private void btnAperçu_Click(object sender, EventArgs e) {
            apercuXml2.Document = printXml;
            apercuXml2.WindowState = FormWindowState.Maximized;
            apercuXml2.ShowDialog();
        }

        private void printXml_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            // par défaut on considère qu'il n'y aura pas une autre page
            e.HasMorePages = false;

            Font unePolice = new Font("Arial", 14);
            SolidBrush unStyle = new SolidBrush(Color.Black);

            // coordonnées du rectangle pour le titre
            float x = 10.0F;
            float y = 30.0F;
            float largeur = 790.0F;
            float hauteur = 40.0F;
            RectangleF unRectangle = new RectangleF(x, y, largeur, hauteur);
            Pen styleTrait = new Pen(Color.Black);

            // dessine le cadre du titre de la page
            e.Graphics.DrawRectangle(styleTrait, x, y, largeur, hauteur);

            // affiche le titre centré dans le cadre 
            StringFormat unFormat = new StringFormat();
            unFormat.Alignment = StringAlignment.Center;
            unFormat.LineAlignment = StringAlignment.Center;
            string texteAImprimer = "Mes rendez-vous entre le " + dateTimePicker1.Value.ToString("dddd d MMMM yyyy") + " et le " + dateTimePicker2.Value.ToString("dddd d MMMM yyyy");
            e.Graphics.DrawString(texteAImprimer, unePolice, unStyle, unRectangle, unFormat);

            // affiche l'entête du tableau
            // Chaque colonne est associée à un rectangle pour permettre un alignement de son contenu
            unePolice = new Font("Arial", 8);
            // colonne Date
            x = 20.0F;
            y = 70.0F;
            largeur = 100.0F;
            hauteur = 20.0F;
            texteAImprimer = "Date";
            unRectangle = new RectangleF(x, y, largeur, hauteur);
            unFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(texteAImprimer, unePolice, unStyle, unRectangle, unFormat);

            // colonne Heure
            x = 150.0F;
            largeur = 100.0F;
            texteAImprimer = "Heure";
            unFormat.Alignment = StringAlignment.Center;
            unRectangle = new RectangleF(x, y, largeur, hauteur);
            e.Graphics.DrawString(texteAImprimer, unePolice, unStyle, unRectangle, unFormat);

            // colonne Praticien
            x = 230.0F;
            texteAImprimer = "Praticien";
            unRectangle = new RectangleF(x, y, largeur, hauteur);
            e.Graphics.DrawString(texteAImprimer, unePolice, unStyle, unRectangle, unFormat);

            // colonne Tel
            x = 350.0F;
            texteAImprimer = "Téléphone";
            unFormat.Alignment = StringAlignment.Center;
            largeur = 100.0F;
            unRectangle = new RectangleF(x, y, largeur, hauteur);
            e.Graphics.DrawString(texteAImprimer, unePolice, unStyle, unRectangle, unFormat);


            // colonne Lieu
            x = 430.0F;
            texteAImprimer = "Lieu";
            unFormat.Alignment = StringAlignment.Center;
            largeur = 100.0F;
            unRectangle = new RectangleF(x, y, largeur, hauteur);
            e.Graphics.DrawString(texteAImprimer, unePolice, unStyle, unRectangle, unFormat);

            // colonne Motif
            x = 650.0F;
            texteAImprimer = "Motif";
            unFormat.Alignment = StringAlignment.Center;
            largeur = 100.0F;
            unRectangle = new RectangleF(x, y, largeur, hauteur);
            e.Graphics.DrawString(texteAImprimer, unePolice, unStyle, unRectangle, unFormat);


            // Impression du trait séparant l'entête du tableau du corps
            styleTrait = new Pen(Color.Black, 3);
            Point point1 = new Point(20, 100);
            Point point2 = new Point(800, 100);
            e.Graphics.DrawLine(styleTrait, point1, point2);

            //Remplir chaque lignes avec les visites

            Globale.mesVisites.ForEach(visite => {

                if (visite.DateEtHeure >= dateTimePicker1.Value && visite.DateEtHeure <= dateTimePicker2.Value) {

                    // on affiche la date
                    largeur = 200.0F;
                    hauteur = 40.0F;
                    unRectangle = new RectangleF(point1.X, point1.Y, largeur, hauteur);
                    unFormat.Alignment = StringAlignment.Near;
                    e.Graphics.DrawString(visite.DateEtHeure.ToString("dddd d MMMM yyyy"), unePolice, unStyle, unRectangle, unFormat);

                    // on affiche l'heure             
                    point1 += new Size(165, 0);
                    unRectangle = new RectangleF(point1.X, point1.Y, largeur, hauteur);
                    e.Graphics.DrawString(visite.DateEtHeure.ToString("HH:mm"), unePolice, unStyle, unRectangle, unFormat);

                    // on affiche le praticien
                    point1 += new Size(70, 0);
                    largeur = 105.0F;
                    unRectangle = new RectangleF(point1.X, point1.Y, largeur, hauteur);
                    e.Graphics.DrawString(visite.LePraticien.NomPrenom, unePolice, unStyle, unRectangle, unFormat);

                    // on affiche le téléphone
                    point1 += new Size(110, 0);
                    largeur = 200.0F;
                    unRectangle = new RectangleF(point1.X, point1.Y, largeur, hauteur);
                    e.Graphics.DrawString(visite.LePraticien.Telephone, unePolice, unStyle, unRectangle, unFormat);

                    // on affiche le lieu
                    point1 += new Size(100, 0);
                    largeur = 300.0F;
                    unRectangle = new RectangleF(point1.X, point1.Y, largeur, hauteur);
                    e.Graphics.DrawString(visite.LePraticien.Rue + " " + visite.LePraticien.Ville, unePolice, unStyle, unRectangle, unFormat);

                    // on affiche le motif
                    point1 += new Size(220, 0);
                    largeur = 100.0F;
                    unRectangle = new RectangleF(point1.X, point1.Y, largeur, hauteur);
                    e.Graphics.DrawString(visite.LeMotif.Libelle, unePolice, unStyle, unRectangle, unFormat);


                    // on se place au début de la ligne suivante 
                    point1 += new Size(-665, 30);

                    // a t-on atteint la fin de la page 
                    if (point1.Y >= e.PageBounds.Height - e.PageSettings.Margins.Top) {
                        e.HasMorePages = true; // on prévoit de relancer la procédure
                                               // il faut arrêter la procédure en cours (pas structuré mais seul moyen ici)
                        return;
                    }
                }
            });
    }
}
}
