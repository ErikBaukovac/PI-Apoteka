namespace Apoteka
{
    partial class AzuriranjePodatakaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AzuriranjePodatakaFrm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telbroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUpdateNaziv = new System.Windows.Forms.Label();
            this.lblUpdateAdresa = new System.Windows.Forms.Label();
            this.lblUpdateTelBr = new System.Windows.Forms.Label();
            this.lblUpdateRedniBrojText = new System.Windows.Forms.Label();
            this.lblUpdateRedniBroj = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnUpdateOdustani = new System.Windows.Forms.Button();
            this.btnIzbrisiApoteku = new System.Windows.Forms.Button();
            this.txtUpdateNaziv = new System.Windows.Forms.TextBox();
            this.txtUpdateAdresa = new System.Windows.Forms.TextBox();
            this.txtUpdateTelBr = new System.Windows.Forms.TextBox();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv,
            this.adresa,
            this.telbroj});
            this.dataGridView1.Location = new System.Drawing.Point(21, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(745, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // naziv
            // 
            this.naziv.HeaderText = "Naziv";
            this.naziv.MinimumWidth = 6;
            this.naziv.Name = "naziv";
            this.naziv.Width = 300;
            // 
            // adresa
            // 
            this.adresa.HeaderText = "Adresa";
            this.adresa.MinimumWidth = 6;
            this.adresa.Name = "adresa";
            this.adresa.Width = 300;
            // 
            // telbroj
            // 
            this.telbroj.HeaderText = "Telefonski broj";
            this.telbroj.MinimumWidth = 6;
            this.telbroj.Name = "telbroj";
            this.telbroj.Width = 200;
            // 
            // lblUpdateNaziv
            // 
            this.lblUpdateNaziv.AutoSize = true;
            this.lblUpdateNaziv.Location = new System.Drawing.Point(19, 290);
            this.lblUpdateNaziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateNaziv.Name = "lblUpdateNaziv";
            this.lblUpdateNaziv.Size = new System.Drawing.Size(42, 16);
            this.lblUpdateNaziv.TabIndex = 2;
            this.lblUpdateNaziv.Text = "Naziv:";
            // 
            // lblUpdateAdresa
            // 
            this.lblUpdateAdresa.AutoSize = true;
            this.lblUpdateAdresa.Location = new System.Drawing.Point(19, 345);
            this.lblUpdateAdresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateAdresa.Name = "lblUpdateAdresa";
            this.lblUpdateAdresa.Size = new System.Drawing.Size(48, 16);
            this.lblUpdateAdresa.TabIndex = 3;
            this.lblUpdateAdresa.Text = "Adresa:";
            // 
            // lblUpdateTelBr
            // 
            this.lblUpdateTelBr.AutoSize = true;
            this.lblUpdateTelBr.Location = new System.Drawing.Point(19, 403);
            this.lblUpdateTelBr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateTelBr.Name = "lblUpdateTelBr";
            this.lblUpdateTelBr.Size = new System.Drawing.Size(83, 16);
            this.lblUpdateTelBr.TabIndex = 4;
            this.lblUpdateTelBr.Text = "Telefonski broj:";
            // 
            // lblUpdateRedniBrojText
            // 
            this.lblUpdateRedniBrojText.AutoSize = true;
            this.lblUpdateRedniBrojText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpdateRedniBrojText.Location = new System.Drawing.Point(19, 249);
            this.lblUpdateRedniBrojText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateRedniBrojText.Name = "lblUpdateRedniBrojText";
            this.lblUpdateRedniBrojText.Size = new System.Drawing.Size(79, 16);
            this.lblUpdateRedniBrojText.TabIndex = 10;
            this.lblUpdateRedniBrojText.Text = "Redni broj:";
            // 
            // lblUpdateRedniBroj
            // 
            this.lblUpdateRedniBroj.AutoSize = true;
            this.lblUpdateRedniBroj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpdateRedniBroj.Location = new System.Drawing.Point(100, 249);
            this.lblUpdateRedniBroj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateRedniBroj.Name = "lblUpdateRedniBroj";
            this.lblUpdateRedniBroj.Size = new System.Drawing.Size(15, 16);
            this.lblUpdateRedniBroj.TabIndex = 11;
            this.lblUpdateRedniBroj.Text = "0";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAzuriraj.Location = new System.Drawing.Point(571, 406);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(84, 36);
            this.btnAzuriraj.TabIndex = 12;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnUpdateOdustani
            // 
            this.btnUpdateOdustani.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdateOdustani.Location = new System.Drawing.Point(682, 406);
            this.btnUpdateOdustani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateOdustani.Name = "btnUpdateOdustani";
            this.btnUpdateOdustani.Size = new System.Drawing.Size(84, 36);
            this.btnUpdateOdustani.TabIndex = 13;
            this.btnUpdateOdustani.Text = "Odustani";
            this.btnUpdateOdustani.UseVisualStyleBackColor = false;
            this.btnUpdateOdustani.Click += new System.EventHandler(this.btnUpdateOdustani_Click);
            // 
            // btnIzbrisiApoteku
            // 
            this.btnIzbrisiApoteku.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnIzbrisiApoteku.Location = new System.Drawing.Point(682, 240);
            this.btnIzbrisiApoteku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzbrisiApoteku.Name = "btnIzbrisiApoteku";
            this.btnIzbrisiApoteku.Size = new System.Drawing.Size(84, 36);
            this.btnIzbrisiApoteku.TabIndex = 14;
            this.btnIzbrisiApoteku.Text = "Izbriši";
            this.btnIzbrisiApoteku.UseVisualStyleBackColor = false;
            this.btnIzbrisiApoteku.Click += new System.EventHandler(this.btnIzbrisiApoteku_Click);
            // 
            // txtUpdateNaziv
            // 
            this.txtUpdateNaziv.Location = new System.Drawing.Point(22, 308);
            this.txtUpdateNaziv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUpdateNaziv.Name = "txtUpdateNaziv";
            this.txtUpdateNaziv.Size = new System.Drawing.Size(226, 21);
            this.txtUpdateNaziv.TabIndex = 15;
            this.txtUpdateNaziv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtUpdateAdresa
            // 
            this.txtUpdateAdresa.Location = new System.Drawing.Point(21, 363);
            this.txtUpdateAdresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUpdateAdresa.Name = "txtUpdateAdresa";
            this.txtUpdateAdresa.Size = new System.Drawing.Size(226, 21);
            this.txtUpdateAdresa.TabIndex = 16;
            this.txtUpdateAdresa.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtUpdateTelBr
            // 
            this.txtUpdateTelBr.Location = new System.Drawing.Point(21, 421);
            this.txtUpdateTelBr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUpdateTelBr.Name = "txtUpdateTelBr";
            this.txtUpdateTelBr.Size = new System.Drawing.Size(226, 21);
            this.txtUpdateTelBr.TabIndex = 17;
            this.txtUpdateTelBr.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(296, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 202);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // AzuriranjePodatakaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(786, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUpdateTelBr);
            this.Controls.Add(this.txtUpdateAdresa);
            this.Controls.Add(this.txtUpdateNaziv);
            this.Controls.Add(this.btnIzbrisiApoteku);
            this.Controls.Add(this.btnUpdateOdustani);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.lblUpdateRedniBroj);
            this.Controls.Add(this.lblUpdateRedniBrojText);
            this.Controls.Add(this.lblUpdateTelBr);
            this.Controls.Add(this.lblUpdateAdresa);
            this.Controls.Add(this.lblUpdateNaziv);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Azuriranje");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AzuriranjePodatakaFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "Ažuriranje podataka";
            this.Load += new System.EventHandler(this.AzuriranjePodatakaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUpdateNaziv;
        private System.Windows.Forms.Label lblUpdateAdresa;
        private System.Windows.Forms.Label lblUpdateTelBr;
        private System.Windows.Forms.Label lblUpdateRedniBrojText;
        private System.Windows.Forms.Label lblUpdateRedniBroj;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnUpdateOdustani;
        private System.Windows.Forms.Button btnIzbrisiApoteku;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn telbroj;
        private System.Windows.Forms.TextBox txtUpdateNaziv;
        private System.Windows.Forms.TextBox txtUpdateAdresa;
        private System.Windows.Forms.TextBox txtUpdateTelBr;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}