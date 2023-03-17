
namespace GSB
{
    partial class FrmModifierPraticien
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnModifer = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.nomChamp = new System.Windows.Forms.TextBox();
            this.prenomChamp = new System.Windows.Forms.TextBox();
            this.rueChamp = new System.Windows.Forms.TextBox();
            this.villeChamp = new System.Windows.Forms.TextBox();
            this.mailChamp = new System.Windows.Forms.TextBox();
            this.telChamp = new System.Windows.Forms.TextBox();
            this.lesTypes = new System.Windows.Forms.ComboBox();
            this.lesSpecialités = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lesPraticiens = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTitre.Size = new System.Drawing.Size(936, 54);
            this.lblTitre.Text = "Mise à jour praticien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 380);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Rue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Prenom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nom";
            // 
            // btnModifer
            // 
            this.btnModifer.Location = new System.Drawing.Point(200, 452);
            this.btnModifer.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifer.Name = "btnModifer";
            this.btnModifer.Size = new System.Drawing.Size(195, 34);
            this.btnModifer.TabIndex = 20;
            this.btnModifer.Text = "Modifier la fiche du praticien";
            this.btnModifer.UseVisualStyleBackColor = true;
            this.btnModifer.Click += new System.EventHandler(this.btnModifer_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(591, 452);
            this.btnSupp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(195, 34);
            this.btnSupp.TabIndex = 21;
            this.btnSupp.Text = "Supprimer la fiche du praticien";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // nomChamp
            // 
            this.nomChamp.Location = new System.Drawing.Point(248, 159);
            this.nomChamp.Margin = new System.Windows.Forms.Padding(2);
            this.nomChamp.Name = "nomChamp";
            this.nomChamp.Size = new System.Drawing.Size(106, 20);
            this.nomChamp.TabIndex = 22;
            // 
            // prenomChamp
            // 
            this.prenomChamp.Location = new System.Drawing.Point(597, 159);
            this.prenomChamp.Margin = new System.Windows.Forms.Padding(2);
            this.prenomChamp.Name = "prenomChamp";
            this.prenomChamp.Size = new System.Drawing.Size(198, 20);
            this.prenomChamp.TabIndex = 23;
            // 
            // rueChamp
            // 
            this.rueChamp.Location = new System.Drawing.Point(174, 216);
            this.rueChamp.Margin = new System.Windows.Forms.Padding(2);
            this.rueChamp.Name = "rueChamp";
            this.rueChamp.Size = new System.Drawing.Size(630, 20);
            this.rueChamp.TabIndex = 24;
            // 
            // villeChamp
            // 
            this.villeChamp.Location = new System.Drawing.Point(240, 260);
            this.villeChamp.Margin = new System.Windows.Forms.Padding(2);
            this.villeChamp.Name = "villeChamp";
            this.villeChamp.Size = new System.Drawing.Size(219, 20);
            this.villeChamp.TabIndex = 25;
            // 
            // mailChamp
            // 
            this.mailChamp.Location = new System.Drawing.Point(591, 326);
            this.mailChamp.Margin = new System.Windows.Forms.Padding(2);
            this.mailChamp.Name = "mailChamp";
            this.mailChamp.Size = new System.Drawing.Size(212, 20);
            this.mailChamp.TabIndex = 26;
            // 
            // telChamp
            // 
            this.telChamp.Location = new System.Drawing.Point(174, 326);
            this.telChamp.Margin = new System.Windows.Forms.Padding(2);
            this.telChamp.Name = "telChamp";
            this.telChamp.Size = new System.Drawing.Size(212, 20);
            this.telChamp.TabIndex = 27;
            // 
            // lesTypes
            // 
            this.lesTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lesTypes.FormattingEnabled = true;
            this.lesTypes.Location = new System.Drawing.Point(174, 406);
            this.lesTypes.Margin = new System.Windows.Forms.Padding(2);
            this.lesTypes.Name = "lesTypes";
            this.lesTypes.Size = new System.Drawing.Size(212, 21);
            this.lesTypes.TabIndex = 28;
            // 
            // lesSpecialités
            // 
            this.lesSpecialités.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lesSpecialités.FormattingEnabled = true;
            this.lesSpecialités.Location = new System.Drawing.Point(591, 406);
            this.lesSpecialités.Margin = new System.Windows.Forms.Padding(2);
            this.lesSpecialités.Name = "lesSpecialités";
            this.lesSpecialités.Size = new System.Drawing.Size(212, 21);
            this.lesSpecialités.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(588, 380);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Specialité";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Praticien à mettre à jour";
            // 
            // lesPraticiens
            // 
            this.lesPraticiens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lesPraticiens.FormattingEnabled = true;
            this.lesPraticiens.Location = new System.Drawing.Point(516, 96);
            this.lesPraticiens.Margin = new System.Windows.Forms.Padding(2);
            this.lesPraticiens.Name = "lesPraticiens";
            this.lesPraticiens.Size = new System.Drawing.Size(174, 21);
            this.lesPraticiens.TabIndex = 32;
            this.lesPraticiens.SelectedIndexChanged += new System.EventHandler(this.lesPraticiens_SelectedIndexChanged);
            // 
            // FrmModifPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 534);
            this.Controls.Add(this.lesPraticiens);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lesSpecialités);
            this.Controls.Add(this.lesTypes);
            this.Controls.Add(this.telChamp);
            this.Controls.Add(this.mailChamp);
            this.Controls.Add(this.villeChamp);
            this.Controls.Add(this.rueChamp);
            this.Controls.Add(this.prenomChamp);
            this.Controls.Add(this.nomChamp);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModifer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmModifierPraticien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModifPraticien";
            this.Load += new System.EventHandler(this.FrmModifPraticien_Load);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnModifer, 0);
            this.Controls.SetChildIndex(this.btnSupp, 0);
            this.Controls.SetChildIndex(this.nomChamp, 0);
            this.Controls.SetChildIndex(this.prenomChamp, 0);
            this.Controls.SetChildIndex(this.rueChamp, 0);
            this.Controls.SetChildIndex(this.villeChamp, 0);
            this.Controls.SetChildIndex(this.mailChamp, 0);
            this.Controls.SetChildIndex(this.telChamp, 0);
            this.Controls.SetChildIndex(this.lesTypes, 0);
            this.Controls.SetChildIndex(this.lesSpecialités, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.lesPraticiens, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnModifer;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.TextBox nomChamp;
        private System.Windows.Forms.TextBox prenomChamp;
        private System.Windows.Forms.TextBox rueChamp;
        private System.Windows.Forms.TextBox villeChamp;
        private System.Windows.Forms.TextBox mailChamp;
        private System.Windows.Forms.TextBox telChamp;
        private System.Windows.Forms.ComboBox lesTypes;
        private System.Windows.Forms.ComboBox lesSpecialités;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox lesPraticiens;
    }
}