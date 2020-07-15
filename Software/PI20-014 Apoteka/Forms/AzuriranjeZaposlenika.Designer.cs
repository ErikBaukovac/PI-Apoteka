namespace PI20_014
{
    partial class AzuriranjeZaposlenikaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AzuriranjeZaposlenikaFrm));
            this.odustaniBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.zaposleniciDgv = new System.Windows.Forms.DataGridView();
            this.lozinkaTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // odustaniBtn
            // 
            this.odustaniBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.odustaniBtn.Location = new System.Drawing.Point(443, 410);
            this.odustaniBtn.Margin = new System.Windows.Forms.Padding(2);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(87, 30);
            this.odustaniBtn.TabIndex = 5;
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.updateBtn.Location = new System.Drawing.Point(336, 410);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(87, 30);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Azuriraj";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // zaposleniciDgv
            // 
            this.zaposleniciDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.zaposleniciDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zaposleniciDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.zaposleniciDgv.Location = new System.Drawing.Point(0, 0);
            this.zaposleniciDgv.Margin = new System.Windows.Forms.Padding(2);
            this.zaposleniciDgv.Name = "zaposleniciDgv";
            this.zaposleniciDgv.RowHeadersWidth = 51;
            this.zaposleniciDgv.RowTemplate.Height = 24;
            this.zaposleniciDgv.Size = new System.Drawing.Size(544, 251);
            this.zaposleniciDgv.TabIndex = 4;
            this.zaposleniciDgv.SelectionChanged += new System.EventHandler(this.popisZaposlenikaGrid_SelectionChanged);
            // 
            // lozinkaTxt
            // 
            this.lozinkaTxt.Location = new System.Drawing.Point(24, 352);
            this.lozinkaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.lozinkaTxt.Name = "lozinkaTxt";
            this.lozinkaTxt.Size = new System.Drawing.Size(180, 24);
            this.lozinkaTxt.TabIndex = 22;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(24, 291);
            this.userNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(180, 24);
            this.userNameTxt.TabIndex = 23;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(22, 413);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(2);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(180, 24);
            this.emailTxt.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Korisničko ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 390);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Email";
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 329);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(24, 390);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // surnameTxt
            // 
            this.surnameTxt.Location = new System.Drawing.Point(256, 354);
            this.surnameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(180, 24);
            this.surnameTxt.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 329);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Prezime";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(256, 291);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(180, 24);
            this.nameTxt.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ime";
            // 
            // AzuriranjeZaposlenikaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(544, 457);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lozinkaTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odustaniBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.zaposleniciDgv);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Azuriranje");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AzuriranjeZaposlenikaFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "Azuriranje zaposlenika";
            this.Load += new System.EventHandler(this.AzuriranjeZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button odustaniBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView zaposleniciDgv;
        private System.Windows.Forms.TextBox lozinkaTxt;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label5;
    }
}