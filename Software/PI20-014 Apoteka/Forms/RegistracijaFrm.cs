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

namespace PI20_014_Apoteka.Forms
{
    public partial class RegistracijaFrm : Form
    {
        
        public RegistracijaFrm()
        {
            InitializeComponent();
        }

        private void Registrirajbutton_Click(object sender, EventArgs e)
        {
            using (var contex = new PI20_014_DBEntities())
            {
                string korIme = korImeTextBox.Text.ToLower();
                string email = EmailTextBox.Text;
                string lozinka = LozinkaTextBox.Text;
                string ime = ImeTextBox.Text;
                string prezime = PrezimeTextBox.Text;

                string kriptiranaLozina = ProvjeraUnosa.KriptirajLozinku(lozinka);


                if (ProvjeraUnosa.ValidacijaKorisnik(korIme, email, lozinka, ime, prezime))
                {
                    UnesiKorisnika(korIme, email, kriptiranaLozina, ime, prezime);
                    IsprazniPolja();
                    MessageBox.Show("Uspješno uneseno!");
                }
                else
                    IsprazniPolja();
            }
        }

        private void IsprazniPolja()
        {
            korImeTextBox.Clear();
            EmailTextBox.Clear();
            LozinkaTextBox.Clear();
            ImeTextBox.Clear();
            PrezimeTextBox.Clear();
        }

        private void UnesiKorisnika(string korIme, string email, string lozinka, string ime, string prezime)
        {
            using (var context = new PI20_014_DBEntities())
            {
                Korisnik novi = new Korisnik
                {
                    KorisnickoIme = korIme,
                    Email = email,
                    Lozinka = lozinka,
                    Ime = ime,
                    Prezime = prezime,
                    Uloga = 4,
                };

                context.Korisnik.Add(novi);
                context.SaveChanges();
            }
        }

        private bool KorisnikPostoji(string korIme)
        {
            using (var context = new PI20_014_DBEntities())
            {
                var query = (from k in context.Korisnik
                             where k.KorisnickoIme == korIme
                             select k).Count();

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

        private void OdustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegistracijaFrm_Load(object sender, EventArgs e)
        {

        }
    }
}