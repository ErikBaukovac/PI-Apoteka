namespace PI20_014
{
    partial class UnosZaposlenikaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosZaposlenikaFrm));
            this.lozinkaTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.odustaniBtn = new System.Windows.Forms.Button();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.zaposelniciDgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.apotekaCmb = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zaposelniciDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lozinkaTxt
            // 
            this.lozinkaTxt.Location = new System.Drawing.Point(40, 208);
            this.lozinkaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.lozinkaTxt.Name = "lozinkaTxt";
            this.lozinkaTxt.Size = new System.Drawing.Size(180, 23);
            this.lozinkaTxt.TabIndex = 15;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(40, 44);
            this.userNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(180, 23);
            this.userNameTxt.TabIndex = 17;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(40, 267);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(2);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(180, 23);
            this.emailTxt.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Korisničko ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Email";
            // 
            // odustaniBtn
            // 
            this.odustaniBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.odustaniBtn.Location = new System.Drawing.Point(133, 375);
            this.odustaniBtn.Margin = new System.Windows.Forms.Padding(2);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(87, 30);
            this.odustaniBtn.TabIndex = 9;
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.UseVisualStyleBackColor = false;
            this.odustaniBtn.Click += new System.EventHandler(this.odustaniBtn_Click);
            // 
            // dodajBtn
            // 
            this.dodajBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dodajBtn.Location = new System.Drawing.Point(40, 375);
            this.dodajBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(87, 30);
            this.dodajBtn.TabIndex = 10;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = false;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // zaposelniciDgv
            // 
            this.zaposelniciDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zaposelniciDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zaposelniciDgv.Location = new System.Drawing.Point(279, 21);
            this.zaposelniciDgv.Margin = new System.Windows.Forms.Padding(2);
            this.zaposelniciDgv.Name = "zaposelniciDgv";
            this.zaposelniciDgv.RowHeadersWidth = 51;
            this.zaposelniciDgv.RowTemplate.Height = 24;
            this.zaposelniciDgv.Size = new System.Drawing.Size(278, 328);
            this.zaposelniciDgv.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Apoteka";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // apotekaCmb
            // 
            this.apotekaCmb.FormattingEnabled = true;
            this.apotekaCmb.Location = new System.Drawing.Point(40, 328);
            this.apotekaCmb.Margin = new System.Windows.Forms.Padding(2);
            this.apotekaCmb.Name = "apotekaCmb";
            this.apotekaCmb.Size = new System.Drawing.Size(180, 25);
            this.apotekaCmb.TabIndex = 21;
            this.apotekaCmb.SelectedIndexChanged += new System.EventHandler(this.apotekaCmb_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 303);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 24);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 240);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 21);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(40, 185);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 21);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(40, 98);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(180, 23);
            this.nameTxt.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ime";
            // 
            // surnameTxt
            // 
            this.surnameTxt.Location = new System.Drawing.Point(40, 152);
            this.surnameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(180, 23);
            this.surnameTxt.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Prezime";
            // 
            // UnosZaposlenikaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(592, 437);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.apotekaCmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zaposelniciDgv);
            this.Controls.Add(this.lozinkaTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odustaniBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Unos");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UnosZaposlenikaFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "Novi zaposlenik";
            this.Load += new System.EventHandler(this.UnosZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaposelniciDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lozinkaTxt;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button odustaniBtn;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.DataGridView zaposelniciDgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox apotekaCmb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.Label label6;
    }
}