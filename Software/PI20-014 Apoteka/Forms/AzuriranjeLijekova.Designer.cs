namespace PI20_014
{
    partial class azuriranjeLijekovaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(azuriranjeLijekovaFrm));
            this.lijekoviDgv = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.odustaniBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nazivTxt = new System.Windows.Forms.TextBox();
            this.cijenaTxt = new System.Windows.Forms.TextBox();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lijekoviDgv
            // 
            this.lijekoviDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.lijekoviDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lijekoviDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.lijekoviDgv.Location = new System.Drawing.Point(0, 0);
            this.lijekoviDgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lijekoviDgv.Name = "lijekoviDgv";
            this.lijekoviDgv.RowHeadersWidth = 51;
            this.lijekoviDgv.RowTemplate.Height = 24;
            this.lijekoviDgv.Size = new System.Drawing.Size(553, 251);
            this.lijekoviDgv.TabIndex = 0;
            this.lijekoviDgv.SelectionChanged += new System.EventHandler(this.popisLijekovaGrid_SelectionChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.updateBtn.Location = new System.Drawing.Point(361, 344);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(87, 30);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Ažuriraj";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // odustaniBtn
            // 
            this.odustaniBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.odustaniBtn.Location = new System.Drawing.Point(455, 344);
            this.odustaniBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(87, 30);
            this.odustaniBtn.TabIndex = 1;
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.UseVisualStyleBackColor = false;
            this.odustaniBtn.Click += new System.EventHandler(this.odustaniBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cijena";
            // 
            // nazivTxt
            // 
            this.nazivTxt.Location = new System.Drawing.Point(13, 290);
            this.nazivTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nazivTxt.Name = "nazivTxt";
            this.nazivTxt.Size = new System.Drawing.Size(219, 21);
            this.nazivTxt.TabIndex = 3;
            // 
            // cijenaTxt
            // 
            this.cijenaTxt.Location = new System.Drawing.Point(13, 348);
            this.cijenaTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cijenaTxt.Name = "cijenaTxt";
            this.cijenaTxt.Size = new System.Drawing.Size(219, 21);
            this.cijenaTxt.TabIndex = 3;
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 86);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // azuriranjeLijekovaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(553, 399);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cijenaTxt);
            this.Controls.Add(this.nazivTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odustaniBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.lijekoviDgv);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Azuriranje");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "azuriranjeLijekovaFrm";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "Azuriranje lijekova";
            this.Load += new System.EventHandler(this.azuriranjeLijekovaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lijekoviDgv;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button odustaniBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nazivTxt;
        private System.Windows.Forms.TextBox cijenaTxt;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}