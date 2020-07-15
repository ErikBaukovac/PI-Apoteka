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
    public partial class UnosZaposlenikaFrm : Form
    {
        private Korisnik prijavljen;

        public UnosZaposlenikaFrm()
        {
            InitializeComponent();
        }

        public UnosZaposlenikaFrm(Korisnik prijavljen)
        {
            InitializeComponent();
            this.prijavljen = prijavljen;
        }

        private void UnosZaposlenika_Load(object sender, EventArgs e)
        {
            using (var contex = new PI20_014_DBEntities())
            {
                var odabranaTvrtka = contex.Tvrtka.First(t => t.Admin == prijavljen.ID);
                apotekaCmb.DataSource = odabranaTvrtka.Apoteka.ToList();
            }

            GUI();
        }

        private void GUI()
        {
            var apoteka = DohvatiApoteku();

            using (var context = new PI20_014_DBEntities())
            {

                if (apoteka != null)
                {
                    var query = from z in context.Korisnik
                                where z.Apoteka == apoteka.ID
                                select z;

                    zaposelniciDgv.DataSource = query.ToList();
                    zaposelniciDgv.Columns["ID"].Visible = false;
                    zaposelniciDgv.Columns["Apoteka"].Visible = false;
                    zaposelniciDgv.Columns["Lozinka"].Visible = false;
                    zaposelniciDgv.Columns["Email"].Visible = false;
                    zaposelniciDgv.Columns["Uloga"].Visible = false;
                    zaposelniciDgv.Columns["LoyaltyOpcije"].Visible = false;
                    zaposelniciDgv.Columns["Apoteka1"].Visible = false;
                    zaposelniciDgv.Columns["LoyaltyOpcije1"].Visible = false;
                    zaposelniciDgv.Columns["Uloga1"].Visible = false;
                    zaposelniciDgv.Columns["Narudzbenica"].Visible = false;
                    zaposelniciDgv.Columns["Racun"].Visible = false;
                    zaposelniciDgv.Columns["Rezervirao"].Visible = false;
                    zaposelniciDgv.Columns["Tvrtka"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Nema podataka");
                }
            }
            
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void apotekaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GUI();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            string userName = userNameTxt.Text.ToLower();
            string lozinka = lozinkaTxt.Text;
            string email = emailTxt.Text;
            string ime = nameTxt.Text;
            string prezime = surnameTxt.Text;

            if (ProvjeraUnosa.ValidacijaZaposlenika(userName, lozinka, email, ime, prezime))
            {
                UnesiZaposlenika(userName, lozinka, email);
                IsprazniPolja();
                MessageBox.Show("Uspjesno uneseno");
            }
            else
                IsprazniPolja();
            GUI();
        }
        private void IsprazniPolja()
        {
            userNameTxt.Clear();
            lozinkaTxt.Clear();
            emailTxt.Clear();
        }

        private void UnesiZaposlenika(string userName, string lozinka, string email)
        {
            using (var context = new PI20_014_DBEntities())
            {
                var OdabranaApoteka = DohvatiApoteku();
                string kriptiranaLozinka = ProvjeraUnosa.KriptirajLozinku(lozinka);

                Korisnik novi = new Korisnik
                {
                    KorisnickoIme = userName,
                    Email = email,
                    Lozinka = kriptiranaLozinka,
                    Uloga = 3,
                    Apoteka = OdabranaApoteka.ID
                };

                context.Korisnik.Add(novi);
                context.SaveChanges();
            }
        }

        private PI20_014_Apoteka.Entity_Framework.Apoteka DohvatiApoteku()
        {
            return apotekaCmb.SelectedItem as PI20_014_Apoteka.Entity_Framework.Apoteka;
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
