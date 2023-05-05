namespace GSB {
    partial class FrmPresentation {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvPresentation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresentation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Size = new System.Drawing.Size(800, 64);
            this.lblTitre.Text = "Presentation";
            // 
            // dgvPresentation
            // 
            this.dgvPresentation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresentation.Location = new System.Drawing.Point(35, 12);
            this.dgvPresentation.Name = "dgvPresentation";
            this.dgvPresentation.Size = new System.Drawing.Size(740, 426);
            this.dgvPresentation.TabIndex = 0;
            this.dgvPresentation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPresentation_CellClick);
            // 
            // FrmPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPresentation);
            this.Name = "FrmPresentation";
            this.Text = "FrmPresentation";
            this.Load += new System.EventHandler(this.FrmPresentation_Load);
            this.Controls.SetChildIndex(this.dgvPresentation, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresentation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPresentation;
    }
}