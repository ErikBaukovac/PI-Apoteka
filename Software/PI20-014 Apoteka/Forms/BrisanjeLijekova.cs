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

namespace PI20_014
{
    public partial class brisanjeLijekovaFrm : Form
    {
        public brisanjeLijekovaFrm()
        {
            InitializeComponent();
        }

        private void brisanjeLijekovaFrm_Load(object sender, EventArgs e)
        {
            GUI();
        }

        private void GUI()
        {
            using (var contex = new PI20_014_DBEntities())
            {
                lijekoviDgv.DataSource = contex.Lijek.ToList();
                lijekoviDgv.Columns["Dostupno"].Visible = false;
                lijekoviDgv.Columns["Rezervirao"].Visible = false;
                lijekoviDgv.Columns["StavkeNarudzbenice"].Visible = false;
                lijekoviDgv.Columns["StavkeRacuna"].Visible = false;
                lijekoviDgv.Columns["Zalihe"].Visible = false;
                lijekoviDgv.Columns["StavkePrimke"].Visible = false;

            }
        }

        private void obrisiBtn_Click(object sender, EventArgs e)
        {
            Lijek odabrani = DohvatiLijek();

            if (odabrani != null)
            {
                using (var context = new PI20_014_DBEntities())
                {
                    context.Lijek.Attach(odabrani);
                    
                        context.Lijek.Remove(odabrani);
                        context.SaveChanges();
                }
            }
            GUI();
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Lijek DohvatiLijek()
        {
            return lijekoviDgv.CurrentRow.DataBoundItem as Lijek;
        }
    }
}
