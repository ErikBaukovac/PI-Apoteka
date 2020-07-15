namespace PI20_014
{
    partial class BrisanjeZaposlenikaFrm
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
            this.odustaniBtn = new System.Windows.Forms.Button();
            this.obrisiBtn = new System.Windows.Forms.Button();
            this.zaposleniciDgv = new System.Windows.Forms.DataGridView();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // odustaniBtn
            // 
            this.odustaniBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.odustaniBtn.Location = new System.Drawing.Point(421, 239);
            this.odustaniBtn.Margin = new System.Windows.Forms.Padding(2);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(88, 36);
            this.odustaniBtn.TabIndex = 4;
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.UseVisualStyleBackColor = false;
            this.odustaniBtn.Click += new System.EventHandler(this.odustaniBtn_Click);
            // 
            // obrisiBtn
            // 
            this.obrisiBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.obrisiBtn.Location = new System.Drawing.Point(352, 239);
            this.obrisiBtn.Margin = new System.Windows.Forms.Padding(2);
            this.obrisiBtn.Name = "obrisiBtn";
            this.obrisiBtn.Size = new System.Drawing.Size(65, 36);
            this.obrisiBtn.TabIndex = 3;
            this.obrisiBtn.Text = "Obrisi";
            this.obrisiBtn.UseVisualStyleBackColor = false;
            this.obrisiBtn.Click += new System.EventHandler(this.obrisiBtn_Click);
            // 
            // zaposleniciDgv
            // 
            this.zaposleniciDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.zaposleniciDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zaposleniciDgv.Location = new System.Drawing.Point(10, 12);
            this.zaposleniciDgv.Margin = new System.Windows.Forms.Padding(2);
            this.zaposleniciDgv.Name = "zaposleniciDgv";
            this.zaposleniciDgv.RowHeadersWidth = 51;
            this.zaposleniciDgv.RowTemplate.Height = 24;
            this.zaposleniciDgv.Size = new System.Drawing.Size(500, 212);
            this.zaposleniciDgv.TabIndex = 2;
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // BrisanjeZaposlenikaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(521, 286);
            this.Controls.Add(this.odustaniBtn);
            this.Controls.Add(this.obrisiBtn);
            this.Controls.Add(this.zaposleniciDgv);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Brisanje");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BrisanjeZaposlenikaFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "Brisanje zaposlenika";
            this.Load += new System.EventHandler(this.BrisanjeZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button odustaniBtn;
        private System.Windows.Forms.Button obrisiBtn;
        private System.Windows.Forms.DataGridView zaposleniciDgv;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}