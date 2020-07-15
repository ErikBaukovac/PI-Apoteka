using PI20_014_Apoteka.Entity_Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI20_014_Apoteka.Forms
{
    public partial class PregledLoyaltyOpcijeFrm : Form
    {
        private Korisnik prijavljen;
        public PregledLoyaltyOpcijeFrm()
        {
            InitializeComponent();
        }

        public PregledLoyaltyOpcijeFrm(Korisnik prijavljen)
        {
            InitializeComponent();
            this.prijavljen = prijavljen;
        }

        private void PregledLoyaltyOpcijeFrm_Load(object sender, EventArgs e)
        {
            GUI();
        }

        private void GUI()
        {
            using (var context = new PI20_014_DBEntities())
            {
                var query = (from l in context.LoyaltyOpcije join t in context.Tvrtka on 
                        l.Tvrtka equals t.OIB where prijavljen.ID == t.Admin 
                        select l).ToList();

                LoyaltyOpcijaDataGridView.DataSource = query;
                LoyaltyOpcijaDataGridView.Columns["Korisnik"].Visible = false;
                LoyaltyOpcijaDataGridView.Columns["Tvrtka1"].Visible = false;
            }
        }

        private void LoyaltyOpcijaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
