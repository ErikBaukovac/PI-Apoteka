namespace PI20_014_Apoteka.Forms
{
    partial class MainKorisnikFrm
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
            this.odustaniBtn = new System.Windows.Forms.Button();
            this.odjavaLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apotekaCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lijekoviDgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.rezervacijaDgv = new System.Windows.Forms.DataGridView();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.kolicinaTxt = new System.Windows.Forms.TextBox();
            this.rezervirajBtn = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // odustaniBtn
            // 
            this.odustaniBtn.Location = new System.Drawing.Point(593, 414);
            this.odustaniBtn.Margin = new System.Windows.Forms.Padding(2);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(110, 25);
            this.odustaniBtn.TabIndex = 1;
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.UseVisualStyleBackColor = true;
            this.odustaniBtn.Click += new System.EventHandler(this.odustaniBtn_Click);
            // 
            // odjavaLbl
            // 
            this.odjavaLbl.AutoSize = true;
            this.odjavaLbl.Location = new System.Drawing.Point(641, 21);
            this.odjavaLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.odjavaLbl.Name = "odjavaLbl";
            this.odjavaLbl.Size = new System.Drawing.Size(62, 19);
            this.odjavaLbl.TabIndex = 9;
            this.odjavaLbl.Text = "Odjava";
            this.odjavaLbl.Click += new System.EventHandler(this.odjavaLbl_Click);
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(580, 21);
            this.userNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(0, 19);
            this.userNameLbl.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dobrodošao/la";
            // 
            // apotekaCmb
            // 
            this.apotekaCmb.FormattingEnabled = true;
            this.apotekaCmb.Location = new System.Drawing.Point(11, 52);
            this.apotekaCmb.Margin = new System.Windows.Forms.Padding(2);
            this.apotekaCmb.Name = "apotekaCmb";
            this.apotekaCmb.Size = new System.Drawing.Size(210, 27);
            this.apotekaCmb.TabIndex = 10;
            this.apotekaCmb.SelectedIndexChanged += new System.EventHandler(this.apotekaCmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Apoteka:";
            // 
            // lijekoviDgv
            // 
            this.lijekoviDgv.AllowUserToAddRows = false;
            this.lijekoviDgv.AllowUserToDeleteRows = false;
            this.lijekoviDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.lijekoviDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lijekoviDgv.Location = new System.Drawing.Point(10, 85);
            this.lijekoviDgv.Margin = new System.Windows.Forms.Padding(2);
            this.lijekoviDgv.Name = "lijekoviDgv";
            this.lijekoviDgv.ReadOnly = true;
            this.lijekoviDgv.RowHeadersVisible = false;
            this.lijekoviDgv.RowHeadersWidth = 51;
            this.lijekoviDgv.RowTemplate.Height = 24;
            this.lijekoviDgv.Size = new System.Drawing.Size(306, 300);
            this.lijekoviDgv.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rezervirano:";
            // 
            // rezervacijaDgv
            // 
            this.rezervacijaDgv.AllowUserToAddRows = false;
            this.rezervacijaDgv.AllowUserToDeleteRows = false;
            this.rezervacijaDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.rezervacijaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezervacijaDgv.Location = new System.Drawing.Point(397, 85);
            this.rezervacijaDgv.Margin = new System.Windows.Forms.Padding(2);
            this.rezervacijaDgv.Name = "rezervacijaDgv";
            this.rezervacijaDgv.ReadOnly = true;
            this.rezervacijaDgv.RowHeadersVisible = false;
            this.rezervacijaDgv.RowHeadersWidth = 51;
            this.rezervacijaDgv.RowTemplate.Height = 24;
            this.rezervacijaDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rezervacijaDgv.Size = new System.Drawing.Size(306, 300);
            this.rezervacijaDgv.TabIndex = 14;
            this.rezervacijaDgv.SelectionChanged += new System.EventHandler(this.rezervacijaDgv_SelectionChanged);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.removeBtn.Location = new System.Drawing.Point(337, 262);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(40, 30);
            this.removeBtn.TabIndex = 16;
            this.removeBtn.Text = "<-";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.addBtn.Location = new System.Drawing.Point(337, 186);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(40, 30);
            this.addBtn.TabIndex = 15;
            this.addBtn.Text = "->";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // kolicinaTxt
            // 
            this.kolicinaTxt.Location = new System.Drawing.Point(337, 228);
            this.kolicinaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.kolicinaTxt.Name = "kolicinaTxt";
            this.kolicinaTxt.Size = new System.Drawing.Size(41, 24);
            this.kolicinaTxt.TabIndex = 17;
            // 
            // rezervirajBtn
            // 
            this.rezervirajBtn.Location = new System.Drawing.Point(478, 414);
            this.rezervirajBtn.Margin = new System.Windows.Forms.Padding(2);
            this.rezervirajBtn.Name = "rezervirajBtn";
            this.rezervirajBtn.Size = new System.Drawing.Size(110, 25);
            this.rezervirajBtn.TabIndex = 18;
            this.rezervirajBtn.Text = "Rezerviraj";
            this.rezervirajBtn.UseVisualStyleBackColor = true;
            this.rezervirajBtn.Click += new System.EventHandler(this.rezervirajBtn_Click);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // MainKorisnikFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.rezervirajBtn);
            this.Controls.Add(this.kolicinaTxt);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.rezervacijaDgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lijekoviDgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apotekaCmb);
            this.Controls.Add(this.odjavaLbl);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.odustaniBtn);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Korisnik");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainKorisnikFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "MainKorisnikFrm";
            this.Load += new System.EventHandler(this.MainKorisnikFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button odustaniBtn;
        private System.Windows.Forms.Label odjavaLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox apotekaCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView lijekoviDgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView rezervacijaDgv;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox kolicinaTxt;
        private System.Windows.Forms.Button rezervirajBtn;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}