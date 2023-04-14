
namespace GSB
{
    partial class FrmBilanVisite
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.lieuLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.typePraticienLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.praticienLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.motifLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bilanBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.premierMedocBox = new System.Windows.Forms.ComboBox();
            this.secondMedocBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvMedicament = new System.Windows.Forms.DataGridView();
            this.brnAjouter = new System.Windows.Forms.Button();
            this.medicamentsBox = new System.Windows.Forms.ComboBox();
            this.quantiteBox = new System.Windows.Forms.NumericUpDown();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTitre.Size = new System.Drawing.Size(936, 64);
            this.lblTitre.Text = "Enregistrement du bilan d\'une visite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Les fiches sont à compléter dans l\'ordre chronologique, la fiche affichée ci-dess" +
    "ous correspond à votre première visite réaliséenmais non complétée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Le";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(114, 138);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(28, 13);
            this.dateLabel.TabIndex = 15;
            this.dateLabel.Text = "date";
            // 
            // lieuLabel
            // 
            this.lieuLabel.AutoSize = true;
            this.lieuLabel.Location = new System.Drawing.Point(114, 167);
            this.lieuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lieuLabel.Name = "lieuLabel";
            this.lieuLabel.Size = new System.Drawing.Size(23, 13);
            this.lieuLabel.TabIndex = 16;
            this.lieuLabel.Text = "lieu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Lieu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Motif";
            // 
            // typePraticienLabel
            // 
            this.typePraticienLabel.AutoSize = true;
            this.typePraticienLabel.Location = new System.Drawing.Point(114, 272);
            this.typePraticienLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typePraticienLabel.Name = "typePraticienLabel";
            this.typePraticienLabel.Size = new System.Drawing.Size(68, 13);
            this.typePraticienLabel.TabIndex = 19;
            this.typePraticienLabel.Text = "typePraticien";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(30, 272);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(74, 13);
            this.label.TabIndex = 20;
            this.label.Text = "Type praticien";
            // 
            // praticienLabel
            // 
            this.praticienLabel.AutoSize = true;
            this.praticienLabel.Location = new System.Drawing.Point(114, 236);
            this.praticienLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.praticienLabel.Name = "praticienLabel";
            this.praticienLabel.Size = new System.Drawing.Size(47, 13);
            this.praticienLabel.TabIndex = 21;
            this.praticienLabel.Text = "praticien";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 236);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Praticien";
            // 
            // motifLabel
            // 
            this.motifLabel.AutoSize = true;
            this.motifLabel.Location = new System.Drawing.Point(114, 199);
            this.motifLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.motifLabel.Name = "motifLabel";
            this.motifLabel.Size = new System.Drawing.Size(29, 13);
            this.motifLabel.TabIndex = 23;
            this.motifLabel.Text = "motif";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Bilan de la visite";
            // 
            // bilanBox
            // 
            this.bilanBox.Location = new System.Drawing.Point(32, 349);
            this.bilanBox.Margin = new System.Windows.Forms.Padding(2);
            this.bilanBox.Multiline = true;
            this.bilanBox.Name = "bilanBox";
            this.bilanBox.Size = new System.Drawing.Size(410, 139);
            this.bilanBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Informations à renseigner après la visite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Premier médicament présenté";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 255);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Second médicament présenté";
            // 
            // premierMedocBox
            // 
            this.premierMedocBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.premierMedocBox.FormattingEnabled = true;
            this.premierMedocBox.Location = new System.Drawing.Point(268, 195);
            this.premierMedocBox.Margin = new System.Windows.Forms.Padding(2);
            this.premierMedocBox.Name = "premierMedocBox";
            this.premierMedocBox.Size = new System.Drawing.Size(174, 21);
            this.premierMedocBox.TabIndex = 29;
            // 
            // secondMedocBox
            // 
            this.secondMedocBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secondMedocBox.FormattingEnabled = true;
            this.secondMedocBox.Location = new System.Drawing.Point(268, 280);
            this.secondMedocBox.Margin = new System.Windows.Forms.Padding(2);
            this.secondMedocBox.Name = "secondMedocBox";
            this.secondMedocBox.Size = new System.Drawing.Size(174, 21);
            this.secondMedocBox.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(721, 187);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Quantité";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(560, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Echantillon distribués";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(560, 187);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Médicament";
            // 
            // dgvMedicament
            // 
            this.dgvMedicament.AllowUserToAddRows = false;
            this.dgvMedicament.AllowUserToDeleteRows = false;
            this.dgvMedicament.AllowUserToResizeColumns = false;
            this.dgvMedicament.AllowUserToResizeRows = false;
            this.dgvMedicament.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMedicament.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicament.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicament.Location = new System.Drawing.Point(562, 236);
            this.dgvMedicament.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMedicament.Name = "dgvMedicament";
            this.dgvMedicament.ReadOnly = true;
            this.dgvMedicament.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMedicament.RowHeadersWidth = 82;
            this.dgvMedicament.RowTemplate.Height = 33;
            this.dgvMedicament.Size = new System.Drawing.Size(368, 256);
            this.dgvMedicament.TabIndex = 34;
            this.dgvMedicament.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicament_CellClick);
            // 
            // brnAjouter
            // 
            this.brnAjouter.Location = new System.Drawing.Point(826, 206);
            this.brnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.brnAjouter.Name = "brnAjouter";
            this.brnAjouter.Size = new System.Drawing.Size(80, 19);
            this.brnAjouter.TabIndex = 35;
            this.brnAjouter.Text = "Ajouter";
            this.brnAjouter.UseVisualStyleBackColor = true;
            this.brnAjouter.Click += new System.EventHandler(this.brnAjouter_Click);
            // 
            // medicamentsBox
            // 
            this.medicamentsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medicamentsBox.FormattingEnabled = true;
            this.medicamentsBox.Location = new System.Drawing.Point(562, 206);
            this.medicamentsBox.Margin = new System.Windows.Forms.Padding(2);
            this.medicamentsBox.Name = "medicamentsBox";
            this.medicamentsBox.Size = new System.Drawing.Size(144, 21);
            this.medicamentsBox.TabIndex = 36;
            // 
            // quantiteBox
            // 
            this.quantiteBox.Location = new System.Drawing.Point(724, 206);
            this.quantiteBox.Margin = new System.Windows.Forms.Padding(2);
            this.quantiteBox.Name = "quantiteBox";
            this.quantiteBox.Size = new System.Drawing.Size(44, 20);
            this.quantiteBox.TabIndex = 37;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(367, 518);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(232, 46);
            this.btnEnregistrer.TabIndex = 38;
            this.btnEnregistrer.Text = "Enregistrer le bilan";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // FrmBilanVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 607);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.quantiteBox);
            this.Controls.Add(this.medicamentsBox);
            this.Controls.Add(this.brnAjouter);
            this.Controls.Add(this.dgvMedicament);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.secondMedocBox);
            this.Controls.Add(this.premierMedocBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bilanBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.motifLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.praticienLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.typePraticienLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lieuLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmBilanVisite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBilanVisite";
            this.Load += new System.EventHandler(this.FrmBilanVisite_Load);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dateLabel, 0);
            this.Controls.SetChildIndex(this.lieuLabel, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.typePraticienLabel, 0);
            this.Controls.SetChildIndex(this.label, 0);
            this.Controls.SetChildIndex(this.praticienLabel, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.motifLabel, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.bilanBox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.premierMedocBox, 0);
            this.Controls.SetChildIndex(this.secondMedocBox, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.dgvMedicament, 0);
            this.Controls.SetChildIndex(this.brnAjouter, 0);
            this.Controls.SetChildIndex(this.medicamentsBox, 0);
            this.Controls.SetChildIndex(this.quantiteBox, 0);
            this.Controls.SetChildIndex(this.btnEnregistrer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label lieuLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label typePraticienLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label praticienLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label motifLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bilanBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox premierMedocBox;
        private System.Windows.Forms.ComboBox secondMedocBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvMedicament;
        private System.Windows.Forms.Button brnAjouter;
        private System.Windows.Forms.ComboBox medicamentsBox;
        private System.Windows.Forms.NumericUpDown quantiteBox;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}