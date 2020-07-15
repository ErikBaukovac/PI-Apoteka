namespace PI20_014_Apoteka.Forms
{
    partial class MainZaposlenikFrm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.noviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lijekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loyaltyKarticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudžbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobavljačaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stanjeZalihaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loyaltyKarticaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ažuriranjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loyaltyKarticaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loyaltyKarticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.cbLoyaltyKartica = new System.Windows.Forms.CheckBox();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.naziv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeRacun = new System.Windows.Forms.DateTimePicker();
            this.lblStavke = new System.Windows.Forms.Label();
            this.lblPdv = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.lblBrojRacuna = new System.Windows.Forms.Label();
            this.lblBrojRacunaText = new System.Windows.Forms.Label();
            this.zaposlenikLbl = new System.Windows.Forms.Label();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviToolStripMenuItem,
            this.pregledToolStripMenuItem,
            this.ažuriranjeToolStripMenuItem,
            this.brisanjeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(632, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // noviToolStripMenuItem
            // 
            this.noviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijekToolStripMenuItem,
            this.korisnikToolStripMenuItem,
            this.loyaltyKarticaToolStripMenuItem,
            this.narudžbaToolStripMenuItem});
            this.noviToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noviToolStripMenuItem.Name = "noviToolStripMenuItem";
            this.noviToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.noviToolStripMenuItem.Text = "Novo";
            // 
            // lijekToolStripMenuItem
            // 
            this.lijekToolStripMenuItem.Name = "lijekToolStripMenuItem";
            this.lijekToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.lijekToolStripMenuItem.Text = "Lijek";
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            this.korisnikToolStripMenuItem.Click += new System.EventHandler(this.korisnikToolStripMenuItem_Click);
            // 
            // loyaltyKarticaToolStripMenuItem
            // 
            this.loyaltyKarticaToolStripMenuItem.Name = "loyaltyKarticaToolStripMenuItem";
            this.loyaltyKarticaToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.loyaltyKarticaToolStripMenuItem.Text = "Loyalty kartica";
            this.loyaltyKarticaToolStripMenuItem.Click += new System.EventHandler(this.loyaltyKarticaToolStripMenuItem_Click);
            // 
            // narudžbaToolStripMenuItem
            // 
            this.narudžbaToolStripMenuItem.Name = "narudžbaToolStripMenuItem";
            this.narudžbaToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.narudžbaToolStripMenuItem.Text = "Narudžba";
            this.narudžbaToolStripMenuItem.Click += new System.EventHandler(this.narudžbaToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.računaToolStripMenuItem,
            this.dobavljačaToolStripMenuItem,
            this.stanjeZalihaToolStripMenuItem,
            this.korisnikaToolStripMenuItem,
            this.loyaltyKarticaToolStripMenuItem2});
            this.pregledToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.pregledToolStripMenuItem.Text = "Pregled";
            // 
            // računaToolStripMenuItem
            // 
            this.računaToolStripMenuItem.Name = "računaToolStripMenuItem";
            this.računaToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.računaToolStripMenuItem.Text = "Računa";
            // 
            // dobavljačaToolStripMenuItem
            // 
            this.dobavljačaToolStripMenuItem.Name = "dobavljačaToolStripMenuItem";
            this.dobavljačaToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.dobavljačaToolStripMenuItem.Text = "Dobavljača";
            this.dobavljačaToolStripMenuItem.Click += new System.EventHandler(this.dobavljačaToolStripMenuItem_Click);
            // 
            // stanjeZalihaToolStripMenuItem
            // 
            this.stanjeZalihaToolStripMenuItem.Name = "stanjeZalihaToolStripMenuItem";
            this.stanjeZalihaToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.stanjeZalihaToolStripMenuItem.Text = "Stanje zaliha";
            this.stanjeZalihaToolStripMenuItem.Click += new System.EventHandler(this.stanjeZalihaToolStripMenuItem_Click);
            // 
            // korisnikaToolStripMenuItem
            // 
            this.korisnikaToolStripMenuItem.Name = "korisnikaToolStripMenuItem";
            this.korisnikaToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.korisnikaToolStripMenuItem.Text = "Korisnika";
            this.korisnikaToolStripMenuItem.Click += new System.EventHandler(this.korisnikaToolStripMenuItem_Click);
            // 
            // loyaltyKarticaToolStripMenuItem2
            // 
            this.loyaltyKarticaToolStripMenuItem2.Name = "loyaltyKarticaToolStripMenuItem2";
            this.loyaltyKarticaToolStripMenuItem2.Size = new System.Drawing.Size(194, 26);
            this.loyaltyKarticaToolStripMenuItem2.Text = "Loyalty Kartica";
            this.loyaltyKarticaToolStripMenuItem2.Click += new System.EventHandler(this.loyaltyKarticaToolStripMenuItem2_Click);
            // 
            // ažuriranjeToolStripMenuItem
            // 
            this.ažuriranjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loyaltyKarticaToolStripMenuItem1});
            this.ažuriranjeToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ažuriranjeToolStripMenuItem.Name = "ažuriranjeToolStripMenuItem";
            this.ažuriranjeToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.ažuriranjeToolStripMenuItem.Text = "Ažuriranje";
            // 
            // loyaltyKarticaToolStripMenuItem1
            // 
            this.loyaltyKarticaToolStripMenuItem1.Name = "loyaltyKarticaToolStripMenuItem1";
            this.loyaltyKarticaToolStripMenuItem1.Size = new System.Drawing.Size(194, 26);
            this.loyaltyKarticaToolStripMenuItem1.Text = "Loyalty Kartica";
            this.loyaltyKarticaToolStripMenuItem1.Click += new System.EventHandler(this.loyaltyKarticaToolStripMenuItem1_Click);
            // 
            // brisanjeToolStripMenuItem
            // 
            this.brisanjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loyaltyKarticeToolStripMenuItem});
            this.brisanjeToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brisanjeToolStripMenuItem.Name = "brisanjeToolStripMenuItem";
            this.brisanjeToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.brisanjeToolStripMenuItem.Text = "Brisanje";
            // 
            // loyaltyKarticeToolStripMenuItem
            // 
            this.loyaltyKarticeToolStripMenuItem.Name = "loyaltyKarticeToolStripMenuItem";
            this.loyaltyKarticeToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.loyaltyKarticeToolStripMenuItem.Text = "Loyalty Kartice";
            this.loyaltyKarticeToolStripMenuItem.Click += new System.EventHandler(this.loyaltyKarticeToolStripMenuItem_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(446, 396);
            this.btnPotvrdi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(80, 34);
            this.btnPotvrdi.TabIndex = 23;
            this.btnPotvrdi.Text = "Izdaj";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(530, 396);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(88, 34);
            this.btnOdustani.TabIndex = 22;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // cbLoyaltyKartica
            // 
            this.cbLoyaltyKartica.AutoSize = true;
            this.cbLoyaltyKartica.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbLoyaltyKartica.Location = new System.Drawing.Point(16, 327);
            this.cbLoyaltyKartica.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoyaltyKartica.Name = "cbLoyaltyKartica";
            this.cbLoyaltyKartica.Size = new System.Drawing.Size(133, 23);
            this.cbLoyaltyKartica.TabIndex = 21;
            this.cbLoyaltyKartica.Text = "Loyalty Kartica";
            this.cbLoyaltyKartica.UseVisualStyleBackColor = true;
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
            this.dgvStavke.Location = new System.Drawing.Point(16, 161);
            this.dgvStavke.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.RowTemplate.Height = 24;
            this.dgvStavke.Size = new System.Drawing.Size(602, 146);
            this.dgvStavke.TabIndex = 20;
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
            // dateTimeRacun
            // 
            this.dateTimeRacun.Location = new System.Drawing.Point(89, 97);
            this.dateTimeRacun.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeRacun.Name = "dateTimeRacun";
            this.dateTimeRacun.Size = new System.Drawing.Size(175, 24);
            this.dateTimeRacun.TabIndex = 19;
            // 
            // lblStavke
            // 
            this.lblStavke.AutoSize = true;
            this.lblStavke.Location = new System.Drawing.Point(13, 130);
            this.lblStavke.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStavke.Name = "lblStavke";
            this.lblStavke.Size = new System.Drawing.Size(59, 19);
            this.lblStavke.TabIndex = 13;
            this.lblStavke.Text = "Stavke:";
            // 
            // lblPdv
            // 
            this.lblPdv.AutoSize = true;
            this.lblPdv.Location = new System.Drawing.Point(443, 361);
            this.lblPdv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPdv.Name = "lblPdv";
            this.lblPdv.Size = new System.Drawing.Size(40, 19);
            this.lblPdv.TabIndex = 14;
            this.lblPdv.Text = "PDV:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(13, 97);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(60, 19);
            this.lblDatum.TabIndex = 15;
            this.lblDatum.Text = "Datum:";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(443, 327);
            this.lblIznos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(45, 19);
            this.lblIznos.TabIndex = 16;
            this.lblIznos.Text = "Iznos:";
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(13, 65);
            this.lblZaposlenik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(81, 19);
            this.lblZaposlenik.TabIndex = 17;
            this.lblZaposlenik.Text = "Zaposlenik";
            // 
            // lblBrojRacuna
            // 
            this.lblBrojRacuna.AutoSize = true;
            this.lblBrojRacuna.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojRacuna.Location = new System.Drawing.Point(123, 29);
            this.lblBrojRacuna.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrojRacuna.Name = "lblBrojRacuna";
            this.lblBrojRacuna.Size = new System.Drawing.Size(19, 19);
            this.lblBrojRacuna.TabIndex = 12;
            this.lblBrojRacuna.Text = "0";
            // 
            // lblBrojRacunaText
            // 
            this.lblBrojRacunaText.AutoSize = true;
            this.lblBrojRacunaText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojRacunaText.Location = new System.Drawing.Point(13, 29);
            this.lblBrojRacunaText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrojRacunaText.Name = "lblBrojRacunaText";
            this.lblBrojRacunaText.Size = new System.Drawing.Size(107, 19);
            this.lblBrojRacunaText.TabIndex = 11;
            this.lblBrojRacunaText.Text = "Broj računa:";
            // 
            // zaposlenikLbl
            // 
            this.zaposlenikLbl.AutoSize = true;
            this.zaposlenikLbl.Location = new System.Drawing.Point(86, 75);
            this.zaposlenikLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zaposlenikLbl.Name = "zaposlenikLbl";
            this.zaposlenikLbl.Size = new System.Drawing.Size(0, 19);
            this.zaposlenikLbl.TabIndex = 24;
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // MainZaposlenikFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(632, 444);
            this.Controls.Add(this.zaposlenikLbl);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cbLoyaltyKartica);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.dateTimeRacun);
            this.Controls.Add(this.lblStavke);
            this.Controls.Add(this.lblPdv);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.lblBrojRacuna);
            this.Controls.Add(this.lblBrojRacunaText);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Zaposlenik");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainZaposlenikFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "MainZaposlenikFrm";
            this.Load += new System.EventHandler(this.MainZaposlenikFrm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem noviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lijekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loyaltyKarticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narudžbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobavljačaToolStripMenuItem;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.CheckBox cbLoyaltyKartica;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.DataGridViewComboBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupno;
        private System.Windows.Forms.DateTimePicker dateTimeRacun;
        private System.Windows.Forms.Label lblStavke;
        private System.Windows.Forms.Label lblPdv;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.Label lblBrojRacuna;
        private System.Windows.Forms.Label lblBrojRacunaText;
        private System.Windows.Forms.Label zaposlenikLbl;
        private System.Windows.Forms.ToolStripMenuItem stanjeZalihaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ažuriranjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loyaltyKarticaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brisanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loyaltyKarticeToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.ToolStripMenuItem korisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loyaltyKarticaToolStripMenuItem2;
    }
}