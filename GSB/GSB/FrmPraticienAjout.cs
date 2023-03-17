using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB {
    public partial class FrmPraticienAjout : FrmBase {
        public FrmPraticienAjout() {
            InitializeComponent();
        }

        private void FrmPraticienAjout_Load(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
           
        }

        private void ajouter(string nom, string prenom, string rue, string ville, string codePostale, string telephone, string mail, string type, string specialite) {
            bool nomOk = controlerNom(nom);
            bool prenomOk = controlerPrenom(prenom);
            bool rueOk = controlerRue(rue);
            bool villeOk = controlerVille(ville);
            bool codePostaleOk = controlerCodePostale(codePostale);
            bool telephoneOk = controlerTelephone(telephone);
            bool mailOk = controlerMail(mail);
       
            lblErreurConnexion.Visible = false;
            if (nomOk && prenomOk && rueOk && telephoneOk && mailOk && villeOk && codePostaleOk) {
                int ok = Passerelle.ajouterPraticien(nom, prenom,rue,codePostale, ville,telephone, mail,type, specialite, out string message);
                if (ok == 0) {
                    // chargement des données
                    Passerelle.chargerDonnees();
                    // On conserve le lien vers le formulaire de connexion afin de pouvoir l'afficher losque le visiteur se déconnecte 
                    Globale.formulaireConnexion = this;
                    // on instancie un nouveau formulaire menu
                    FrmMenu unFrmMenu = new FrmMenu();
                    // On masque le formulaire de connexion (le fermer reviendrait à quitter l'application)
                    this.Hide();
                    // on affiche le formulaire Menu
                    unFrmMenu.Show();
                } else {
                    lblErreurConnexion.Text = message;
                    lblErreurConnexion.Visible = true;
                }
            }

        }
        private bool controlerNom(string nom) {
            if (nom == string.Empty) {
                BulleNom.Show("Veuillez indiquer votre nom ", textBox1, 10, 30, 3000);
                return false;
            } else {
                return true;
            }
        }
        private bool controlerPrenom(string nom) {
            if (nom == string.Empty) {
                BullePrenom.Show("Veuillez indiquer votre prenom ", textBox2, 10, 30, 3000);
                return false;
            } else {
                return true;
            }
        }
        private bool controlerRue(string nom) {
            if (nom == string.Empty) {
                BulleRue.Show("Veuillez indiquer votre Rue ", textBox3, 10, 30, 3000);
                return false;
            } else {
                return true;
            }
        }
        private bool controlerVille(string nom) {
            if (nom == string.Empty) {
                BulleVille.Show("Veuillez indiquer votre Ville ", textBox4, 10, 30, 3000);
                return false;
            } else {
                return true;
            }
        }
        private bool controlerCodePostale(string nom) {
            if (nom == string.Empty) {
                BulleCodePostale.Show("Veuillez indiquer votre code postale ", textBox9, 10, 30, 3000);
                return false;
            } else {
                return true;
            }
        }
        private bool controlerTelephone(string nom) {
            if (nom == string.Empty) {
                BulleTel.Show("Veuillez indiquer votre numéro de téléphone ", textBox5, 10, 30, 3000);
                return false;
            } else {
                return true;
            }
        }
        private bool controlerMail(string nom) {
            if (nom == string.Empty) {
                BulleMail.Show("Veuillez indiquer votre adresse mail ", textBox6, 10, 30, 3000);
                return false;
            } else {
                return true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            foreach
        }
    }
}
