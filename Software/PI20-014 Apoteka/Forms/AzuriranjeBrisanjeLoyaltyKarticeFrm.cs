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
    public partial class AzuriranjeBrisanjeLoyaltyKarticeFrm : Form
    {
        private Korisnik prijavljen;

        public AzuriranjeBrisanjeLoyaltyKarticeFrm()
        {
            InitializeComponent();
        }

        public AzuriranjeBrisanjeLoyaltyKarticeFrm(Korisnik prijavljen)
        {
            InitializeComponent();
            this.prijavljen = prijavljen;
        }

        private void AzuriranjeBrisanjeLoyaltyKarticeFrm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            VlasnikComboBox.DataSource = DohvatiVlasnike();
            OpcijaComboBox.DataSource = DohvatiOpcije();
            ImePrezimeComboBox.DataSource = DohvatiImena();
        }

        private object DohvatiImena()
        {
            using (var context = new PI20_014_DBEntities())
            {
                var query = (from k in context.Korisnik
                             where k.Uloga == 4
                             select k);
                return query.ToList();
            }
        }

        private List<LoyaltyOpcije> DohvatiOpciju()
        {
            using(var context = new PI20_014_DBEntities())
            {

                var query = from l in context.LoyaltyOpcije
                           join k in context.Korisnik on l.ID equals k.LoyaltyOpcije
                           where k.KorisnickoIme==VlasnikComboBox.Text
                           select l;

                return query.ToList();
            }
        }
        private List<LoyaltyOpcije> DohvatiOpcije()
        {
            using (var context = new PI20_014_DBEntities())
            {
                var query = (from l in context.LoyaltyOpcije
                             join t in context.Tvrtka on l.Tvrtka equals t.OIB
                             join a in context.Apoteka on t.OIB equals a.Tvrtka
                             where prijavljen.Apoteka == a.ID 
                             select l).ToList();
                return query;
            }
        }

        private List<string> DohvatiVlasnike()
        {
            using (var context = new PI20_014_DBEntities())
            {
                var query = (from k in context.Korisnik
                             where k.Uloga == 4 
                             select k.KorisnickoIme).ToList();
                return query;
            }
        }

        private List<Korisnik> DohvatiIme()
        {
            using (var context = new PI20_014_DBEntities())
            {
                var query = (from k in context.Korisnik
                             where k.Uloga == 4 && k.KorisnickoIme == VlasnikComboBox.Text
                             select k);
                return query.ToList();
            }
        }

        private List<Korisnik> DohvatiVlasnika()
        {
            using (var context = new PI20_014_DBEntities())
            {
                var query = (from k in context.Korisnik
                             where k.Uloga == 4 && k.Ime + " " + k.Prezime == ImePrezimeComboBox.Text
                             select k).ToList();

                return query;
            }
        }

        private void OdustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            string vlasnik = VlasnikComboBox.Text;
            string opcija = OpcijaComboBox.Text;

            using (var context = new PI20_014_DBEntities())
            {
                var query = (from k in context.Korisnik where k.KorisnickoIme == vlasnik select k).First();
                var qu = (from o in context.LoyaltyOpcije where o.Naziv == opcija select o).First();
                query.LoyaltyOpcije = qu.ID;
                context.SaveChanges();
                MessageBox.Show("Uspješno ažurirano!");
                PregledLoyaltyKarticaFrm forma = new PregledLoyaltyKarticaFrm(prijavljen);
                forma.Show();
            }
            Osvjezi();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            string vlasnik = VlasnikComboBox.Text;
            string opcija = OpcijaComboBox.Text;

                using (var context = new PI20_014_DBEntities())
                {
                    var query = (from k in context.Korisnik where k.KorisnickoIme == vlasnik select k).First();
                    query.LoyaltyOpcije = null;
                    context.SaveChanges();
                    Osvjezi();
                    MessageBox.Show("Uspješno obrisano!");
                    PregledLoyaltyKarticaFrm forma = new PregledLoyaltyKarticaFrm(prijavljen);
                    forma.Show();
            }
        }

        private void VlasnikComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var opcije = DohvatiOpciju();

            if (opcije.Count > 0)
            {
                var opcija = opcije.First();
                var index = OpcijaComboBox.FindString(opcija.Naziv);
                OpcijaComboBox.SelectedIndex = index;
            }

            var imena = DohvatiIme();
            if (imena.Count > 0)
            {

                var ime = imena.First();
                var index = ImePrezimeComboBox.FindString(ime.Ime + " " + ime.Prezime);
                ImePrezimeComboBox.SelectedIndex = index;
            }
        }


        private void ImePrezimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var korImena = DohvatiVlasnika();
            if (korImena.Count > 0)
            {
                var korIme = korImena.First();
                var index = VlasnikComboBox.FindString(korIme.KorisnickoIme);
                VlasnikComboBox.SelectedIndex = index;
            }
        }
    }
}
