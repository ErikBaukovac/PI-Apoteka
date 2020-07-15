namespace PI20_014_Apoteka.Forms
{
    partial class AzuriranjeBrisanjeLoyaltyOpcijeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AzuriranjeBrisanjeLoyaltyOpcijeFrm));
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonAzuriraj = new System.Windows.Forms.Button();
            this.labelNazivOpcije = new System.Windows.Forms.Label();
            this.labelPopust = new System.Windows.Forms.Label();
            this.OdustaniButton = new System.Windows.Forms.Button();
            this.NazivComboBox = new System.Windows.Forms.ComboBox();
            this.PopustTextBox = new System.Windows.Forms.TextBox();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonObrisi.BackgroundImage")));
            this.buttonObrisi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonObrisi.Location = new System.Drawing.Point(136, 161);
            this.buttonObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(75, 28);
            this.buttonObrisi.TabIndex = 0;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonAzuriraj
            // 
            this.buttonAzuriraj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAzuriraj.BackgroundImage")));
            this.buttonAzuriraj.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAzuriraj.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAzuriraj.Location = new System.Drawing.Point(59, 161);
            this.buttonAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAzuriraj.Name = "buttonAzuriraj";
            this.buttonAzuriraj.Size = new System.Drawing.Size(72, 28);
            this.buttonAzuriraj.TabIndex = 1;
            this.buttonAzuriraj.Text = "Ažuriraj";
            this.buttonAzuriraj.UseVisualStyleBackColor = true;
            this.buttonAzuriraj.Click += new System.EventHandler(this.buttonAzuriraj_Click);
            // 
            // labelNazivOpcije
            // 
            this.labelNazivOpcije.AutoSize = true;
            this.labelNazivOpcije.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazivOpcije.Location = new System.Drawing.Point(89, 30);
            this.labelNazivOpcije.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNazivOpcije.Name = "labelNazivOpcije";
            this.labelNazivOpcije.Size = new System.Drawing.Size(103, 20);
            this.labelNazivOpcije.TabIndex = 2;
            this.labelNazivOpcije.Text = "Naziv opcije:";
            // 
            // labelPopust
            // 
            this.labelPopust.AutoSize = true;
            this.labelPopust.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPopust.Location = new System.Drawing.Point(89, 94);
            this.labelPopust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPopust.Name = "labelPopust";
            this.labelPopust.Size = new System.Drawing.Size(62, 20);
            this.labelPopust.TabIndex = 3;
            this.labelPopust.Text = "Popust:";
            // 
            // OdustaniButton
            // 
            this.OdustaniButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OdustaniButton.BackgroundImage")));
            this.OdustaniButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdustaniButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.OdustaniButton.Location = new System.Drawing.Point(217, 161);
            this.OdustaniButton.Margin = new System.Windows.Forms.Padding(4);
            this.OdustaniButton.Name = "OdustaniButton";
            this.OdustaniButton.Size = new System.Drawing.Size(96, 28);
            this.OdustaniButton.TabIndex = 8;
            this.OdustaniButton.Text = "Odustani";
            this.OdustaniButton.UseVisualStyleBackColor = true;
            this.OdustaniButton.Click += new System.EventHandler(this.OdustaniButton_Click);
            // 
            // NazivComboBox
            // 
            this.NazivComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NazivComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.NazivComboBox.FormattingEnabled = true;
            this.NazivComboBox.Location = new System.Drawing.Point(60, 55);
            this.NazivComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.NazivComboBox.Name = "NazivComboBox";
            this.NazivComboBox.Size = new System.Drawing.Size(252, 24);
            this.NazivComboBox.TabIndex = 9;
            this.NazivComboBox.SelectedIndexChanged += new System.EventHandler(this.NazivComboBox_SelectedIndexChanged);
            // 
            // PopustTextBox
            // 
            this.PopustTextBox.Location = new System.Drawing.Point(60, 118);
            this.PopustTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PopustTextBox.Name = "PopustTextBox";
            this.PopustTextBox.Size = new System.Drawing.Size(252, 22);
            this.PopustTextBox.TabIndex = 10;
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(60, 90);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // AzuriranjeBrisanjeLoyaltyOpcijeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(373, 213);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PopustTextBox);
            this.Controls.Add(this.NazivComboBox);
            this.Controls.Add(this.OdustaniButton);
            this.Controls.Add(this.labelPopust);
            this.Controls.Add(this.labelNazivOpcije);
            this.Controls.Add(this.buttonAzuriraj);
            this.Controls.Add(this.buttonObrisi);
            this.helpProvider.SetHelpKeyword(this, "Azuriranje");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AzuriranjeBrisanjeLoyaltyOpcijeFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "AžuriranjeBrisanjeLoyaltyOpcije";
            this.Load += new System.EventHandler(this.AzuriranjeBrisanjeLoyaltyOpcijeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonAzuriraj;
        private System.Windows.Forms.Label labelNazivOpcije;
        private System.Windows.Forms.Label labelPopust;
        private System.Windows.Forms.Button OdustaniButton;
        private System.Windows.Forms.ComboBox NazivComboBox;
        private System.Windows.Forms.TextBox PopustTextBox;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}