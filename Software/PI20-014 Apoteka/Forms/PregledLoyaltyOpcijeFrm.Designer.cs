namespace PI20_014_Apoteka.Forms
{
    partial class PregledLoyaltyOpcijeFrm
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
            this.LoyaltyOpcijaDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.LoyaltyOpcijaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LoyaltyOpcijaDataGridView
            // 
            this.LoyaltyOpcijaDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoyaltyOpcijaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoyaltyOpcijaDataGridView.Location = new System.Drawing.Point(0, 0);
            this.LoyaltyOpcijaDataGridView.Name = "LoyaltyOpcijaDataGridView";
            this.LoyaltyOpcijaDataGridView.RowHeadersWidth = 51;
            this.LoyaltyOpcijaDataGridView.RowTemplate.Height = 24;
            this.LoyaltyOpcijaDataGridView.Size = new System.Drawing.Size(802, 452);
            this.LoyaltyOpcijaDataGridView.TabIndex = 0;
            this.LoyaltyOpcijaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoyaltyOpcijaDataGridView_CellContentClick);
            // 
            // PregledLoyaltyOpcijeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoyaltyOpcijaDataGridView);
            this.Name = "PregledLoyaltyOpcijeFrm";
            this.Text = "PregledLoyaltyOpcijeFrm";
            this.Load += new System.EventHandler(this.PregledLoyaltyOpcijeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoyaltyOpcijaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LoyaltyOpcijaDataGridView;
    }
}