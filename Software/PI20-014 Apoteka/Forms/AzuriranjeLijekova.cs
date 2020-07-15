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
    public partial class azuriranjeLijekovaFrm : Form
    {
        public azuriranjeLijekovaFrm()
        {
            InitializeComponent();
        }

        private void azuriranjeLijekovaFrm_Load(object sender, EventArgs e)
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            using (var contex = new PI20_014_DBEntities())
            {
                string naziv = nazivTxt.Text;
                double cijena = double.Parse(cijenaTxt.Text);

                Lijek odabran = DohvatiLijek();
                contex.Lijek.Attach(odabran);
                odabran.Naziv = naziv;
                odabran.Cijena = cijena;

                contex.SaveChanges();
            }
            GUI();
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void popisLijekovaGrid_SelectionChanged(object sender, EventArgs e)
        {
            
            Lijek odabrani = DohvatiLijek();
            if (odabrani != null)
            {
                nazivTxt.Text = odabrani.Naziv;
                cijenaTxt.Text = odabrani.Cijena.ToString();
            }
        }

        private Lijek DohvatiLijek()
        {
            return lijekoviDgv.CurrentRow.DataBoundItem as Lijek;
        }
    }
}
