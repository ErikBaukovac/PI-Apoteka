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
    public partial class IzradaLoyaltyKarticeFrm : Form
    {
        private Korisnik prijavljen;

        public IzradaLoyaltyKarticeFrm()
        {
            InitializeComponent();
        }

        public IzradaLoyaltyKarticeFrm(Korisnik prijavljen)
        {
            InitializeComponent();
            this.prijavljen = prijavljen;
        }

        private void IzradaLoyaltyKarticeFrm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private List<string> DohvatiOpciju()
        {
            using (var context = new PI20_014_DBEntities())
            {
                var query = (from l in context.LoyaltyOpcije
                             join t in context.Tvrtka on l.Tvrtka equals t.OIB
                             join a in context.Apoteka on t.OIB equals a.Tvrtka
                             where prijavljen.Apoteka == a.ID
                             select l.Naziv).ToList();
                return query;
            }
        }

        private object DohvatiVlasnike()
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
                             where k.Uloga == 4 && k.KorisnickoIme == VlasnikcomboBox.Text
                             select k);
                return query.ToList();
            }
        }
        private void UnesiKarticu()
       {
            string vlasnik = VlasnikcomboBox.Text;
            string opcija = OpcijacomboBox.Text;
            
            using (var context = new PI20_014_DBEntities())
            {
                var q = (from k in context.Korisnik where k.KorisnickoIme == vlasnik select k).First();
                var qu = (from l in context.LoyaltyOpcije where l.Naziv == opcija select l).First();

                    q.LoyaltyOpcije = qu.ID;
                    context.SaveChanges();
                MessageBox.Show("Uspješno uneseno!");
                PregledLoyaltyKarticaFrm forma = new PregledLoyaltyKarticaFrm(prijavljen);
                forma.Show();
            }
            Osvjezi();
        }

        private bool KarticaPostoji(string vlasnik)
        {
            using (var context = new PI20_014_DBEntities())
            {
                var query = (from k in context.Korisnik
                             where k.KorisnickoIme == vlasnik
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

        private void Osvjezi()
        {
            VlasnikcomboBox.DataSource = DohvatiVlasnike();
            ImeComboBox.DataSource = DohvatiImena();
            OpcijacomboBox.DataSource = DohvatiOpciju();
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

        private List<Korisnik> DohvatiVlasnika()
        {
        using (var context = new PI20_014_DBEntities())
        {
            var query = (from k in context.Korisnik
                            where k.Uloga == 4 && k.Ime + " " + k.Prezime == ImeComboBox.Text
                            select k).ToList();

            return query;
            }
        }

        private void OdustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonIzradi_Click(object sender, EventArgs e)
        {
            UnesiKarticu();
        }

        private void VlasnikcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var imena = DohvatiIme();
            if (imena.Count > 0)
            {

                var ime = imena.First();
                var index = ImeComboBox.FindString(ime.Ime + " " + ime.Prezime);
                ImeComboBox.SelectedIndex = index;
            }
        }

        private void ImeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            var korImena = DohvatiVlasnika();
            if (korImena.Count > 0)
            {
                var korIme = korImena.First();
                var index = VlasnikcomboBox.FindString(korIme.KorisnickoIme);
                VlasnikcomboBox.SelectedIndex = index;
            }
        }
    }
}
