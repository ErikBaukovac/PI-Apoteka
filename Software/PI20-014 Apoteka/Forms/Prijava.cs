using PI20_014_Apoteka.Entity_Framework;
using PI20_014_Apoteka.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using PI20_014_Apoteka.Dodatne_klase;

namespace Prijava
{
    public partial class PrijavaFrm : Form
    {
        Thread dretva;
        public Korisnik Prijavljen { get; set; }
        public PrijavaFrm()
        {
            InitializeComponent();
        }

        private void PrijavaFrm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            using (var contex = new PI20_014_DBEntities())
            {

                Prijavljen = DohvatiPrijavljenog();

                if (Prijavljen != null)
                {
                    if (Prijavljen.Uloga==1 || Prijavljen.Uloga == 2)
                    {
                        this.Close();
                        dretva = new Thread(AdminForma);
                        dretva.SetApartmentState(ApartmentState.STA);
                        dretva.Start();
                    }
                    else if(Prijavljen.Uloga == 3)
                    {
                        this.Close();
                        dretva = new Thread(ZaposlenikForma);
                        dretva.SetApartmentState(ApartmentState.STA);
                        dretva.Start();
                    }
                    else if (Prijavljen.Uloga == 4) 
                    {
                        if (MozeSePrijaviti(Prijavljen))
                        {
                            this.Close();
                            dretva = new Thread(KorisnikForma);
                            dretva.SetApartmentState(ApartmentState.STA);
                            dretva.Start();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pogrešno uneseni podatci");
                    textBoxKorIme.Clear();
                    textBoxLozinka.Clear();
                }
            }
        }

        private Korisnik DohvatiPrijavljenog()
        {
            string userName = textBoxKorIme.Text.ToLower();
            string password = textBoxLozinka.Text;
            string kriptiranaLozinka = ProvjeraUnosa.KriptirajLozinku(password);
            using (var contex = new PI20_014_DBEntities())
            {
                return contex.Korisnik.FirstOrDefault(k => k.KorisnickoIme == userName && k.Lozinka == kriptiranaLozinka);

            }
        }

        private bool MozeSePrijaviti(Korisnik prijavljen)
        {
            if (prijavljen.LoyaltyOpcije != null)
                return true;
            else
            {
                MessageBox.Show("Nemate Loyalty pogodnosti");
                return false;
            }
        }

        private void KorisnikForma()
        {
            Application.Run(new MainKorisnikFrm(Prijavljen));

        }

        private void ZaposlenikForma()
        {
            Application.Run(new MainZaposlenikFrm(Prijavljen));
        }

        private void AdminForma()
        {
            Application.Run(new MainAdministratorFrm(Prijavljen));
        }
    }
}
