namespace PI20_014_Apoteka.Forms
{
    partial class PregledKorisnikaFrm
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
            this.KorisniciDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.KorisniciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // KorisniciDataGridView
            // 
            this.KorisniciDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.KorisniciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KorisniciDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KorisniciDataGridView.Location = new System.Drawing.Point(0, 0);
            this.KorisniciDataGridView.Name = "KorisniciDataGridView";
            this.KorisniciDataGridView.RowHeadersWidth = 51;
            this.KorisniciDataGridView.RowTemplate.Height = 24;
            this.KorisniciDataGridView.Size = new System.Drawing.Size(800, 437);
            this.KorisniciDataGridView.TabIndex = 0;
            this.KorisniciDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KorisniciDataGridView_CellContentClick);
            // 
            // PregledKorisnikaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.KorisniciDataGridView);
            this.Name = "PregledKorisnikaFrm";
            this.Text = "PregledKorisnikaFrm";
            this.Load += new System.EventHandler(this.PregledKorisnikaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KorisniciDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView KorisniciDataGridView;
    }
}