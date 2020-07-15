namespace PI20_014_Apoteka.Forms
{
    partial class IzradaLoyaltyKarticeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzradaLoyaltyKarticeFrm));
            this.buttonIzradi = new System.Windows.Forms.Button();
            this.OdustaniButton = new System.Windows.Forms.Button();
            this.KorImeLabel = new System.Windows.Forms.Label();
            this.labelOpcija = new System.Windows.Forms.Label();
            this.VlasnikcomboBox = new System.Windows.Forms.ComboBox();
            this.OpcijacomboBox = new System.Windows.Forms.ComboBox();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ImeComboBox = new System.Windows.Forms.ComboBox();
            this.ImeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIzradi
            // 
            this.buttonIzradi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonIzradi.BackgroundImage")));
            this.buttonIzradi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzradi.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonIzradi.Location = new System.Drawing.Point(65, 270);
            this.buttonIzradi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIzradi.Name = "buttonIzradi";
            this.buttonIzradi.Size = new System.Drawing.Size(100, 30);
            this.buttonIzradi.TabIndex = 0;
            this.buttonIzradi.Text = "Izradi";
            this.buttonIzradi.UseVisualStyleBackColor = true;
            this.buttonIzradi.Click += new System.EventHandler(this.buttonIzradi_Click);
            // 
            // OdustaniButton
            // 
            this.OdustaniButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OdustaniButton.BackgroundImage")));
            this.OdustaniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdustaniButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.OdustaniButton.Location = new System.Drawing.Point(173, 270);
            this.OdustaniButton.Margin = new System.Windows.Forms.Padding(4);
            this.OdustaniButton.Name = "OdustaniButton";
            this.OdustaniButton.Size = new System.Drawing.Size(100, 30);
            this.OdustaniButton.TabIndex = 1;
            this.OdustaniButton.Text = "Odustani";
            this.OdustaniButton.UseVisualStyleBackColor = true;
            this.OdustaniButton.Click += new System.EventHandler(this.OdustaniButton_Click);
            // 
            // KorImeLabel
            // 
            this.KorImeLabel.AutoSize = true;
            this.KorImeLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KorImeLabel.Location = new System.Drawing.Point(67, 52);
            this.KorImeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KorImeLabel.Name = "KorImeLabel";
            this.KorImeLabel.Size = new System.Drawing.Size(116, 20);
            this.KorImeLabel.TabIndex = 2;
            this.KorImeLabel.Text = "Korisničko ime:";
            // 
            // labelOpcija
            // 
            this.labelOpcija.AutoSize = true;
            this.labelOpcija.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpcija.Location = new System.Drawing.Point(67, 191);
            this.labelOpcija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOpcija.Name = "labelOpcija";
            this.labelOpcija.Size = new System.Drawing.Size(62, 20);
            this.labelOpcija.TabIndex = 3;
            this.labelOpcija.Text = "Opcija:";
            // 
            // VlasnikcomboBox
            // 
            this.VlasnikcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.VlasnikcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.VlasnikcomboBox.FormattingEnabled = true;
            this.VlasnikcomboBox.Location = new System.Drawing.Point(65, 79);
            this.VlasnikcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.VlasnikcomboBox.Name = "VlasnikcomboBox";
            this.VlasnikcomboBox.Size = new System.Drawing.Size(207, 25);
            this.VlasnikcomboBox.TabIndex = 4;
            this.VlasnikcomboBox.SelectedIndexChanged += new System.EventHandler(this.VlasnikcomboBox_SelectedIndexChanged);
            // 
            // OpcijacomboBox
            // 
            this.OpcijacomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.OpcijacomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.OpcijacomboBox.FormattingEnabled = true;
            this.OpcijacomboBox.Location = new System.Drawing.Point(65, 217);
            this.OpcijacomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.OpcijacomboBox.Name = "OpcijacomboBox";
            this.OpcijacomboBox.Size = new System.Drawing.Size(207, 25);
            this.OpcijacomboBox.TabIndex = 5;
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(237, 16);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(107, 104);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // ImeComboBox
            // 
            this.ImeComboBox.FormattingEnabled = true;
            this.ImeComboBox.Location = new System.Drawing.Point(65, 148);
            this.ImeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImeComboBox.Name = "ImeComboBox";
            this.ImeComboBox.Size = new System.Drawing.Size(207, 25);
            this.ImeComboBox.TabIndex = 13;
            this.ImeComboBox.SelectedIndexChanged += new System.EventHandler(this.ImeComboBox_SelectedIndexChanged_1);
            // 
            // ImeLabel
            // 
            this.ImeLabel.AutoSize = true;
            this.ImeLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImeLabel.Location = new System.Drawing.Point(67, 121);
            this.ImeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImeLabel.Name = "ImeLabel";
            this.ImeLabel.Size = new System.Drawing.Size(109, 20);
            this.ImeLabel.TabIndex = 12;
            this.ImeLabel.Text = "Ime i prezime:";
            // 
            // IzradaLoyaltyKarticeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(348, 338);
            this.Controls.Add(this.ImeComboBox);
            this.Controls.Add(this.ImeLabel);
            this.Controls.Add(this.OpcijacomboBox);
            this.Controls.Add(this.VlasnikcomboBox);
            this.Controls.Add(this.labelOpcija);
            this.Controls.Add(this.KorImeLabel);
            this.Controls.Add(this.OdustaniButton);
            this.Controls.Add(this.buttonIzradi);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpProvider.SetHelpKeyword(this, "Izrada");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IzradaLoyaltyKarticeFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "IzradaLoyaltyKartice";
            this.Load += new System.EventHandler(this.IzradaLoyaltyKarticeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIzradi;
        private System.Windows.Forms.Button OdustaniButton;
        private System.Windows.Forms.Label KorImeLabel;
        private System.Windows.Forms.Label labelOpcija;
        private System.Windows.Forms.ComboBox VlasnikcomboBox;
        private System.Windows.Forms.ComboBox OpcijacomboBox;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox ImeComboBox;
        private System.Windows.Forms.Label ImeLabel;
    }
}