namespace PI20_014_Apoteka.Forms
{
    partial class StanjeZalihaFrm
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
            this.stanjeZalihaDgv = new System.Windows.Forms.DataGridView();
            this.povecajBtn = new System.Windows.Forms.Button();
            this.smanjiBtn = new System.Windows.Forms.Button();
            this.ukolniBtn = new System.Windows.Forms.Button();
            this.odustaniBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.kolicinaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lijekCmb = new System.Windows.Forms.ComboBox();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.stanjeZalihaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // stanjeZalihaDgv
            // 
            this.stanjeZalihaDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.stanjeZalihaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stanjeZalihaDgv.Location = new System.Drawing.Point(22, 11);
            this.stanjeZalihaDgv.Margin = new System.Windows.Forms.Padding(2);
            this.stanjeZalihaDgv.Name = "stanjeZalihaDgv";
            this.stanjeZalihaDgv.RowHeadersWidth = 51;
            this.stanjeZalihaDgv.RowTemplate.Height = 24;
            this.stanjeZalihaDgv.Size = new System.Drawing.Size(373, 191);
            this.stanjeZalihaDgv.TabIndex = 0;
            this.stanjeZalihaDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stanjeZalihaDgv_CellContentClick);
            // 
            // povecajBtn
            // 
            this.povecajBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.povecajBtn.Location = new System.Drawing.Point(19, 236);
            this.povecajBtn.Margin = new System.Windows.Forms.Padding(2);
            this.povecajBtn.Name = "povecajBtn";
            this.povecajBtn.Size = new System.Drawing.Size(74, 40);
            this.povecajBtn.TabIndex = 1;
            this.povecajBtn.Text = "Povećaj";
            this.povecajBtn.UseVisualStyleBackColor = false;
            this.povecajBtn.Click += new System.EventHandler(this.povecajBtn_Click);
            // 
            // smanjiBtn
            // 
            this.smanjiBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.smanjiBtn.Location = new System.Drawing.Point(97, 236);
            this.smanjiBtn.Margin = new System.Windows.Forms.Padding(2);
            this.smanjiBtn.Name = "smanjiBtn";
            this.smanjiBtn.Size = new System.Drawing.Size(89, 40);
            this.smanjiBtn.TabIndex = 1;
            this.smanjiBtn.Text = "Smanji";
            this.smanjiBtn.UseVisualStyleBackColor = false;
            this.smanjiBtn.Click += new System.EventHandler(this.smanjiBtn_Click);
            // 
            // ukolniBtn
            // 
            this.ukolniBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ukolniBtn.Location = new System.Drawing.Point(190, 238);
            this.ukolniBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ukolniBtn.Name = "ukolniBtn";
            this.ukolniBtn.Size = new System.Drawing.Size(73, 40);
            this.ukolniBtn.TabIndex = 2;
            this.ukolniBtn.Text = "Ukloni";
            this.ukolniBtn.UseVisualStyleBackColor = false;
            this.ukolniBtn.Click += new System.EventHandler(this.ukolniBtn_Click);
            // 
            // odustaniBtn
            // 
            this.odustaniBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.odustaniBtn.Location = new System.Drawing.Point(460, 236);
            this.odustaniBtn.Margin = new System.Windows.Forms.Padding(2);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(106, 40);
            this.odustaniBtn.TabIndex = 3;
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.UseVisualStyleBackColor = false;
            this.odustaniBtn.Click += new System.EventHandler(this.odustaniBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kolicina odabranog lijeka";
            // 
            // dodajBtn
            // 
            this.dodajBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dodajBtn.Location = new System.Drawing.Point(439, 113);
            this.dodajBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(93, 27);
            this.dodajBtn.TabIndex = 6;
            this.dodajBtn.Text = "Dodaj novi";
            this.dodajBtn.UseVisualStyleBackColor = false;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // kolicinaTxt
            // 
            this.kolicinaTxt.Location = new System.Drawing.Point(422, 85);
            this.kolicinaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.kolicinaTxt.Name = "kolicinaTxt";
            this.kolicinaTxt.Size = new System.Drawing.Size(125, 24);
            this.kolicinaTxt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kolicina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lijek";
            // 
            // lijekCmb
            // 
            this.lijekCmb.FormattingEnabled = true;
            this.lijekCmb.Location = new System.Drawing.Point(422, 31);
            this.lijekCmb.Margin = new System.Windows.Forms.Padding(2);
            this.lijekCmb.Name = "lijekCmb";
            this.lijekCmb.Size = new System.Drawing.Size(125, 27);
            this.lijekCmb.TabIndex = 7;
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // StanjeZalihaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(577, 287);
            this.Controls.Add(this.kolicinaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lijekCmb);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odustaniBtn);
            this.Controls.Add(this.ukolniBtn);
            this.Controls.Add(this.smanjiBtn);
            this.Controls.Add(this.povecajBtn);
            this.Controls.Add(this.stanjeZalihaDgv);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Stanje");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StanjeZalihaFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "StanjeZalihaFrm";
            this.Load += new System.EventHandler(this.StanjeZalihaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stanjeZalihaDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stanjeZalihaDgv;
        private System.Windows.Forms.Button povecajBtn;
        private System.Windows.Forms.Button smanjiBtn;
        private System.Windows.Forms.Button ukolniBtn;
        private System.Windows.Forms.Button odustaniBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.TextBox kolicinaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lijekCmb;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}