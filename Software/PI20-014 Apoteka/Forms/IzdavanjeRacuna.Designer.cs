namespace Apoteka
{
    partial class IzdavanjeRacunaFrm
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
            this.lblBrojRacunaText = new System.Windows.Forms.Label();
            this.lblBrojRacuna = new System.Windows.Forms.Label();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.cbProdavac = new System.Windows.Forms.ComboBox();
            this.lblIznos = new System.Windows.Forms.Label();
            this.dateTimeRacun = new System.Windows.Forms.DateTimePicker();
            this.lblStavke = new System.Windows.Forms.Label();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.naziv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbLoyaltyKartica = new System.Windows.Forms.CheckBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnStorniraj = new System.Windows.Forms.Button();
            this.lblPdv = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrojRacunaText
            // 
            this.lblBrojRacunaText.AutoSize = true;
            this.lblBrojRacunaText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojRacunaText.Location = new System.Drawing.Point(12, 14);
            this.lblBrojRacunaText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrojRacunaText.Name = "lblBrojRacunaText";
            this.lblBrojRacunaText.Size = new System.Drawing.Size(107, 19);
            this.lblBrojRacunaText.TabIndex = 0;
            this.lblBrojRacunaText.Text = "Broj računa:";
            // 
            // lblBrojRacuna
            // 
            this.lblBrojRacuna.AutoSize = true;
            this.lblBrojRacuna.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojRacuna.Location = new System.Drawing.Point(104, 14);
            this.lblBrojRacuna.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrojRacuna.Name = "lblBrojRacuna";
            this.lblBrojRacuna.Size = new System.Drawing.Size(19, 19);
            this.lblBrojRacuna.TabIndex = 1;
            this.lblBrojRacuna.Text = "0";
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(14, 57);
            this.lblZaposlenik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(85, 19);
            this.lblZaposlenik.TabIndex = 2;
            this.lblZaposlenik.Text = "Zaposlenik:";
            // 
            // cbProdavac
            // 
            this.cbProdavac.FormattingEnabled = true;
            this.cbProdavac.Location = new System.Drawing.Point(82, 54);
            this.cbProdavac.Margin = new System.Windows.Forms.Padding(2);
            this.cbProdavac.Name = "cbProdavac";
            this.cbProdavac.Size = new System.Drawing.Size(139, 27);
            this.cbProdavac.TabIndex = 3;
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(444, 350);
            this.lblIznos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(45, 19);
            this.lblIznos.TabIndex = 2;
            this.lblIznos.Text = "Iznos:";
            // 
            // dateTimeRacun
            // 
            this.dateTimeRacun.Location = new System.Drawing.Point(82, 97);
            this.dateTimeRacun.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeRacun.Name = "dateTimeRacun";
            this.dateTimeRacun.Size = new System.Drawing.Size(175, 24);
            this.dateTimeRacun.TabIndex = 4;
            // 
            // lblStavke
            // 
            this.lblStavke.AutoSize = true;
            this.lblStavke.Location = new System.Drawing.Point(14, 149);
            this.lblStavke.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStavke.Name = "lblStavke";
            this.lblStavke.Size = new System.Drawing.Size(59, 19);
            this.lblStavke.TabIndex = 2;
            this.lblStavke.Text = "Stavke:";
            // 
            // dgvStavke
            // 
            this.dgvStavke.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv,
            this.kolicina,
            this.cijena,
            this.ukupno});
            this.dgvStavke.Location = new System.Drawing.Point(16, 182);
            this.dgvStavke.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.RowTemplate.Height = 24;
            this.dgvStavke.Size = new System.Drawing.Size(612, 146);
            this.dgvStavke.TabIndex = 5;
            this.dgvStavke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStavke_CellContentClick);
            // 
            // naziv
            // 
            this.naziv.HeaderText = "Naziv";
            this.naziv.MinimumWidth = 6;
            this.naziv.Name = "naziv";
            this.naziv.Width = 300;
            // 
            // kolicina
            // 
            this.kolicina.FillWeight = 50F;
            this.kolicina.HeaderText = "Količina";
            this.kolicina.MinimumWidth = 6;
            this.kolicina.Name = "kolicina";
            this.kolicina.Width = 60;
            // 
            // cijena
            // 
            this.cijena.HeaderText = "Cijena";
            this.cijena.MinimumWidth = 6;
            this.cijena.Name = "cijena";
            this.cijena.Width = 125;
            // 
            // ukupno
            // 
            this.ukupno.HeaderText = "Ukupno";
            this.ukupno.MinimumWidth = 6;
            this.ukupno.Name = "ukupno";
            this.ukupno.Width = 125;
            // 
            // cbLoyaltyKartica
            // 
            this.cbLoyaltyKartica.AutoSize = true;
            this.cbLoyaltyKartica.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLoyaltyKartica.Location = new System.Drawing.Point(16, 350);
            this.cbLoyaltyKartica.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoyaltyKartica.Name = "cbLoyaltyKartica";
            this.cbLoyaltyKartica.Size = new System.Drawing.Size(133, 23);
            this.cbLoyaltyKartica.TabIndex = 7;
            this.cbLoyaltyKartica.Text = "Loyalty Kartica";
            this.cbLoyaltyKartica.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnOdustani.Location = new System.Drawing.Point(564, 422);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(86, 39);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPotvrdi.Location = new System.Drawing.Point(385, 422);
            this.btnPotvrdi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(76, 39);
            this.btnPotvrdi.TabIndex = 9;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnStorniraj.Location = new System.Drawing.Point(476, 422);
            this.btnStorniraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(74, 39);
            this.btnStorniraj.TabIndex = 10;
            this.btnStorniraj.Text = "Storniraj";
            this.btnStorniraj.UseVisualStyleBackColor = false;
            // 
            // lblPdv
            // 
            this.lblPdv.AutoSize = true;
            this.lblPdv.Location = new System.Drawing.Point(444, 382);
            this.lblPdv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPdv.Name = "lblPdv";
            this.lblPdv.Size = new System.Drawing.Size(40, 19);
            this.lblPdv.TabIndex = 2;
            this.lblPdv.Text = "PDV:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(14, 101);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(60, 19);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum:";
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // IzdavanjeRacunaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(661, 472);
            this.Controls.Add(this.btnStorniraj);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cbLoyaltyKartica);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.dateTimeRacun);
            this.Controls.Add(this.cbProdavac);
            this.Controls.Add(this.lblStavke);
            this.Controls.Add(this.lblPdv);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.lblBrojRacuna);
            this.Controls.Add(this.lblBrojRacunaText);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Izdavanje");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IzdavanjeRacunaFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "Izdavanje računa";
            this.Load += new System.EventHandler(this.IzdavanjeRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrojRacunaText;
        private System.Windows.Forms.Label lblBrojRacuna;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.ComboBox cbProdavac;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.DateTimePicker dateTimeRacun;
        private System.Windows.Forms.Label lblStavke;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.CheckBox cbLoyaltyKartica;
        private System.Windows.Forms.DataGridViewComboBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupno;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnStorniraj;
        private System.Windows.Forms.Label lblPdv;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}