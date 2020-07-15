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
using MailLib;

namespace PI20_014_Apoteka.Forms
{
    public partial class StanjeZalihaFrm : Form
    {

        MailKlijent mailKlijent = new MailKlijent();

        private Korisnik prijavljen;

        public StanjeZalihaFrm()
        {
            InitializeComponent();
        }

        public StanjeZalihaFrm(Korisnik proslijeden)
        {
            InitializeComponent();
            prijavljen = proslijeden;
        }

        private void StanjeZalihaFrm_Load(object sender, EventArgs e)
        {
            GUI();
        }

        private void GUI()
        {
            using (var context = new PI20_014_DBEntities())
            {
                var query = from z in context.Zalihe.Include("Lijek")
                            where z.ID_apoteke == prijavljen.Apoteka
                            select z;

                stanjeZalihaDgv.DataSource = query.ToList();
                stanjeZalihaDgv.Columns["Apoteka"].Visible = false;
                stanjeZalihaDgv.Columns["ID_apoteke"].Visible = false;
                stanjeZalihaDgv.Columns["ID_lijeka"].Visible = false;
                
                lijekCmb.DataSource = context.Lijek.ToList();
            }
            kolicinaTxt.Clear();
        }

        private void povecajBtn_Click(object sender, EventArgs e)
        {
            Zalihe odabranaZaliha = DohvatiZalihe();
            int razlika = int.Parse(kolicinaTxt.Text);

            using (var context = new PI20_014_DBEntities())
            {
                context.Zalihe.Attach(odabranaZaliha);
                var dugovanja = DohvatiDugovanja();
                odabranaZaliha.Kolicina += razlika;
                context.SaveChanges();
                VratiDugove(dugovanja);
            }
            GUI();

        }

        private void VratiDugove(List<Rezervirao> PopisDugovanja)
        {
            Zalihe odabranaZaliha = DohvatiZalihe();

            using (var context = new PI20_014_DBEntities())
            {
                if (PopisDugovanja.Count() > 0)
                {
                    foreach (var dugovanje in PopisDugovanja)
                    {
                        Korisnik klijent = PronadiKlijenta(dugovanje.ID_korisnika);
                        var apotekaPosiljatelj = PronadiApoteku();

                        mailKlijent.PosaljiMail(prijavljen.KorisnickoIme, prijavljen.Email, klijent.KorisnickoIme, klijent.Email, apotekaPosiljatelj.Naziv,apotekaPosiljatelj.Adresa);

                        odabranaZaliha.Kolicina -= dugovanje.Kolicina;
                        dugovanje.Kolicina += dugovanje.Kolicina;
                    }
                }
                context.SaveChanges();
            }
        }

        private List<Rezervirao> DohvatiDugovanja()
        {

            using (var context = new PI20_014_DBEntities())
            {
                var query = from r in context.Rezervirao
                            join a in context.Apoteka on r.ID_apoteke equals a.ID
                            join z in context.Zalihe on a.ID equals z.ID_apoteke
                            where z.Kolicina < 0 && a.ID == prijavljen.Apoteka
                            select r;

                return query.ToList();
            }
        }

        private Entity_Framework.Apoteka PronadiApoteku()
        {
            using (var context = new PI20_014_DBEntities())
            {
                return context.Apoteka.First(a => a.ID == prijavljen.Apoteka);
            }
        }

        private Korisnik PronadiKlijenta(int id_korisnika)
        {
            using (var context = new PI20_014_DBEntities())
            {
                return context.Korisnik.First(k => k.ID == id_korisnika);
            }
        }

        private Zalihe DohvatiZalihe()
        {
            return stanjeZalihaDgv.CurrentRow.DataBoundItem as Zalihe;
        }

        private void smanjiBtn_Click(object sender, EventArgs e)
        {
            Zalihe odabranaZaliha = DohvatiZalihe();
            int razlika = int.Parse(kolicinaTxt.Text);

            using (var context = new PI20_014_DBEntities())
            {
                context.Zalihe.Attach(odabranaZaliha);
                odabranaZaliha.Kolicina -= razlika;

                context.SaveChanges();
            }

            GUI();
        }

        private void ukolniBtn_Click(object sender, EventArgs e)
        {
            Zalihe odabranaZaliha = DohvatiZalihe();

            if (odabranaZaliha != null)
            {
                using (var context = new PI20_014_DBEntities())
                {
                    context.Zalihe.Attach(odabranaZaliha);
                    context.Zalihe.Remove(odabranaZaliha);
                    context.SaveChanges();
                }
            }
            GUI();
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (!ZalihaPostoji()) {
                Lijek odabraniLijek = lijekCmb.SelectedItem as Lijek;
                int kolicina = int.Parse(kolicinaTxt.Text);

                using (var context = new PI20_014_DBEntities())
                {
                    var apoteka = context.Apoteka.FirstOrDefault(a => a.ID == prijavljen.Apoteka);

                    Zalihe novaZaliha = new Zalihe
                    {
                        ID_apoteke = apoteka.ID,
                        ID_lijeka = odabraniLijek.ID,
                        Kolicina = kolicina
                    };

                    context.Zalihe.Add(novaZaliha);
                    context.SaveChanges();
                } 
            }
            else
            {
                MessageBox.Show("Zaliha postoji!!!");
            }
            GUI();
        }

        private bool ZalihaPostoji()
        {
            using (var context = new PI20_014_DBEntities())
            {
                Lijek odabraniLijek = lijekCmb.SelectedItem as Lijek;
                var apoteka = context.Apoteka.FirstOrDefault(a => a.ID == prijavljen.Apoteka);
                var query = (from z in context.Zalihe
                            where z.ID_apoteke == apoteka.ID && z.ID_lijeka == odabraniLijek.ID
                            select z).Count();
                if (query>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void stanjeZalihaDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
