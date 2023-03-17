namespace GSB
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.imgGsb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgGsb)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitre.Size = new System.Drawing.Size(1356, 94);
            // 
            // imgGsb
            // 
            this.imgGsb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgGsb.BackgroundImage")));
            this.imgGsb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgGsb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgGsb.Location = new System.Drawing.Point(0, 151);
            this.imgGsb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgGsb.Name = "imgGsb";
            this.imgGsb.Size = new System.Drawing.Size(1356, 570);
            this.imgGsb.TabIndex = 12;
            this.imgGsb.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 792);
            this.Controls.Add(this.imgGsb);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.imgGsb, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgGsb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgGsb;
    }
}