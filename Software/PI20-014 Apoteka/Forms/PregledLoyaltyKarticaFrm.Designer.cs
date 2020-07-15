namespace PI20_014_Apoteka.Forms
{
    partial class PregledLoyaltyKarticaFrm
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
            this.LoyaltyKarticeDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.LoyaltyKarticeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LoyaltyKarticeDataGridView
            // 
            this.LoyaltyKarticeDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoyaltyKarticeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoyaltyKarticeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoyaltyKarticeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.LoyaltyKarticeDataGridView.Name = "LoyaltyKarticeDataGridView";
            this.LoyaltyKarticeDataGridView.RowHeadersWidth = 51;
            this.LoyaltyKarticeDataGridView.RowTemplate.Height = 24;
            this.LoyaltyKarticeDataGridView.Size = new System.Drawing.Size(800, 450);
            this.LoyaltyKarticeDataGridView.TabIndex = 0;
            this.LoyaltyKarticeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PregledLoyaltyKarticaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoyaltyKarticeDataGridView);
            this.Name = "PregledLoyaltyKarticaFrm";
            this.Text = "PregledLoyaltyKarticaFrm";
            this.Load += new System.EventHandler(this.PregledLoyaltyKarticaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoyaltyKarticeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LoyaltyKarticeDataGridView;
    }
}