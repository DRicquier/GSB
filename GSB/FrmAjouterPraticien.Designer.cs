
namespace GSB
{
    partial class FrmAjouterPraticien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lesSpecialitesBox = new System.Windows.Forms.ComboBox();
            this.lesTypesBox = new System.Windows.Forms.ComboBox();
            this.nomChamp = new System.Windows.Forms.TextBox();
            this.prenomChamp = new System.Windows.Forms.TextBox();
            this.rueChamp = new System.Windows.Forms.TextBox();
            this.villeChamp = new System.Windows.Forms.TextBox();
            this.telChamp = new System.Windows.Forms.TextBox();
            this.mailChamp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTitre.Size = new System.Drawing.Size(936, 64);
            this.lblTitre.Text = "Ajouter un praticien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Téléphone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Rue";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(493, 38);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(43, 13);
            this.label.TabIndex = 18;
            this.label.Text = "Prenom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nom";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAjouter);
            this.panel2.Controls.Add(this.lesSpecialitesBox);
            this.panel2.Controls.Add(this.lesTypesBox);
            this.panel2.Controls.Add(this.nomChamp);
            this.panel2.Controls.Add(this.prenomChamp);
            this.panel2.Controls.Add(this.rueChamp);
            this.panel2.Controls.Add(this.villeChamp);
            this.panel2.Controls.Add(this.telChamp);
            this.panel2.Controls.Add(this.mailChamp);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label);
            this.panel2.Location = new System.Drawing.Point(6, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 414);
            this.panel2.TabIndex = 21;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(385, 363);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(151, 41);
            this.btnAjouter.TabIndex = 32;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lesSpecialitesBox
            // 
            this.lesSpecialitesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lesSpecialitesBox.FormattingEnabled = true;
            this.lesSpecialitesBox.Location = new System.Drawing.Point(496, 326);
            this.lesSpecialitesBox.Margin = new System.Windows.Forms.Padding(2);
            this.lesSpecialitesBox.Name = "lesSpecialitesBox";
            this.lesSpecialitesBox.Size = new System.Drawing.Size(229, 21);
            this.lesSpecialitesBox.TabIndex = 31;
            // 
            // lesTypesBox
            // 
            this.lesTypesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lesTypesBox.FormattingEnabled = true;
            this.lesTypesBox.Location = new System.Drawing.Point(164, 326);
            this.lesTypesBox.Margin = new System.Windows.Forms.Padding(2);
            this.lesTypesBox.Name = "lesTypesBox";
            this.lesTypesBox.Size = new System.Drawing.Size(196, 21);
            this.lesTypesBox.TabIndex = 30;
            // 
            // nomChamp
            // 
            this.nomChamp.Location = new System.Drawing.Point(164, 60);
            this.nomChamp.Margin = new System.Windows.Forms.Padding(2);
            this.nomChamp.Name = "nomChamp";
            this.nomChamp.Size = new System.Drawing.Size(91, 20);
            this.nomChamp.TabIndex = 29;
            // 
            // prenomChamp
            // 
            this.prenomChamp.Location = new System.Drawing.Point(496, 60);
            this.prenomChamp.Margin = new System.Windows.Forms.Padding(2);
            this.prenomChamp.Name = "prenomChamp";
            this.prenomChamp.Size = new System.Drawing.Size(118, 20);
            this.prenomChamp.TabIndex = 28;
            // 
            // rueChamp
            // 
            this.rueChamp.Location = new System.Drawing.Point(164, 127);
            this.rueChamp.Margin = new System.Windows.Forms.Padding(2);
            this.rueChamp.Name = "rueChamp";
            this.rueChamp.Size = new System.Drawing.Size(635, 20);
            this.rueChamp.TabIndex = 27;
            // 
            // villeChamp
            // 
            this.villeChamp.Location = new System.Drawing.Point(223, 173);
            this.villeChamp.Margin = new System.Windows.Forms.Padding(2);
            this.villeChamp.Name = "villeChamp";
            this.villeChamp.Size = new System.Drawing.Size(211, 20);
            this.villeChamp.TabIndex = 26;
            // 
            // telChamp
            // 
            this.telChamp.Location = new System.Drawing.Point(164, 246);
            this.telChamp.Margin = new System.Windows.Forms.Padding(2);
            this.telChamp.Name = "telChamp";
            this.telChamp.Size = new System.Drawing.Size(124, 20);
            this.telChamp.TabIndex = 25;
            // 
            // mailChamp
            // 
            this.mailChamp.Location = new System.Drawing.Point(496, 246);
            this.mailChamp.Margin = new System.Windows.Forms.Padding(2);
            this.mailChamp.Name = "mailChamp";
            this.mailChamp.Size = new System.Drawing.Size(229, 20);
            this.mailChamp.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Specialité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Email";
            // 
            // FrmAjoutPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 534);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmAjouterPraticien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAjoutPraticien";
            this.Load += new System.EventHandler(this.FrmAjoutPraticien_Load);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox lesSpecialitesBox;
        private System.Windows.Forms.ComboBox lesTypesBox;
        private System.Windows.Forms.TextBox nomChamp;
        private System.Windows.Forms.TextBox prenomChamp;
        private System.Windows.Forms.TextBox rueChamp;
        private System.Windows.Forms.TextBox villeChamp;
        private System.Windows.Forms.TextBox telChamp;
        private System.Windows.Forms.TextBox mailChamp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}