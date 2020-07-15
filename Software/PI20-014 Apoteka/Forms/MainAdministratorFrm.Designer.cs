namespace PI20_014_Apoteka.Forms
{
    partial class MainAdministratorFrm
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
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposlenikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobavljacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lijekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loyaltyOpcijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ažuriranjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobavljačToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lijekToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loyaltyOpcijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposlenikaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dobavljacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lijekovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loyaltyOpcijaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loyaltyOpcijaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.apotekeDgv = new System.Windows.Forms.DataGridView();
            this.tvrtkaLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.odjavaLbl = new System.Windows.Forms.Label();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.postavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apotekeDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.ažuriranjeToolStripMenuItem1,
            this.brisanjeToolStripMenuItem3,
            this.pregledToolStripMenuItem,
            this.postavkeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(490, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposlenikToolStripMenuItem,
            this.dobavljacToolStripMenuItem,
            this.lijekToolStripMenuItem,
            this.loyaltyOpcijaToolStripMenuItem,
            this.apotekaToolStripMenuItem});
            this.novoToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // zaposlenikToolStripMenuItem
            // 
            this.zaposlenikToolStripMenuItem.Name = "zaposlenikToolStripMenuItem";
            this.zaposlenikToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.zaposlenikToolStripMenuItem.Text = "Zaposlenik";
            this.zaposlenikToolStripMenuItem.Click += new System.EventHandler(this.zaposlenikToolStripMenuItem_Click);
            // 
            // dobavljacToolStripMenuItem
            // 
            this.dobavljacToolStripMenuItem.Name = "dobavljacToolStripMenuItem";
            this.dobavljacToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.dobavljacToolStripMenuItem.Text = "Dobavljac";
            this.dobavljacToolStripMenuItem.Click += new System.EventHandler(this.dobavljacToolStripMenuItem_Click);
            // 
            // lijekToolStripMenuItem
            // 
            this.lijekToolStripMenuItem.Name = "lijekToolStripMenuItem";
            this.lijekToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.lijekToolStripMenuItem.Text = "Lijek";
            this.lijekToolStripMenuItem.Click += new System.EventHandler(this.lijekToolStripMenuItem_Click);
            // 
            // loyaltyOpcijaToolStripMenuItem
            // 
            this.loyaltyOpcijaToolStripMenuItem.Name = "loyaltyOpcijaToolStripMenuItem";
            this.loyaltyOpcijaToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.loyaltyOpcijaToolStripMenuItem.Text = "Loyalty opcija";
            this.loyaltyOpcijaToolStripMenuItem.Click += new System.EventHandler(this.loyaltyOpcijaToolStripMenuItem_Click);
            // 
            // apotekaToolStripMenuItem
            // 
            this.apotekaToolStripMenuItem.Name = "apotekaToolStripMenuItem";
            this.apotekaToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.apotekaToolStripMenuItem.Text = "Apoteka";
            // 
            // ažuriranjeToolStripMenuItem1
            // 
            this.ažuriranjeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposlenikaToolStripMenuItem,
            this.dobavljačToolStripMenuItem,
            this.lijekToolStripMenuItem1,
            this.loyaltyOpcijToolStripMenuItem});
            this.ažuriranjeToolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ažuriranjeToolStripMenuItem1.Name = "ažuriranjeToolStripMenuItem1";
            this.ažuriranjeToolStripMenuItem1.Size = new System.Drawing.Size(89, 24);
            this.ažuriranjeToolStripMenuItem1.Text = "Ažuriranje";
            // 
            // zaposlenikaToolStripMenuItem
            // 
            this.zaposlenikaToolStripMenuItem.Name = "zaposlenikaToolStripMenuItem";
            this.zaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.zaposlenikaToolStripMenuItem.Text = "Zaposlenika";
            this.zaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.zaposlenikaToolStripMenuItem_Click);
            // 
            // dobavljačToolStripMenuItem
            // 
            this.dobavljačToolStripMenuItem.Name = "dobavljačToolStripMenuItem";
            this.dobavljačToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.dobavljačToolStripMenuItem.Text = "Dobavljača";
            this.dobavljačToolStripMenuItem.Click += new System.EventHandler(this.dobavljačToolStripMenuItem_Click);
            // 
            // lijekToolStripMenuItem1
            // 
            this.lijekToolStripMenuItem1.Name = "lijekToolStripMenuItem1";
            this.lijekToolStripMenuItem1.Size = new System.Drawing.Size(192, 26);
            this.lijekToolStripMenuItem1.Text = "Lijekova";
            this.lijekToolStripMenuItem1.Click += new System.EventHandler(this.lijekToolStripMenuItem1_Click);
            // 
            // loyaltyOpcijToolStripMenuItem
            // 
            this.loyaltyOpcijToolStripMenuItem.Name = "loyaltyOpcijToolStripMenuItem";
            this.loyaltyOpcijToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.loyaltyOpcijToolStripMenuItem.Text = "Loyalty Opcija";
            this.loyaltyOpcijToolStripMenuItem.Click += new System.EventHandler(this.loyaltyOpcijToolStripMenuItem_Click);
            // 
            // brisanjeToolStripMenuItem3
            // 
            this.brisanjeToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposlenikaToolStripMenuItem1,
            this.dobavljacaToolStripMenuItem,
            this.lijekovaToolStripMenuItem,
            this.loyaltyOpcijaToolStripMenuItem1});
            this.brisanjeToolStripMenuItem3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brisanjeToolStripMenuItem3.Name = "brisanjeToolStripMenuItem3";
            this.brisanjeToolStripMenuItem3.Size = new System.Drawing.Size(74, 24);
            this.brisanjeToolStripMenuItem3.Text = "Brisanje";
            // 
            // zaposlenikaToolStripMenuItem1
            // 
            this.zaposlenikaToolStripMenuItem1.Name = "zaposlenikaToolStripMenuItem1";
            this.zaposlenikaToolStripMenuItem1.Size = new System.Drawing.Size(189, 26);
            this.zaposlenikaToolStripMenuItem1.Text = "Zaposlenika";
            this.zaposlenikaToolStripMenuItem1.Click += new System.EventHandler(this.zaposlenikaToolStripMenuItem1_Click);
            // 
            // dobavljacaToolStripMenuItem
            // 
            this.dobavljacaToolStripMenuItem.Name = "dobavljacaToolStripMenuItem";
            this.dobavljacaToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.dobavljacaToolStripMenuItem.Text = "Dobavljaca";
            this.dobavljacaToolStripMenuItem.Click += new System.EventHandler(this.dobavljacaToolStripMenuItem_Click);
            // 
            // lijekovaToolStripMenuItem
            // 
            this.lijekovaToolStripMenuItem.Name = "lijekovaToolStripMenuItem";
            this.lijekovaToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.lijekovaToolStripMenuItem.Text = "Lijekova";
            this.lijekovaToolStripMenuItem.Click += new System.EventHandler(this.lijekovaToolStripMenuItem_Click);
            // 
            // loyaltyOpcijaToolStripMenuItem1
            // 
            this.loyaltyOpcijaToolStripMenuItem1.Name = "loyaltyOpcijaToolStripMenuItem1";
            this.loyaltyOpcijaToolStripMenuItem1.Size = new System.Drawing.Size(189, 26);
            this.loyaltyOpcijaToolStripMenuItem1.Text = "Loyalty opcija";
            this.loyaltyOpcijaToolStripMenuItem1.Click += new System.EventHandler(this.loyaltyOpcijaToolStripMenuItem1_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loyaltyOpcijaToolStripMenuItem2});
            this.pregledToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.pregledToolStripMenuItem.Text = "Pregled";
            // 
            // loyaltyOpcijaToolStripMenuItem2
            // 
            this.loyaltyOpcijaToolStripMenuItem2.Name = "loyaltyOpcijaToolStripMenuItem2";
            this.loyaltyOpcijaToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.loyaltyOpcijaToolStripMenuItem2.Text = "LoyaltyOpcija";
            this.loyaltyOpcijaToolStripMenuItem2.Click += new System.EventHandler(this.loyaltyOpcijaToolStripMenuItem2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dobrodošao/la";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(353, 57);
            this.userNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(0, 19);
            this.userNameLbl.TabIndex = 2;
            // 
            // apotekeDgv
            // 
            this.apotekeDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.apotekeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apotekeDgv.Location = new System.Drawing.Point(20, 130);
            this.apotekeDgv.Margin = new System.Windows.Forms.Padding(2);
            this.apotekeDgv.Name = "apotekeDgv";
            this.apotekeDgv.RowHeadersWidth = 51;
            this.apotekeDgv.RowTemplate.Height = 24;
            this.apotekeDgv.Size = new System.Drawing.Size(446, 302);
            this.apotekeDgv.TabIndex = 3;
            // 
            // tvrtkaLbl
            // 
            this.tvrtkaLbl.AutoSize = true;
            this.tvrtkaLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvrtkaLbl.Location = new System.Drawing.Point(16, 53);
            this.tvrtkaLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tvrtkaLbl.Name = "tvrtkaLbl";
            this.tvrtkaLbl.Size = new System.Drawing.Size(61, 19);
            this.tvrtkaLbl.TabIndex = 4;
            this.tvrtkaLbl.Text = "Tvrtka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apoteke u vlasništvu:";
            // 
            // odjavaLbl
            // 
            this.odjavaLbl.AutoSize = true;
            this.odjavaLbl.Location = new System.Drawing.Point(414, 57);
            this.odjavaLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.odjavaLbl.Name = "odjavaLbl";
            this.odjavaLbl.Size = new System.Drawing.Size(62, 19);
            this.odjavaLbl.TabIndex = 6;
            this.odjavaLbl.Text = "Odjava";
            this.odjavaLbl.Click += new System.EventHandler(this.odjavaLbl_Click);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // postavkeToolStripMenuItem
            // 
            this.postavkeToolStripMenuItem.Name = "postavkeToolStripMenuItem";
            this.postavkeToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.postavkeToolStripMenuItem.Text = "Postavke";
            this.postavkeToolStripMenuItem.Click += new System.EventHandler(this.postavkeToolStripMenuItem_Click);
            // 
            // MainAdministratorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.odjavaLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvrtkaLbl);
            this.Controls.Add(this.apotekeDgv);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Administrator");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainAdministratorFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "MainAdministratorFrm";
            this.Load += new System.EventHandler(this.MainAdministratorFrm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apotekeDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.DataGridView apotekeDgv;
        private System.Windows.Forms.Label tvrtkaLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label odjavaLbl;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposlenikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobavljacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lijekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loyaltyOpcijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ažuriranjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobavljačToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lijekToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loyaltyOpcijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem zaposlenikaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dobavljacaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lijekovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loyaltyOpcijaToolStripMenuItem1;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loyaltyOpcijaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem postavkeToolStripMenuItem;
    }
}