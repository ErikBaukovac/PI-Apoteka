namespace PI20_014
{
    partial class AzuriranjeDobavljacaFrm
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.dobavljaciDgv = new System.Windows.Forms.DataGridView();
            this.nazivTxt = new System.Windows.Forms.TextBox();
            this.telefonTxt = new System.Windows.Forms.TextBox();
            this.oibTxt = new System.Windows.Forms.TextBox();
            this.adresaTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // odustaniBtn
            // 
            this.odustaniBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.odustaniBtn.Location = new System.Drawing.Point(399, 391);
            this.odustaniBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(87, 30);
            this.odustaniBtn.TabIndex = 5;
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.UseVisualStyleBackColor = false;
            this.odustaniBtn.Click += new System.EventHandler(this.odustaniBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.updateBtn.Location = new System.Drawing.Point(306, 391);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(87, 30);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Azuriraj";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // dobavljaciDgv
            // 
            this.dobavljaciDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dobavljaciDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dobavljaciDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.dobavljaciDgv.Location = new System.Drawing.Point(0, 0);
            this.dobavljaciDgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dobavljaciDgv.Name = "dobavljaciDgv";
            this.dobavljaciDgv.RowHeadersWidth = 51;
            this.dobavljaciDgv.RowTemplate.Height = 24;
            this.dobavljaciDgv.Size = new System.Drawing.Size(511, 251);
            this.dobavljaciDgv.TabIndex = 4;
            this.dobavljaciDgv.SelectionChanged += new System.EventHandler(this.popisDobavljacaGrid_SelectionChanged);
            // 
            // nazivTxt
            // 
            this.nazivTxt.Location = new System.Drawing.Point(20, 345);
            this.nazivTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nazivTxt.Name = "nazivTxt";
            this.nazivTxt.Size = new System.Drawing.Size(195, 21);
            this.nazivTxt.TabIndex = 15;
            // 
            // telefonTxt
            // 
            this.telefonTxt.Location = new System.Drawing.Point(282, 345);
            this.telefonTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Size = new System.Drawing.Size(203, 21);
            this.telefonTxt.TabIndex = 16;
            // 
            // oibTxt
            // 
            this.oibTxt.Enabled = false;
            this.oibTxt.Location = new System.Drawing.Point(20, 289);
            this.oibTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oibTxt.Name = "oibTxt";
            this.oibTxt.Size = new System.Drawing.Size(195, 21);
            this.oibTxt.TabIndex = 17;
            // 
            // adresaTxt
            // 
            this.adresaTxt.Location = new System.Drawing.Point(282, 289);
            this.adresaTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adresaTxt.Name = "adresaTxt";
            this.adresaTxt.Size = new System.Drawing.Size(203, 21);
            this.adresaTxt.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "OIB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Adresa";
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // AzuriranjeDobavljacaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(511, 434);
            this.Controls.Add(this.nazivTxt);
            this.Controls.Add(this.telefonTxt);
            this.Controls.Add(this.oibTxt);
            this.Controls.Add(this.adresaTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.odustaniBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.dobavljaciDgv);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Azuriranje");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AzuriranjeDobavljacaFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "Azuriranje dobavljaca";
            this.Load += new System.EventHandler(this.AzuriranjeDobavljaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button odustaniBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView dobavljaciDgv;
        private System.Windows.Forms.TextBox nazivTxt;
        private System.Windows.Forms.TextBox telefonTxt;
        private System.Windows.Forms.TextBox oibTxt;
        private System.Windows.Forms.TextBox adresaTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}