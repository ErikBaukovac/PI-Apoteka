namespace Apoteka
{
    partial class KreiranjeApotekeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KreiranjeApotekeFrm));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtTelBroj = new System.Windows.Forms.TextBox();
            this.lblRedniBrojText = new System.Windows.Forms.Label();
            this.lblRedniBroj = new System.Windows.Forms.Label();
            this.txtTvrtka = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(81, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kreiraj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefonski broj:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tvrtka:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(25, 97);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.txtNaziv.MaxLength = 25;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(247, 21);
            this.txtNaziv.TabIndex = 5;
            this.txtNaziv.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(25, 156);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(247, 21);
            this.txtAdresa.TabIndex = 6;
            this.txtAdresa.TextChanged += new System.EventHandler(this.txtAdresa_TextChanged);
            // 
            // txtTelBroj
            // 
            this.txtTelBroj.Location = new System.Drawing.Point(25, 218);
            this.txtTelBroj.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelBroj.MaxLength = 14;
            this.txtTelBroj.Name = "txtTelBroj";
            this.txtTelBroj.Size = new System.Drawing.Size(247, 21);
            this.txtTelBroj.TabIndex = 7;
            this.txtTelBroj.TextChanged += new System.EventHandler(this.txtTelBroj_TextChanged);
            // 
            // lblRedniBrojText
            // 
            this.lblRedniBrojText.AutoSize = true;
            this.lblRedniBrojText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRedniBrojText.Location = new System.Drawing.Point(22, 28);
            this.lblRedniBrojText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRedniBrojText.Name = "lblRedniBrojText";
            this.lblRedniBrojText.Size = new System.Drawing.Size(79, 16);
            this.lblRedniBrojText.TabIndex = 9;
            this.lblRedniBrojText.Text = "Redni broj:";
            // 
            // lblRedniBroj
            // 
            this.lblRedniBroj.AutoSize = true;
            this.lblRedniBroj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRedniBroj.Location = new System.Drawing.Point(105, 28);
            this.lblRedniBroj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRedniBroj.Name = "lblRedniBroj";
            this.lblRedniBroj.Size = new System.Drawing.Size(15, 16);
            this.lblRedniBroj.TabIndex = 10;
            this.lblRedniBroj.Text = "0";
            // 
            // txtTvrtka
            // 
            this.txtTvrtka.Location = new System.Drawing.Point(25, 280);
            this.txtTvrtka.Margin = new System.Windows.Forms.Padding(2);
            this.txtTvrtka.Name = "txtTvrtka";
            this.txtTvrtka.ReadOnly = true;
            this.txtTvrtka.Size = new System.Drawing.Size(247, 21);
            this.txtTvrtka.TabIndex = 11;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnOdustani.Location = new System.Drawing.Point(188, 330);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(84, 36);
            this.btnOdustani.TabIndex = 0;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.button1_Click);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // KreiranjeApotekeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(301, 382);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTvrtka);
            this.Controls.Add(this.lblRedniBroj);
            this.Controls.Add(this.lblRedniBrojText);
            this.Controls.Add(this.txtTelBroj);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Kreiraj");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KreiranjeApotekeFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "Kreiranje apoteke";
            this.Load += new System.EventHandler(this.KreiranjeApotekeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtTelBroj;
        private System.Windows.Forms.Label lblRedniBrojText;
        private System.Windows.Forms.Label lblRedniBroj;
        private System.Windows.Forms.TextBox txtTvrtka;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

