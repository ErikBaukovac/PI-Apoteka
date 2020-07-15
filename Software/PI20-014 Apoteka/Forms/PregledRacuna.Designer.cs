namespace Apoteka
{
    partial class PregledRacunaFrm
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
            this.lblPopisRacuna = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.broj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrikaziRacun = new System.Windows.Forms.Button();
            this.btnOdustaniRacun = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPopisRacuna
            // 
            this.lblPopisRacuna.AutoSize = true;
            this.lblPopisRacuna.Location = new System.Drawing.Point(11, 9);
            this.lblPopisRacuna.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPopisRacuna.Name = "lblPopisRacuna";
            this.lblPopisRacuna.Size = new System.Drawing.Size(82, 16);
            this.lblPopisRacuna.TabIndex = 0;
            this.lblPopisRacuna.Text = "Popis računa:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.broj,
            this.zaposlenik,
            this.datum});
            this.dataGridView1.Location = new System.Drawing.Point(13, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(640, 235);
            this.dataGridView1.TabIndex = 1;
            // 
            // broj
            // 
            this.broj.HeaderText = "Broj";
            this.broj.MinimumWidth = 6;
            this.broj.Name = "broj";
            this.broj.Width = 125;
            // 
            // zaposlenik
            // 
            this.zaposlenik.HeaderText = "Zaposlenik";
            this.zaposlenik.MinimumWidth = 6;
            this.zaposlenik.Name = "zaposlenik";
            this.zaposlenik.Width = 300;
            // 
            // datum
            // 
            this.datum.HeaderText = "Datum";
            this.datum.MinimumWidth = 6;
            this.datum.Name = "datum";
            this.datum.Width = 200;
            // 
            // btnPrikaziRacun
            // 
            this.btnPrikaziRacun.Location = new System.Drawing.Point(445, 301);
            this.btnPrikaziRacun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrikaziRacun.Name = "btnPrikaziRacun";
            this.btnPrikaziRacun.Size = new System.Drawing.Size(96, 33);
            this.btnPrikaziRacun.TabIndex = 2;
            this.btnPrikaziRacun.Text = "Prikaži račun";
            this.btnPrikaziRacun.UseVisualStyleBackColor = true;
            this.btnPrikaziRacun.Click += new System.EventHandler(this.btnPrikaziRacun_Click);
            // 
            // btnOdustaniRacun
            // 
            this.btnOdustaniRacun.Location = new System.Drawing.Point(557, 301);
            this.btnOdustaniRacun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOdustaniRacun.Name = "btnOdustaniRacun";
            this.btnOdustaniRacun.Size = new System.Drawing.Size(96, 33);
            this.btnOdustaniRacun.TabIndex = 4;
            this.btnOdustaniRacun.Text = "Odustani";
            this.btnOdustaniRacun.UseVisualStyleBackColor = true;
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // PregledRacunaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(666, 347);
            this.Controls.Add(this.btnOdustaniRacun);
            this.Controls.Add(this.btnPrikaziRacun);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPopisRacuna);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Pregled");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PregledRacunaFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "Pregled računa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPopisRacuna;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrikaziRacun;
        private System.Windows.Forms.DataGridViewTextBoxColumn broj;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.Button btnOdustaniRacun;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}