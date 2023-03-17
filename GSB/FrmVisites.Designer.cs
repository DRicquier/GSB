
namespace GSB
{
    partial class FrmVisites
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomPrenom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rue = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.specialite = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.typePraticien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.leMotif = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.leBilan = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Size = new System.Drawing.Size(1872, 123);
            this.lblTitre.Text = "Consultation des Visites";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.leBilan);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.leMotif);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.typePraticien);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.specialite);
            this.panel2.Controls.Add(this.mail);
            this.panel2.Controls.Add(this.tel);
            this.panel2.Controls.Add(this.rue);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nomPrenom);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(6, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1860, 793);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sélectionner la visite pour afficher le détail";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(606, 697);
            this.dataGridView1.TabIndex = 15;
            // 
            // nomPrenom
            // 
            this.nomPrenom.AutoSize = true;
            this.nomPrenom.Location = new System.Drawing.Point(1019, 62);
            this.nomPrenom.Name = "nomPrenom";
            this.nomPrenom.Size = new System.Drawing.Size(127, 25);
            this.nomPrenom.TabIndex = 16;
            this.nomPrenom.Text = "nomPrenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(849, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(849, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Téléphone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(849, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Rue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(849, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Praticien";
            // 
            // rue
            // 
            this.rue.AutoSize = true;
            this.rue.Location = new System.Drawing.Point(1019, 120);
            this.rue.Name = "rue";
            this.rue.Size = new System.Drawing.Size(51, 25);
            this.rue.TabIndex = 21;
            this.rue.Text = "Rue";
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(1019, 179);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(114, 25);
            this.tel.TabIndex = 22;
            this.tel.Text = "Téléphone";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(1019, 248);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(65, 25);
            this.mail.TabIndex = 23;
            this.mail.Text = "Email";
            // 
            // specialite
            // 
            this.specialite.AutoSize = true;
            this.specialite.Location = new System.Drawing.Point(1578, 179);
            this.specialite.Name = "specialite";
            this.specialite.Size = new System.Drawing.Size(103, 25);
            this.specialite.TabIndex = 24;
            this.specialite.Text = "specialite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1376, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Spécialité";
            // 
            // typePraticien
            // 
            this.typePraticien.AutoSize = true;
            this.typePraticien.Location = new System.Drawing.Point(1578, 62);
            this.typePraticien.Name = "typePraticien";
            this.typePraticien.Size = new System.Drawing.Size(137, 25);
            this.typePraticien.TabIndex = 26;
            this.typePraticien.Text = "typePraticien";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1376, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Type praticien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1520, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Echantillons fournis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(782, 670);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Médicaments présentés";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(782, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Bilan de la visite";
            // 
            // leMotif
            // 
            this.leMotif.AutoSize = true;
            this.leMotif.Location = new System.Drawing.Point(875, 342);
            this.leMotif.Name = "leMotif";
            this.leMotif.Size = new System.Drawing.Size(76, 25);
            this.leMotif.TabIndex = 31;
            this.leMotif.Text = "leMotif";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(782, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "Motif";
            // 
            // leBilan
            // 
            this.leBilan.Location = new System.Drawing.Point(787, 433);
            this.leBilan.Multiline = true;
            this.leBilan.Name = "leBilan";
            this.leBilan.Size = new System.Drawing.Size(557, 205);
            this.leBilan.TabIndex = 33;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1494, 391);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(300, 354);
            this.dataGridView2.TabIndex = 35;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(779, 702);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(386, 85);
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FrmVisites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 1027);
            this.Controls.Add(this.panel2);
            this.Name = "FrmVisites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVisites";
            this.Load += new System.EventHandler(this.FrmVisites_Load);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox leBilan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label leMotif;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label typePraticien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label specialite;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label rue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nomPrenom;
    }
}