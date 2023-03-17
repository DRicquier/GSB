
namespace GSB
{
    partial class FrmImpressionRendezVous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImpressionRendezVous));
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgGsb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnAperçu = new System.Windows.Forms.Button();
            this.apercuXml2 = new System.Windows.Forms.PrintPreviewDialog();
            this.printXml = new System.Drawing.Printing.PrintDocument();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGsb)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTitre.Size = new System.Drawing.Size(936, 64);
            this.lblTitre.Text = "Impression des rendez-vous sur une période";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.imgGsb);
            this.panel2.Location = new System.Drawing.Point(22, 119);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 346);
            this.panel2.TabIndex = 13;
            // 
            // imgGsb
            // 
            this.imgGsb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgGsb.BackgroundImage")));
            this.imgGsb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgGsb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgGsb.Location = new System.Drawing.Point(0, 0);
            this.imgGsb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgGsb.Name = "imgGsb";
            this.imgGsb.Size = new System.Drawing.Size(386, 346);
            this.imgGsb.TabIndex = 13;
            this.imgGsb.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Du";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Au";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(620, 238);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(620, 162);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // btnAperçu
            // 
            this.btnAperçu.Location = new System.Drawing.Point(628, 324);
            this.btnAperçu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAperçu.Name = "btnAperçu";
            this.btnAperçu.Size = new System.Drawing.Size(130, 38);
            this.btnAperçu.TabIndex = 18;
            this.btnAperçu.Text = "Imprimer";
            this.btnAperçu.UseVisualStyleBackColor = true;
            this.btnAperçu.Click += new System.EventHandler(this.btnAperçu_Click);
            // 
            // apercuXml2
            // 
            this.apercuXml2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.apercuXml2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.apercuXml2.ClientSize = new System.Drawing.Size(400, 300);
            this.apercuXml2.Enabled = true;
            this.apercuXml2.Icon = ((System.Drawing.Icon)(resources.GetObject("apercuXml2.Icon")));
            this.apercuXml2.Name = "apercuXml2";
            this.apercuXml2.Visible = false;
            // 
            // printXml
            // 
            this.printXml.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printXml_PrintPage);
            // 
            // FrmImpressionRendezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 534);
            this.Controls.Add(this.btnAperçu);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FrmImpressionRendezVous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmImpressionRendezVous";
            this.Load += new System.EventHandler(this.FrmImpressionRendezVous_Load);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.Controls.SetChildIndex(this.btnAperçu, 0);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgGsb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imgGsb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnAperçu;
        private System.Windows.Forms.PrintPreviewDialog apercuXml2;
        private System.Drawing.Printing.PrintDocument printXml;
    }
}