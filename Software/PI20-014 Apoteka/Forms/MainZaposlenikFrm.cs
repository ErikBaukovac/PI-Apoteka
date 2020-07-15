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
using Org.BouncyCastle.Asn1.Crmf;
using PI20_014;

namespace PI20_014_Apoteka.Forms
{
    public partial class MainZaposlenikFrm : Form
    {
        private bool poslano = false;
        private Korisnik prijavljen;
        MailKlijent mailKlijent = new MailKlijent();
        MailSettings setting = new MailSettings();

        public MainZaposlenikFrm()
        {
            InitializeComponent();
        }

        public MainZaposlenikFrm(Korisnik proslijeden)
        {
            InitializeComponent();
            prijavljen = proslijeden;
        }

        private void MainZaposlenikFrm_Load(object sender, EventArgs e)
        {
            AnalizaLijekova();
        }

        private void stanjeZalihaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StanjeZalihaFrm forma = new StanjeZalihaFrm(prijavljen);
            forma.ShowDialog();
        }

        private void dobavljačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledDobavljacaFrm forma = new PregledDobavljacaFrm();
            forma.Show();
        }

        private void korisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistracijaFrm forma = new RegistracijaFrm();
            forma.Show();
        }

        private void loyaltyKarticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzradaLoyaltyKarticeFrm forma = new IzradaLoyaltyKarticeFrm(prijavljen);
            forma.Show();
        }

        private void loyaltyKarticaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            AzuriranjeBrisanjeLoyaltyKarticeFrm forma = new AzuriranjeBrisanjeLoyaltyKarticeFrm(prijavljen);
            forma.Show();
        }

        private void loyaltyKarticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AzuriranjeBrisanjeLoyaltyKarticeFrm forma = new AzuriranjeBrisanjeLoyaltyKarticeFrm(prijavljen);
            forma.Show();
        }

        public Korisnik DohvatiPrijavljenog()
        {
            return prijavljen;
        }

        public Entity_Framework.Apoteka PronadiApoteku()
        {
            using (var context = new PI20_014_DBEntities())
            {
                return context.Apoteka.First(a => a.ID == prijavljen.Apoteka);
            }
        }

        public List<string> DohvatiLijekoveKojiNestaju()
        {
            List<string> nestaju = new List<string>();
            List<int> idLijekova = new List<int>();

            using (var context = new PI20_014_DBEntities())
            {
                var query = from z in context.Zalihe.Include("Lijek")
                    where z.ID_apoteke == prijavljen.Apoteka
                    select z;

                foreach (var zaliha in query)
                {
                    if (Prodano(zaliha.ID_lijeka)>zaliha.Kolicina)
                    {
                        idLijekova.Add(zaliha.ID_lijeka);
                    }
                }

                foreach (var lijek in idLijekova)
                {
                    nestaju.Add(context.Lijek.FirstOrDefault(l => l.ID == lijek).Naziv + "\n");
                }
            }
            
            return nestaju;
        }

        private int Prodano(int zalihaIdLijeka)
        {
            int prodano=0;

            DateTime daniAnalize = DateTime.Now.AddDays(-setting.BrojDanaAnalize);

            using (var contex = new PI20_014_DBEntities())
            {
                prodano = (from s in contex.StavkeRacuna
                    join r in contex.Racun on s.ID_racuna equals r.ID
                    where s.ID_lijeka == zalihaIdLijeka && r.Datum <= daniAnalize
                         select s).Count();
            }

            double ocekivanaProdaja = (prodano / setting.BrojDanaAnalize) * setting.BrojDanaNestanka;

            return Convert.ToInt32(Math.Ceiling(ocekivanaProdaja));
        }

        private void narudžbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NarucivanjeLijekovaFrm forma = new NarucivanjeLijekovaFrm(prijavljen);
            forma.ShowDialog();
        }

        private void AnalizaLijekova()
        {
            TimeSpan start = new TimeSpan(8, 0, 0);
            TimeSpan end = new TimeSpan(9, 0, 0);
            var now = DateTime.Now.TimeOfDay;

            if (TimeBetween(now, start, end))
            {
                if (poslano==false)
                {
                    var user = DohvatiPrijavljenog();
                    var lijekovi = DohvatiLijekoveKojiNestaju();
                    var dani = setting.BrojDanaNestanka;

                    mailKlijent.AutomatskiMail("System", user.KorisnickoIme, user.Email, lijekovi, dani);
                    poslano = true;
                }
            }
            else
            {
                poslano = false;
            }
            
        }

        private bool TimeBetween(TimeSpan now, TimeSpan start, TimeSpan end)
        {
            if (start < end)
                return start <= now && now <= end;
            return !(end < now && now < start);
        }

        private void korisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledKorisnikaFrm forma = new PregledKorisnikaFrm(prijavljen);
            forma.Show();
        }

        private void loyaltyKarticaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PregledLoyaltyKarticaFrm forma = new PregledLoyaltyKarticaFrm(prijavljen);
            forma.Show();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
