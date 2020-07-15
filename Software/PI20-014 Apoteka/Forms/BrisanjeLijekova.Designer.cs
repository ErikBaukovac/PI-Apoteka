namespace PI20_014
{
    partial class brisanjeLijekovaFrm
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
            this.lijekoviDgv = new System.Windows.Forms.DataGridView();
            this.obrisiBtn = new System.Windows.Forms.Button();
            this.odustaniBtn = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lijekoviDgv
            // 
            this.lijekoviDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.lijekoviDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lijekoviDgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.lijekoviDgv.Location = new System.Drawing.Point(10, 12);
            this.lijekoviDgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lijekoviDgv.Name = "lijekoviDgv";
            this.lijekoviDgv.RowHeadersWidth = 51;
            this.lijekoviDgv.RowTemplate.Height = 24;
            this.lijekoviDgv.Size = new System.Drawing.Size(500, 212);
            this.lijekoviDgv.TabIndex = 0;
            // 
            // obrisiBtn
            // 
            this.obrisiBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.obrisiBtn.Location = new System.Drawing.Point(349, 251);
            this.obrisiBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.obrisiBtn.Name = "obrisiBtn";
            this.obrisiBtn.Size = new System.Drawing.Size(65, 36);
            this.obrisiBtn.TabIndex = 1;
            this.obrisiBtn.Text = "Obrisi";
            this.obrisiBtn.UseVisualStyleBackColor = false;
            this.obrisiBtn.Click += new System.EventHandler(this.obrisiBtn_Click);
            // 
            // odustaniBtn
            // 
            this.odustaniBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.odustaniBtn.Location = new System.Drawing.Point(429, 251);
            this.odustaniBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(82, 36);
            this.odustaniBtn.TabIndex = 1;
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.UseVisualStyleBackColor = false;
            this.odustaniBtn.Click += new System.EventHandler(this.odustaniBtn_Click);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // brisanjeLijekovaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(537, 306);
            this.Controls.Add(this.odustaniBtn);
            this.Controls.Add(this.obrisiBtn);
            this.Controls.Add(this.lijekoviDgv);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Brisanje");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "brisanjeLijekovaFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "Brisanje lijekova";
            this.Load += new System.EventHandler(this.brisanjeLijekovaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lijekoviDgv;
        private System.Windows.Forms.Button obrisiBtn;
        private System.Windows.Forms.Button odustaniBtn;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}