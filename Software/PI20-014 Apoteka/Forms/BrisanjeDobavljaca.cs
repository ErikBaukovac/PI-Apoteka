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
    public partial class BrisanjeDobavljacaFrm : Form
    {
        public BrisanjeDobavljacaFrm()
        {
            InitializeComponent();
        }

        private void BrisanjeDobavljaca_Load(object sender, EventArgs e)
        {
            GUI();
        }
        private void GUI()
        {
            using (var contex = new PI20_014_DBEntities())
            {
                dobavljaciDgv.DataSource = contex.Dobavljac.ToList();
                dobavljaciDgv.Columns["Dostupno"].Visible = false;
                dobavljaciDgv.Columns["StavkeNarudzbenice"].Visible = false;
                dobavljaciDgv.Columns["StavkePrimke"].Visible = false;

            }
        }

        private void obrisiBtn_Click(object sender, EventArgs e)
        {
            Dobavljac odabrani = DohvatiDobavljaca();

            if (odabrani != null)
            {
                using (var context = new PI20_014_DBEntities())
                {
                    context.Dobavljac.Attach(odabrani);

                    context.Dobavljac.Remove(odabrani);
                    context.SaveChanges();
                }
            }
            GUI();
        }
        

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Dobavljac DohvatiDobavljaca()
        {
            return dobavljaciDgv.CurrentRow.DataBoundItem as Dobavljac;
        }
    }
}
