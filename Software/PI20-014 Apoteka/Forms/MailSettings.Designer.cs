namespace PI20_014_Apoteka.Forms
{
    partial class MailSettings
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
            this.predvidanjeTrc = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.statistikaTrc = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.nestajeLbl = new System.Windows.Forms.Label();
            this.statistikaLbl = new System.Windows.Forms.Label();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.predvidanjeTrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikaTrc)).BeginInit();
            this.SuspendLayout();
            // 
            // predvidanjeTrc
            // 
            this.predvidanjeTrc.Location = new System.Drawing.Point(10, 46);
            this.predvidanjeTrc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.predvidanjeTrc.Maximum = 30;
            this.predvidanjeTrc.Minimum = 7;
            this.predvidanjeTrc.Name = "predvidanjeTrc";
            this.predvidanjeTrc.Size = new System.Drawing.Size(166, 45);
            this.predvidanjeTrc.TabIndex = 0;
            this.predvidanjeTrc.Value = 7;
            this.predvidanjeTrc.Scroll += new System.EventHandler(this.predvidanjeTrc_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lijek nestaje za:";
            // 
            // statistikaTrc
            // 
            this.statistikaTrc.Location = new System.Drawing.Point(10, 139);
            this.statistikaTrc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statistikaTrc.Maximum = 90;
            this.statistikaTrc.Minimum = 30;
            this.statistikaTrc.Name = "statistikaTrc";
            this.statistikaTrc.Size = new System.Drawing.Size(166, 45);
            this.statistikaTrc.TabIndex = 2;
            this.statistikaTrc.Value = 30;
            this.statistikaTrc.Scroll += new System.EventHandler(this.statistikaTrc_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Statistika unazad              dana";
            // 
            // nestajeLbl
            // 
            this.nestajeLbl.AutoSize = true;
            this.nestajeLbl.Location = new System.Drawing.Point(117, 25);
            this.nestajeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nestajeLbl.Name = "nestajeLbl";
            this.nestajeLbl.Size = new System.Drawing.Size(14, 16);
            this.nestajeLbl.TabIndex = 4;
            this.nestajeLbl.Text = "7";
            // 
            // statistikaLbl
            // 
            this.statistikaLbl.AutoSize = true;
            this.statistikaLbl.Location = new System.Drawing.Point(117, 119);
            this.statistikaLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statistikaLbl.Name = "statistikaLbl";
            this.statistikaLbl.Size = new System.Drawing.Size(20, 16);
            this.statistikaLbl.TabIndex = 4;
            this.statistikaLbl.Text = "30";
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Erik\\Desktop\\FOI\\Me\\6 Semestar\\PI\\Projekt\\r20-marki-pbanic-ebaukovac\\Doc" +
    "umentation\\UserHelp.chm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "dana";
            // 
            // MailSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(204, 193);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statistikaLbl);
            this.Controls.Add(this.nestajeLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statistikaTrc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predvidanjeTrc);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpKeyword(this, "Postavke");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MailSettings";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "MailSettings";
            this.Load += new System.EventHandler(this.MailSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.predvidanjeTrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikaTrc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar predvidanjeTrc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar statistikaTrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nestajeLbl;
        private System.Windows.Forms.Label statistikaLbl;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.Label label3;
    }
}