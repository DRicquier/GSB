
namespace GSB
{
    partial class FrmModifierVisite
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateEtHeure = new System.Windows.Forms.DateTimePicker();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateEtHeureLabel = new System.Windows.Forms.Label();
            this.nomPrenomLabel = new System.Windows.Forms.Label();
            this.dgvVisites = new System.Windows.Forms.DataGridView();
            this.btnSupp = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisites)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTitre.Size = new System.Drawing.Size(936, 64);
            this.lblTitre.Text = "Modification de la planification d\'un rendez-vous";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sélectionner la visite afin de modifier la date du rendez-vous";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Le rendez-vous chez";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(684, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "prévu initialement le";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSupp);
            this.panel2.Controls.Add(this.dateEtHeure);
            this.panel2.Controls.Add(this.btnModifier);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dateEtHeureLabel);
            this.panel2.Controls.Add(this.nomPrenomLabel);
            this.panel2.Controls.Add(this.dgvVisites);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 423);
            this.panel2.TabIndex = 16;
            // 
            // dateEtHeure
            // 
            this.dateEtHeure.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateEtHeure.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEtHeure.Location = new System.Drawing.Point(687, 176);
            this.dateEtHeure.Margin = new System.Windows.Forms.Padding(2);
            this.dateEtHeure.Name = "dateEtHeure";
            this.dateEtHeure.Size = new System.Drawing.Size(187, 20);
            this.dateEtHeure.TabIndex = 22;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(714, 221);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(122, 27);
            this.btnModifier.TabIndex = 21;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "est remis au";
            // 
            // dateEtHeureLabel
            // 
            this.dateEtHeureLabel.AutoSize = true;
            this.dateEtHeureLabel.Location = new System.Drawing.Point(684, 116);
            this.dateEtHeureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateEtHeureLabel.Name = "dateEtHeureLabel";
            this.dateEtHeureLabel.Size = new System.Drawing.Size(0, 13);
            this.dateEtHeureLabel.TabIndex = 18;
            // 
            // nomPrenomLabel
            // 
            this.nomPrenomLabel.AutoSize = true;
            this.nomPrenomLabel.Location = new System.Drawing.Point(790, 55);
            this.nomPrenomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomPrenomLabel.Name = "nomPrenomLabel";
            this.nomPrenomLabel.Size = new System.Drawing.Size(0, 13);
            this.nomPrenomLabel.TabIndex = 17;
            // 
            // dgvVisites
            // 
            this.dgvVisites.AllowUserToAddRows = false;
            this.dgvVisites.AllowUserToDeleteRows = false;
            this.dgvVisites.AllowUserToResizeColumns = false;
            this.dgvVisites.AllowUserToResizeRows = false;
            this.dgvVisites.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVisites.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVisites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisites.Location = new System.Drawing.Point(11, 43);
            this.dgvVisites.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVisites.Name = "dgvVisites";
            this.dgvVisites.ReadOnly = true;
            this.dgvVisites.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVisites.RowHeadersWidth = 82;
            this.dgvVisites.RowTemplate.Height = 33;
            this.dgvVisites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisites.Size = new System.Drawing.Size(590, 375);
            this.dgvVisites.TabIndex = 16;
            this.dgvVisites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellContentClick);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(714, 267);
            this.btnSupp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(122, 27);
            this.btnSupp.TabIndex = 23;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // FrmModifierVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 534);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmModifierVisite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVisiteModif";
            this.Load += new System.EventHandler(this.FrmVisiteModif_Load);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvVisites;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dateEtHeureLabel;
        private System.Windows.Forms.Label nomPrenomLabel;
        private System.Windows.Forms.DateTimePicker dateEtHeure;
        private System.Windows.Forms.Button btnSupp;
    }
}