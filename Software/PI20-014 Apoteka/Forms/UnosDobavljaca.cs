using PI20_014_Apoteka.Dodatne_klase;
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
    public partial class UnosDobavljacaFrm : Form
    {
        public UnosDobavljacaFrm()
        {
            InitializeComponent();
        }

        private void UnosDobavljaca_Load(object sender, EventArgs e)
        {

        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            int oib = int.Parse(oibTxt.Text);
            string naziv = nazivTxt.Text;
            string adresa = adresaTxt.Text;
            string tel = telefonTxt.Text;

            if (ProvjeraUnosa.ValidacijaDobavljaca(oib, naziv, adresa, tel))
            {
                UnesiDobavljaca(oib, naziv, adresa, tel);
                IsprazniPolja();
                MessageBox.Show("Uspjesno uneseno");
            }
            else
                IsprazniPolja();
        }

        private void IsprazniPolja()
        {
            oibTxt.Clear();
            nazivTxt.Clear();
            adresaTxt.Clear();
            telefonTxt.Clear();
        }

        private void UnesiDobavljaca(int oib, string naziv,string adresa, string telefon)
        {
            using (var context = new PI20_014_DBEntities())
            {
                Dobavljac novi = new Dobavljac
                {
                    OIB=oib,
                    Naziv = naziv,
                    Adresa=adresa,
                    TelefonskiBroj=telefon
                };

                context.Dobavljac.Add(novi);
                context.SaveChanges();
            }
        }

        private bool DobavljacPostoji(int oib)
        {
            using (var context = new PI20_014_DBEntities())
            {
                var query = (from d in context.Dobavljac
                             where d.OIB == oib
                             select d).Count();

                if (query > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
