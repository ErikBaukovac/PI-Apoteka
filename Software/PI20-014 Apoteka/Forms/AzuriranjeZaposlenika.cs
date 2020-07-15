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
using PI20_014_Apoteka.Dodatne_klase;

namespace PI20_014
{
    public partial class AzuriranjeZaposlenikaFrm : Form
    {
        private Korisnik prijavljen;

        public AzuriranjeZaposlenikaFrm()
        {
            InitializeComponent();
        }

        public AzuriranjeZaposlenikaFrm(Korisnik proslijeden)
        {
            InitializeComponent();
            prijavljen = proslijeden;
        }

        private void AzuriranjeZaposlenika_Load(object sender, EventArgs e)
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
                    zaposleniciDgv.Columns["Lozinka"].Visible = false;
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

        private void popisZaposlenikaGrid_SelectionChanged(object sender, EventArgs e)
        {
            using (var context = new PI20_014_DBEntities())
            {
                var odabran = zaposleniciDgv.CurrentRow.DataBoundItem as Korisnik;
                userNameTxt.Text = odabran.KorisnickoIme;
                lozinkaTxt.Text = odabran.Lozinka;
                emailTxt.Text = odabran.Email;
                nameTxt.Text = odabran.Ime;
                surnameTxt.Text = odabran.Prezime;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string userName = userNameTxt.Text;
            string lozinka = lozinkaTxt.Text;
            string email = emailTxt.Text;
            string ime = nameTxt.Text;
            string prezime = surnameTxt.Text;
            string kriptiranaLozinka = ProvjeraUnosa.KriptirajLozinku(lozinka);

            using (var context = new PI20_014_DBEntities())
            {
                var odabran = zaposleniciDgv.CurrentRow.DataBoundItem as Korisnik;
                context.Korisnik.Attach(odabran);
                odabran.KorisnickoIme=userName;
                odabran.Lozinka= kriptiranaLozinka;
                odabran.Email=email;
                odabran.Ime = ime;
                odabran.Prezime = prezime;
                context.SaveChanges();
            }
            GUI();
        }
    }
}
