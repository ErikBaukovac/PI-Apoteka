namespace PI20_014_Apoteka.Forms
{
    partial class PregledDobavljacaFrm
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
            this.dobavljaciDgv = new System.Windows.Forms.DataGridView();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dobavljaciDgv
            // 
            this.dobavljaciDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dobavljaciDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dobavljaciDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dobavljaciDgv.Location = new System.Drawing.Point(0, 0);
            this.dobavljaciDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dobavljaciDgv.Name = "dobavljaciDgv";
            this.dobavljaciDgv.RowHeadersWidth = 51;
            this.dobavljaciDgv.RowTemplate.Height = 24;
            this.dobavljaciDgv.Size = new System.Drawing.Size(708, 450);
            this.dobavljaciDgv.TabIndex = 0;
            this.dobavljaciDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dobavljaciDgv_CellContentClick);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // PregledDobavljacaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.dobavljaciDgv);
            this.helpProvider.SetHelpKeyword(this, "Pregled");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PregledDobavljacaFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "DostupniDobavljaci";
            this.Load += new System.EventHandler(this.DostupniDobavljaciFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dobavljaciDgv;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}