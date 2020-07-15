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
    public partial class AzuriranjeDobavljacaFrm : Form
    {
        public AzuriranjeDobavljacaFrm()
        {
            InitializeComponent();
        }

        private void AzuriranjeDobavljaca_Load(object sender, EventArgs e)
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

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            using (var contex = new PI20_014_DBEntities())
            {
                int oib = int.Parse(oibTxt.Text);
                string naziv = nazivTxt.Text;
                string adresa = adresaTxt.Text;
                string tel = telefonTxt.Text;

                Dobavljac odabran = DohvatiDobavljaca();
                contex.Dobavljac.Attach(odabran);
                odabran.OIB = oib;
                odabran.Naziv = naziv;
                odabran.Adresa = adresa;
                odabran.TelefonskiBroj = tel;

                contex.SaveChanges();
            }
            GUI();
        }

        private void popisDobavljacaGrid_SelectionChanged(object sender, EventArgs e)
        {
            Dobavljac odabrani = DohvatiDobavljaca();
            if (odabrani != null)
            {
                oibTxt.Text = odabrani.OIB.ToString();
                nazivTxt.Text = odabrani.Naziv;
                adresaTxt.Text = odabrani.Adresa;
                telefonTxt.Text = odabrani.TelefonskiBroj;
            }
        }

        private Dobavljac DohvatiDobavljaca()
        {
            return dobavljaciDgv.CurrentRow.DataBoundItem as Dobavljac;
        }
    }
}
