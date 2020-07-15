namespace PI20_014
{
    partial class NarucivanjeLijekovaFrm
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
            this.stavkeNarudzbeniceDgv = new System.Windows.Forms.DataGridView();
            this.naruciBtn = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.addBtn = new System.Windows.Forms.Button();
            this.odustaniBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.kolicinaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dobavljacCmb = new System.Windows.Forms.ComboBox();
            this.odaberiBtn = new System.Windows.Forms.Button();
            this.zaposlenikLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adresaLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tvrtkaLbl = new System.Windows.Forms.Label();
            this.brojNarudzbeniceLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeniceDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lijekoviDgv
            // 
            this.lijekoviDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.lijekoviDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lijekoviDgv.Location = new System.Drawing.Point(18, 225);
            this.lijekoviDgv.Margin = new System.Windows.Forms.Padding(2);
            this.lijekoviDgv.Name = "lijekoviDgv";
            this.lijekoviDgv.RowHeadersWidth = 51;
            this.lijekoviDgv.RowTemplate.Height = 24;
            this.lijekoviDgv.Size = new System.Drawing.Size(289, 182);
            this.lijekoviDgv.TabIndex = 0;
            // 
            // stavkeNarudzbeniceDgv
            // 
            this.stavkeNarudzbeniceDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.stavkeNarudzbeniceDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavkeNarudzbeniceDgv.Location = new System.Drawing.Point(376, 225);
            this.stavkeNarudzbeniceDgv.Margin = new System.Windows.Forms.Padding(2);
            this.stavkeNarudzbeniceDgv.Name = "stavkeNarudzbeniceDgv";
            this.stavkeNarudzbeniceDgv.RowHeadersWidth = 51;
            this.stavkeNarudzbeniceDgv.RowTemplate.Height = 24;
            this.stavkeNarudzbeniceDgv.Size = new System.Drawing.Size(285, 182);
            this.stavkeNarudzbeniceDgv.TabIndex = 0;
            // 
            // naruciBtn
            // 
            this.naruciBtn.Location = new System.Drawing.Point(494, 420);
            this.naruciBtn.Margin = new System.Windows.Forms.Padding(2);
            this.naruciBtn.Name = "naruciBtn";
            this.naruciBtn.Size = new System.Drawing.Size(65, 30);
            this.naruciBtn.TabIndex = 1;
            this.naruciBtn.Text = "Naruci";
            this.naruciBtn.UseVisualStyleBackColor = true;
            this.naruciBtn.Click += new System.EventHandler(this.naruciBtn_Click);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.addBtn.Location = new System.Drawing.Point(321, 272);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(40, 30);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "->";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // odustaniBtn
            // 
            this.odustaniBtn.Location = new System.Drawing.Point(577, 420);
            this.odustaniBtn.Margin = new System.Windows.Forms.Padding(2);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(84, 30);
            this.odustaniBtn.TabIndex = 3;
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.UseVisualStyleBackColor = true;
            this.odustaniBtn.Click += new System.EventHandler(this.odustaniBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.removeBtn.Location = new System.Drawing.Point(321, 334);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(40, 30);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "<-";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // kolicinaTxt
            // 
            this.kolicinaTxt.Location = new System.Drawing.Point(320, 306);
            this.kolicinaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.kolicinaTxt.Name = "kolicinaTxt";
            this.kolicinaTxt.Size = new System.Drawing.Size(41, 24);
            this.kolicinaTxt.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Dobavljac";
            // 
            // dobavljacCmb
            // 
            this.dobavljacCmb.FormattingEnabled = true;
            this.dobavljacCmb.Location = new System.Drawing.Point(104, 183);
            this.dobavljacCmb.Name = "dobavljacCmb";
            this.dobavljacCmb.Size = new System.Drawing.Size(121, 27);
            this.dobavljacCmb.TabIndex = 20;
            // 
            // odaberiBtn
            // 
            this.odaberiBtn.Location = new System.Drawing.Point(244, 186);
            this.odaberiBtn.Name = "odaberiBtn";
            this.odaberiBtn.Size = new System.Drawing.Size(75, 23);
            this.odaberiBtn.TabIndex = 21;
            this.odaberiBtn.Text = "Odaberi";
            this.odaberiBtn.UseVisualStyleBackColor = true;
            this.odaberiBtn.Click += new System.EventHandler(this.odaberiBtn_Click);
            // 
            // zaposlenikLbl
            // 
            this.zaposlenikLbl.AutoSize = true;
            this.zaposlenikLbl.Location = new System.Drawing.Point(91, 118);
            this.zaposlenikLbl.Name = "zaposlenikLbl";
            this.zaposlenikLbl.Size = new System.Drawing.Size(0, 19);
            this.zaposlenikLbl.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Naručeno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Naručuje";
            // 
            // adresaLbl
            // 
            this.adresaLbl.AutoSize = true;
            this.adresaLbl.Location = new System.Drawing.Point(86, 62);
            this.adresaLbl.Name = "adresaLbl";
            this.adresaLbl.Size = new System.Drawing.Size(0, 19);
            this.adresaLbl.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Adresa";
            // 
            // tvrtkaLbl
            // 
            this.tvrtkaLbl.AutoSize = true;
            this.tvrtkaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvrtkaLbl.Location = new System.Drawing.Point(14, 16);
            this.tvrtkaLbl.Name = "tvrtkaLbl";
            this.tvrtkaLbl.Size = new System.Drawing.Size(0, 29);
            this.tvrtkaLbl.TabIndex = 24;
            // 
            // brojNarudzbeniceLbl
            // 
            this.brojNarudzbeniceLbl.AutoSize = true;
            this.brojNarudzbeniceLbl.Location = new System.Drawing.Point(156, 89);
            this.brojNarudzbeniceLbl.Name = "brojNarudzbeniceLbl";
            this.brojNarudzbeniceLbl.Size = new System.Drawing.Size(0, 19);
            this.brojNarudzbeniceLbl.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Broj narudžbenice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Datum:";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(493, 62);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(0, 19);
            this.dateLbl.TabIndex = 30;
            // 
            // NarucivanjeLijekovaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(686, 464);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zaposlenikLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adresaLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvrtkaLbl);
            this.Controls.Add(this.brojNarudzbeniceLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.odaberiBtn);
            this.Controls.Add(this.dobavljacCmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kolicinaTxt);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.odustaniBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.naruciBtn);
            this.Controls.Add(this.stavkeNarudzbeniceDgv);
            this.Controls.Add(this.lijekoviDgv);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Narucivanje");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NarucivanjeLijekovaFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "Narucivanje lijekova";
            this.Load += new System.EventHandler(this.NarucivanjeLijekova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeniceDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lijekoviDgv;
        private System.Windows.Forms.DataGridView stavkeNarudzbeniceDgv;
        private System.Windows.Forms.Button naruciBtn;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button odustaniBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox kolicinaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dobavljacCmb;
        private System.Windows.Forms.Button odaberiBtn;
        private System.Windows.Forms.Label zaposlenikLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label adresaLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tvrtkaLbl;
        private System.Windows.Forms.Label brojNarudzbeniceLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dateLbl;
    }
}