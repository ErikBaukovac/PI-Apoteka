namespace PI20_014_Apoteka.Forms
{
    partial class AzuriranjeBrisanjeLoyaltyKarticeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AzuriranjeBrisanjeLoyaltyKarticeFrm));
            this.labelVlasnik = new System.Windows.Forms.Label();
            this.labelOpcija = new System.Windows.Forms.Label();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonAzuriraj = new System.Windows.Forms.Button();
            this.OdustaniButton = new System.Windows.Forms.Button();
            this.VlasnikComboBox = new System.Windows.Forms.ComboBox();
            this.OpcijaComboBox = new System.Windows.Forms.ComboBox();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ImePrezimeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVlasnik
            // 
            this.labelVlasnik.AutoSize = true;
            this.labelVlasnik.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVlasnik.Location = new System.Drawing.Point(204, 38);
            this.labelVlasnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVlasnik.Name = "labelVlasnik";
            this.labelVlasnik.Size = new System.Drawing.Size(63, 20);
            this.labelVlasnik.TabIndex = 0;
            this.labelVlasnik.Text = "Vlasnik:";
            // 
            // labelOpcija
            // 
            this.labelOpcija.AutoSize = true;
            this.labelOpcija.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpcija.Location = new System.Drawing.Point(223, 167);
            this.labelOpcija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOpcija.Name = "labelOpcija";
            this.labelOpcija.Size = new System.Drawing.Size(62, 20);
            this.labelOpcija.TabIndex = 1;
            this.labelOpcija.Text = "Opcija:";
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonObrisi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.Location = new System.Drawing.Point(194, 241);
            this.buttonObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(73, 37);
            this.buttonObrisi.TabIndex = 4;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = false;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonAzuriraj
            // 
            this.buttonAzuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAzuriraj.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAzuriraj.Location = new System.Drawing.Point(109, 241);
            this.buttonAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAzuriraj.Name = "buttonAzuriraj";
            this.buttonAzuriraj.Size = new System.Drawing.Size(77, 37);
            this.buttonAzuriraj.TabIndex = 5;
            this.buttonAzuriraj.Text = "Ažuriraj";
            this.buttonAzuriraj.UseVisualStyleBackColor = false;
            this.buttonAzuriraj.Click += new System.EventHandler(this.buttonAzuriraj_Click);
            // 
            // OdustaniButton
            // 
            this.OdustaniButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.OdustaniButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdustaniButton.Location = new System.Drawing.Point(276, 241);
            this.OdustaniButton.Margin = new System.Windows.Forms.Padding(4);
            this.OdustaniButton.Name = "OdustaniButton";
            this.OdustaniButton.Size = new System.Drawing.Size(86, 37);
            this.OdustaniButton.TabIndex = 6;
            this.OdustaniButton.Text = "Odustani";
            this.OdustaniButton.UseVisualStyleBackColor = false;
            this.OdustaniButton.Click += new System.EventHandler(this.OdustaniButton_Click);
            // 
            // VlasnikComboBox
            // 
            this.VlasnikComboBox.FormattingEnabled = true;
            this.VlasnikComboBox.Location = new System.Drawing.Point(109, 62);
            this.VlasnikComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.VlasnikComboBox.Name = "VlasnikComboBox";
            this.VlasnikComboBox.Size = new System.Drawing.Size(253, 24);
            this.VlasnikComboBox.TabIndex = 7;
            this.VlasnikComboBox.SelectedIndexChanged += new System.EventHandler(this.VlasnikComboBox_SelectedIndexChanged);
            // 
            // OpcijaComboBox
            // 
            this.OpcijaComboBox.FormattingEnabled = true;
            this.OpcijaComboBox.Location = new System.Drawing.Point(109, 191);
            this.OpcijaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.OpcijaComboBox.Name = "OpcijaComboBox";
            this.OpcijaComboBox.Size = new System.Drawing.Size(253, 24);
            this.OpcijaComboBox.TabIndex = 8;
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(189, 165);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // ImePrezimeComboBox
            // 
            this.ImePrezimeComboBox.FormattingEnabled = true;
            this.ImePrezimeComboBox.Location = new System.Drawing.Point(109, 122);
            this.ImePrezimeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImePrezimeComboBox.Name = "ImePrezimeComboBox";
            this.ImePrezimeComboBox.Size = new System.Drawing.Size(253, 24);
            this.ImePrezimeComboBox.TabIndex = 12;
            this.ImePrezimeComboBox.SelectedIndexChanged += new System.EventHandler(this.ImePrezimeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ime i Prezime:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 130);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // AzuriranjeBrisanjeLoyaltyKarticeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(470, 302);
            this.Controls.Add(this.ImePrezimeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.OpcijaComboBox);
            this.Controls.Add(this.VlasnikComboBox);
            this.Controls.Add(this.OdustaniButton);
            this.Controls.Add(this.buttonAzuriraj);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.labelOpcija);
            this.Controls.Add(this.labelVlasnik);
            this.Controls.Add(this.pictureBox1);
            this.helpProvider.SetHelpKeyword(this, "Azuriranje");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AzuriranjeBrisanjeLoyaltyKarticeFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "AzuriranjeBrisanjeLoyaltyKartice";
            this.Load += new System.EventHandler(this.AzuriranjeBrisanjeLoyaltyKarticeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVlasnik;
        private System.Windows.Forms.Label labelOpcija;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonAzuriraj;
        private System.Windows.Forms.Button OdustaniButton;
        private System.Windows.Forms.ComboBox VlasnikComboBox;
        private System.Windows.Forms.ComboBox OpcijaComboBox;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox ImePrezimeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}