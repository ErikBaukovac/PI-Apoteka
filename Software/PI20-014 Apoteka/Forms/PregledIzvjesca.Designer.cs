namespace Apoteka
{
    partial class PregledIzvjescaFrm
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
            this.lblVrstaIzvjesca = new System.Windows.Forms.Label();
            this.cbVrstaIzvjesca = new System.Windows.Forms.ComboBox();
            this.btnSpremiPdf = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.btnOdustaniIzvjesce = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // lblVrstaIzvjesca
            // 
            this.lblVrstaIzvjesca.AutoSize = true;
            this.lblVrstaIzvjesca.Location = new System.Drawing.Point(13, 25);
            this.lblVrstaIzvjesca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVrstaIzvjesca.Name = "lblVrstaIzvjesca";
            this.lblVrstaIzvjesca.Size = new System.Drawing.Size(83, 16);
            this.lblVrstaIzvjesca.TabIndex = 1;
            this.lblVrstaIzvjesca.Text = "Vrsta izvješća:";
            // 
            // cbVrstaIzvjesca
            // 
            this.cbVrstaIzvjesca.FormattingEnabled = true;
            this.cbVrstaIzvjesca.Location = new System.Drawing.Point(14, 54);
            this.cbVrstaIzvjesca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbVrstaIzvjesca.Name = "cbVrstaIzvjesca";
            this.cbVrstaIzvjesca.Size = new System.Drawing.Size(235, 24);
            this.cbVrstaIzvjesca.TabIndex = 2;
            this.cbVrstaIzvjesca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSpremiPdf
            // 
            this.btnSpremiPdf.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSpremiPdf.Location = new System.Drawing.Point(14, 111);
            this.btnSpremiPdf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSpremiPdf.Name = "btnSpremiPdf";
            this.btnSpremiPdf.Size = new System.Drawing.Size(89, 34);
            this.btnSpremiPdf.TabIndex = 3;
            this.btnSpremiPdf.Text = "Spremi PDF";
            this.btnSpremiPdf.UseVisualStyleBackColor = false;
            // 
            // btnIspis
            // 
            this.btnIspis.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnIspis.Location = new System.Drawing.Point(107, 111);
            this.btnIspis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(89, 34);
            this.btnIspis.TabIndex = 4;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = false;
            // 
            // btnOdustaniIzvjesce
            // 
            this.btnOdustaniIzvjesce.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnOdustaniIzvjesce.Location = new System.Drawing.Point(201, 111);
            this.btnOdustaniIzvjesce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOdustaniIzvjesce.Name = "btnOdustaniIzvjesce";
            this.btnOdustaniIzvjesce.Size = new System.Drawing.Size(89, 34);
            this.btnOdustaniIzvjesce.TabIndex = 5;
            this.btnOdustaniIzvjesce.Text = "Odustani";
            this.btnOdustaniIzvjesce.UseVisualStyleBackColor = false;
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // PregledIzvjescaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(297, 164);
            this.Controls.Add(this.btnOdustaniIzvjesce);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnSpremiPdf);
            this.Controls.Add(this.cbVrstaIzvjesca);
            this.Controls.Add(this.lblVrstaIzvjesca);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Pregled");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PregledIzvjescaFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "Pregled izvješća";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVrstaIzvjesca;
        private System.Windows.Forms.ComboBox cbVrstaIzvjesca;
        private System.Windows.Forms.Button btnSpremiPdf;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Button btnOdustaniIzvjesce;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}