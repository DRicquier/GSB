
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.lieu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.typePraticien = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.praticien = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.motif = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.premierMedoc = new System.Windows.Forms.ComboBox();
            this.secondMedoc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.brnAjouter = new System.Windows.Forms.Button();
            this.lesMedicamentss = new System.Windows.Forms.ComboBox();
            this.quantite = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantite)).BeginInit();
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
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(114, 138);
            this.date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(28, 13);
            this.date.TabIndex = 15;
            this.date.Text = "date";
            // 
            // lieu
            // 
            this.lieu.AutoSize = true;
            this.lieu.Location = new System.Drawing.Point(114, 167);
            this.lieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lieu.Name = "lieu";
            this.lieu.Size = new System.Drawing.Size(23, 13);
            this.lieu.TabIndex = 16;
            this.lieu.Text = "lieu";
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
            // typePraticien
            // 
            this.typePraticien.AutoSize = true;
            this.typePraticien.Location = new System.Drawing.Point(114, 272);
            this.typePraticien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typePraticien.Name = "typePraticien";
            this.typePraticien.Size = new System.Drawing.Size(68, 13);
            this.typePraticien.TabIndex = 19;
            this.typePraticien.Text = "typePraticien";
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
            // praticien
            // 
            this.praticien.AutoSize = true;
            this.praticien.Location = new System.Drawing.Point(114, 236);
            this.praticien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.praticien.Name = "praticien";
            this.praticien.Size = new System.Drawing.Size(47, 13);
            this.praticien.TabIndex = 21;
            this.praticien.Text = "praticien";
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
            // motif
            // 
            this.motif.AutoSize = true;
            this.motif.Location = new System.Drawing.Point(114, 199);
            this.motif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.motif.Name = "motif";
            this.motif.Size = new System.Drawing.Size(29, 13);
            this.motif.TabIndex = 23;
            this.motif.Text = "motif";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 349);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 139);
            this.textBox1.TabIndex = 25;
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
            // premierMedoc
            // 
            this.premierMedoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.premierMedoc.FormattingEnabled = true;
            this.premierMedoc.Location = new System.Drawing.Point(268, 195);
            this.premierMedoc.Margin = new System.Windows.Forms.Padding(2);
            this.premierMedoc.Name = "premierMedoc";
            this.premierMedoc.Size = new System.Drawing.Size(174, 21);
            this.premierMedoc.TabIndex = 29;
            // 
            // secondMedoc
            // 
            this.secondMedoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secondMedoc.FormattingEnabled = true;
            this.secondMedoc.Location = new System.Drawing.Point(268, 280);
            this.secondMedoc.Margin = new System.Windows.Forms.Padding(2);
            this.secondMedoc.Name = "secondMedoc";
            this.secondMedoc.Size = new System.Drawing.Size(174, 21);
            this.secondMedoc.TabIndex = 30;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(562, 236);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(368, 256);
            this.dataGridView1.TabIndex = 34;
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
            // lesMedicamentss
            // 
            this.lesMedicamentss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lesMedicamentss.FormattingEnabled = true;
            this.lesMedicamentss.Location = new System.Drawing.Point(562, 206);
            this.lesMedicamentss.Margin = new System.Windows.Forms.Padding(2);
            this.lesMedicamentss.Name = "lesMedicamentss";
            this.lesMedicamentss.Size = new System.Drawing.Size(144, 21);
            this.lesMedicamentss.TabIndex = 36;
            // 
            // quantite
            // 
            this.quantite.Location = new System.Drawing.Point(724, 206);
            this.quantite.Margin = new System.Windows.Forms.Padding(2);
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(44, 20);
            this.quantite.TabIndex = 37;
            // 
            // FrmBilanVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 534);
            this.Controls.Add(this.quantite);
            this.Controls.Add(this.lesMedicamentss);
            this.Controls.Add(this.brnAjouter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.secondMedoc);
            this.Controls.Add(this.premierMedoc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.motif);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.praticien);
            this.Controls.Add(this.label);
            this.Controls.Add(this.typePraticien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lieu);
            this.Controls.Add(this.date);
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
            this.Controls.SetChildIndex(this.date, 0);
            this.Controls.SetChildIndex(this.lieu, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.typePraticien, 0);
            this.Controls.SetChildIndex(this.label, 0);
            this.Controls.SetChildIndex(this.praticien, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.motif, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.premierMedoc, 0);
            this.Controls.SetChildIndex(this.secondMedoc, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.brnAjouter, 0);
            this.Controls.SetChildIndex(this.lesMedicamentss, 0);
            this.Controls.SetChildIndex(this.quantite, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label lieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label typePraticien;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label praticien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label motif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox premierMedoc;
        private System.Windows.Forms.ComboBox secondMedoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button brnAjouter;
        private System.Windows.Forms.ComboBox lesMedicamentss;
        private System.Windows.Forms.NumericUpDown quantite;
    }
}