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
    public partial class BrisanjeZaposlenikaFrm : Form
    {
        private Korisnik prijavljen;

        public BrisanjeZaposlenikaFrm()
        {
            InitializeComponent();
        }

        public BrisanjeZaposlenikaFrm(Korisnik proslijeden)
        {
            InitializeComponent();
            prijavljen = proslijeden;
        }

        private void BrisanjeZaposlenika_Load(object sender, EventArgs e)
        {
            GUI();
        }

        private void GUI()
        {
            using (var contex = new PI20_014_DBEntities())
            {
                var odabranaTvrtka = contex.Tvrtka.First(t => t.Admin == prijavljen.ID);
                List<Korisnik> popis = new List<Korisnik>();

                foreach (var apoteka in odabranaTvrtka.Apoteka)
                {
                    foreach (var korisnik in contex.Korisnik)
                    {
                        if (korisnik.Apoteka == apoteka.ID)
                        {
                            popis.Add(korisnik);
                        }
                    }
                }

                if (popis != null)
                {
                    zaposleniciDgv.DataSource = popis;
                    zaposleniciDgv.Columns["ID"].Visible = false;
                    zaposleniciDgv.Columns["Uloga"].Visible = false;
                    zaposleniciDgv.Columns["LoyaltyOpcije"].Visible = false;
                    zaposleniciDgv.Columns["Apoteka1"].Visible = false;
                    zaposleniciDgv.Columns["LoyaltyOpcije1"].Visible = false;
                    zaposleniciDgv.Columns["Uloga1"].Visible = false;
                    zaposleniciDgv.Columns["Narudzbenica"].Visible = false;
                    zaposleniciDgv.Columns["Racun"].Visible = false;
                    zaposleniciDgv.Columns["Rezervirao"].Visible = false;
                    zaposleniciDgv.Columns["Tvrtka"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Nema podataka");
                }
            }
        }

        private void obrisiBtn_Click(object sender, EventArgs e)
        {
             Korisnik odabrani = zaposleniciDgv.CurrentRow.DataBoundItem as Korisnik;

                if (odabrani != null)
                {
                    using (var context = new PI20_014_DBEntities())
                    {
                        context.Korisnik.Attach(odabrani);

                        context.Korisnik.Remove(odabrani);
                        context.SaveChanges();
                    }
                }
                GUI();
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
