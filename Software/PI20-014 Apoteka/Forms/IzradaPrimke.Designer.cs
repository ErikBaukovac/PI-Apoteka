namespace PI20_014_Apoteka.Forms
{
    partial class IzradaPrimke
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.brojOtpremniceTxt = new System.Windows.Forms.TextBox();
            this.brojPrimkeLbl = new System.Windows.Forms.Label();
            this.apotekaLbl = new System.Windows.Forms.Label();
            this.dobavljacCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.odaberiBtn = new System.Windows.Forms.Button();
            this.lijekoviDgv = new System.Windows.Forms.DataGridView();
            this.lijekCmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kolicinaTxt = new System.Windows.Forms.TextBox();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.odustaniBtn = new System.Windows.Forms.Button();
            this.izradiBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj primke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apoteka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Broj otpremnice";
            // 
            // brojOtpremniceTxt
            // 
            this.brojOtpremniceTxt.Location = new System.Drawing.Point(135, 71);
            this.brojOtpremniceTxt.Name = "brojOtpremniceTxt";
            this.brojOtpremniceTxt.Size = new System.Drawing.Size(100, 22);
            this.brojOtpremniceTxt.TabIndex = 1;
            // 
            // brojPrimkeLbl
            // 
            this.brojPrimkeLbl.AutoSize = true;
            this.brojPrimkeLbl.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brojPrimkeLbl.Location = new System.Drawing.Point(97, 9);
            this.brojPrimkeLbl.Name = "brojPrimkeLbl";
            this.brojPrimkeLbl.Size = new System.Drawing.Size(52, 19);
            this.brojPrimkeLbl.TabIndex = 2;
            this.brojPrimkeLbl.Text = "label4";
            // 
            // apotekaLbl
            // 
            this.apotekaLbl.AutoSize = true;
            this.apotekaLbl.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.apotekaLbl.Location = new System.Drawing.Point(97, 40);
            this.apotekaLbl.Name = "apotekaLbl";
            this.apotekaLbl.Size = new System.Drawing.Size(52, 19);
            this.apotekaLbl.TabIndex = 2;
            this.apotekaLbl.Text = "label4";
            // 
            // dobavljacCmb
            // 
            this.dobavljacCmb.FormattingEnabled = true;
            this.dobavljacCmb.Location = new System.Drawing.Point(135, 107);
            this.dobavljacCmb.Name = "dobavljacCmb";
            this.dobavljacCmb.Size = new System.Drawing.Size(121, 24);
            this.dobavljacCmb.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dobavljac";
            // 
            // odaberiBtn
            // 
            this.odaberiBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.odaberiBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odaberiBtn.Location = new System.Drawing.Point(262, 108);
            this.odaberiBtn.Name = "odaberiBtn";
            this.odaberiBtn.Size = new System.Drawing.Size(78, 25);
            this.odaberiBtn.TabIndex = 4;
            this.odaberiBtn.Text = "Odaberi";
            this.odaberiBtn.UseVisualStyleBackColor = false;
            this.odaberiBtn.Click += new System.EventHandler(this.odaberiBtn_Click);
            // 
            // lijekoviDgv
            // 
            this.lijekoviDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.lijekoviDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lijekoviDgv.Location = new System.Drawing.Point(365, 9);
            this.lijekoviDgv.Name = "lijekoviDgv";
            this.lijekoviDgv.RowHeadersWidth = 51;
            this.lijekoviDgv.RowTemplate.Height = 24;
            this.lijekoviDgv.Size = new System.Drawing.Size(276, 248);
            this.lijekoviDgv.TabIndex = 5;
            // 
            // lijekCmb
            // 
            this.lijekCmb.FormattingEnabled = true;
            this.lijekCmb.Location = new System.Drawing.Point(135, 145);
            this.lijekCmb.Name = "lijekCmb";
            this.lijekCmb.Size = new System.Drawing.Size(121, 24);
            this.lijekCmb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lijek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kolicina";
            // 
            // kolicinaTxt
            // 
            this.kolicinaTxt.Location = new System.Drawing.Point(114, 183);
            this.kolicinaTxt.Name = "kolicinaTxt";
            this.kolicinaTxt.Size = new System.Drawing.Size(100, 22);
            this.kolicinaTxt.TabIndex = 9;
            // 
            // dodajBtn
            // 
            this.dodajBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dodajBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajBtn.Location = new System.Drawing.Point(15, 223);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(79, 34);
            this.dodajBtn.TabIndex = 10;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = false;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // odustaniBtn
            // 
            this.odustaniBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.odustaniBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odustaniBtn.Location = new System.Drawing.Point(100, 224);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(94, 33);
            this.odustaniBtn.TabIndex = 11;
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.UseVisualStyleBackColor = false;
            this.odustaniBtn.Click += new System.EventHandler(this.odustaniBtn_Click);
            // 
            // izradiBtn
            // 
            this.izradiBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.izradiBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izradiBtn.Location = new System.Drawing.Point(200, 223);
            this.izradiBtn.Name = "izradiBtn";
            this.izradiBtn.Size = new System.Drawing.Size(80, 34);
            this.izradiBtn.TabIndex = 12;
            this.izradiBtn.Text = "Izradi";
            this.izradiBtn.UseVisualStyleBackColor = false;
            this.izradiBtn.Click += new System.EventHandler(this.izradiBtn_Click);
            // 
            // IzradaPrimke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 276);
            this.Controls.Add(this.izradiBtn);
            this.Controls.Add(this.odustaniBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.kolicinaTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lijekCmb);
            this.Controls.Add(this.lijekoviDgv);
            this.Controls.Add(this.odaberiBtn);
            this.Controls.Add(this.dobavljacCmb);
            this.Controls.Add(this.apotekaLbl);
            this.Controls.Add(this.brojPrimkeLbl);
            this.Controls.Add(this.brojOtpremniceTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IzradaPrimke";
            this.Text = "IzradaPrimke";
            this.Load += new System.EventHandler(this.IzradaPrimke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox brojOtpremniceTxt;
        private System.Windows.Forms.Label brojPrimkeLbl;
        private System.Windows.Forms.Label apotekaLbl;
        private System.Windows.Forms.ComboBox dobavljacCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button odaberiBtn;
        private System.Windows.Forms.DataGridView lijekoviDgv;
        private System.Windows.Forms.ComboBox lijekCmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kolicinaTxt;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button odustaniBtn;
        private System.Windows.Forms.Button izradiBtn;
    }
}