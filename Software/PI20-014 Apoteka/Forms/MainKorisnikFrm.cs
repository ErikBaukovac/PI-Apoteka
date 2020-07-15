using PI20_014_Apoteka.Entity_Framework;
using Prijava;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI20_014_Apoteka.Forms
{
    public partial class MainKorisnikFrm : Form
    {
        Thread dretva;
        private Rezervirao odabranaRezervacija;

        BindingList<Rezervirao> rezervacije = new BindingList<Rezervirao>();
        List<Rezervirao> zaZalihe = new List<Rezervirao>();


        private Korisnik prijavljen;

        public MainKorisnikFrm()
        {
            InitializeComponent();
        }

        public MainKorisnikFrm(Korisnik proslijeden)
        {
            InitializeComponent();
            prijavljen = proslijeden;
        }

        private void MainKorisnikFrm_Load(object sender, EventArgs e)
        {
            userNameLbl.Text = prijavljen.KorisnickoIme;

            using (var context = new PI20_014_DBEntities())
            {
                var query = from a in context.Apoteka
                    join t in context.Tvrtka on a.Tvrtka equals t.OIB
                    join l in context.LoyaltyOpcije on t.OIB equals l.Tvrtka
                    join k in context.Korisnik on l.ID equals k.LoyaltyOpcije
                    select a;

                apotekaCmb.DataSource = query.Distinct().ToList();

                GUI();
                OsvjeziRezervacijeGrid();
            }
        }

        private void GUI()
        {
            using (var context = new PI20_014_DBEntities())
            {
                var apoteka = DohvatiApoteku();

                if (apoteka != null)
                {
                    IQueryable<Lijek> query = from l in context.Lijek
                                                join z in context.Zalihe on l.ID equals z.ID_lijeka
                                                where z.ID_apoteke == apoteka.ID
                                                select l;

                    lijekoviDgv.DataSource = query.ToList();
                    lijekoviDgv.Columns["ID"].Visible = false;
                    lijekoviDgv.Columns["Dostupno"].Visible = false;
                    lijekoviDgv.Columns["Rezervirao"].Visible = false;
                    lijekoviDgv.Columns["StavkeNarudzbenice"].Visible = false;
                    lijekoviDgv.Columns["StavkeRacuna"].Visible = false;
                    lijekoviDgv.Columns["Zalihe"].Visible = false;
                    lijekoviDgv.Columns["StavkePrimke"].Visible = false;


                    OsvjeziRezervaciju();
                }
                else
                {
                    MessageBox.Show("Nema podataka");
                }
            }
        }

        private void OsvjeziRezervacijeGrid()
        {
            foreach (var r in rezervacije)
            {
                using (var context = new PI20_014_DBEntities())
                {
                    r.Apoteka = context.Apoteka.First(a => a.ID == r.ID_apoteke);
                    r.Lijek = context.Lijek.First(l => l.ID == r.ID_lijeka);
                    r.Korisnik = context.Korisnik.First(k => k.ID == r.ID_korisnika);
                }
            }

            rezervacijaDgv.DataSource = null;
            rezervacijaDgv.DataSource = rezervacije;
            rezervacijaDgv.Columns["Lijek"].DisplayIndex = 0;
            rezervacijaDgv.Columns["Apoteka"].DisplayIndex = 1;
            rezervacijaDgv.Columns["Kolicina"].DisplayIndex = 2;

            rezervacijaDgv.Columns["ID_apoteke"].Visible = false;
            rezervacijaDgv.Columns["ID_korisnika"].Visible = false;
            rezervacijaDgv.Columns["Korisnik"].Visible = false;
            rezervacijaDgv.Columns["ID_lijeka"].Visible = false;
        }

        private void OsvjeziRezervaciju()
        {
            rezervacije.Clear();

            using (var entities = new PI20_014_DBEntities())
            {
                foreach (var r in entities.Rezervirao.Where(r => r.ID_korisnika == prijavljen.ID).Include("Lijek").Include("Apoteka"))
                {
                    rezervacije.Add(r);
                }
            }

            OsvjeziRezervacijeGrid();
        }
        private PI20_014_Apoteka.Entity_Framework.Apoteka DohvatiApoteku()
        {
            return apotekaCmb.SelectedItem as PI20_014_Apoteka.Entity_Framework.Apoteka;
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            OsvjeziRezervaciju();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var odabranLijek = lijekoviDgv.CurrentRow.DataBoundItem as Lijek;
            var odabranaApoteka = DohvatiApoteku();
            int kolicina = 0;

            if (int.TryParse(kolicinaTxt.Text, out kolicina))
            {
                var postojeci = rezervacije.FirstOrDefault(r => r.ID_lijeka == odabranLijek.ID);

                if (postojeci == null)
                {
                    rezervacije.Add(new Rezervirao
                    {
                        ID_korisnika = prijavljen.ID,
                        ID_apoteke = odabranaApoteka.ID,
                        ID_lijeka = odabranLijek.ID,
                        Kolicina = kolicina
                    });
                }
                else
                {
                    postojeci.Kolicina += kolicina;
                }

                OsvjeziRezervacijeGrid();
            }
            else
                MessageBox.Show("Kolicina ne smije biti prazna");
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            int kolicina = 0;

            if (odabranaRezervacija == null) return;

            if (int.TryParse(kolicinaTxt.Text, out kolicina))
            {

                var rezervacija = rezervacije.FirstOrDefault(r => r == odabranaRezervacija);

                if (rezervacija != null)
                {
                    if (kolicina < rezervacija.Kolicina)
                    {
                        rezervacija.Kolicina -= kolicina;
                    }
                    else
                    {
                        rezervacije.Remove(rezervacija);
                    }

                    OsvjeziRezervacijeGrid();
                }

            }
            else
                MessageBox.Show("Kolicina ne smije biti prazna");
        }

        private void apotekaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GUI();
        }

        private void odjavaLbl_Click(object sender, EventArgs e)
        {
            this.Close();
            dretva = new Thread(PokreniNovuFormu);
            dretva.SetApartmentState(ApartmentState.STA);
            dretva.Start();
        }
        private void PokreniNovuFormu()
        {
            Application.Run(new PrijavaFrm());
        }
        private void rezervirajBtn_Click(object sender, EventArgs e)
        {
            DodajRezervacije();

            OsvjeziRezervaciju();
            OsvjeziRezervacijeGrid();
        }

        private void DodajRezervacije()
        {
            using (var context = new PI20_014_DBEntities())
            {
                string naruceni = "Naruceni lijekovi: ";
                string naCekanju = "Lijekovi koji se čekaju: ";


                using (DbContextTransaction scope = context.Database.BeginTransaction())
                {
                    context.Database.ExecuteSqlCommand("SELECT TOP 0 NULL FROM Rezervirao WITH (TABLOCKX)");
                    context.Database.ExecuteSqlCommand("SELECT TOP 0 NULL FROM Zalihe WITH (TABLOCKX)");


                    foreach (var rzrv in rezervacije.ToList())
                    {
                        var zalihaLijeka = context.Zalihe.FirstOrDefault(l => l.ID_lijeka == rzrv.ID_lijeka);
                                    
                        if (zalihaLijeka.Kolicina>=rzrv.Kolicina)
                        {
                            naruceni += "{rzrv.Lijek.ToString()} + \n";
                        }
                        else
                        {
                            naCekanju+= "{rzrv.Lijek.ToString()} + \n";
                        }

                        var brojPostojecihUBazi = context.Rezervirao.Count(r =>
                            r.ID_lijeka == rzrv.ID_lijeka &&
                            r.ID_apoteke == rzrv.ID_apoteke &&
                            r.ID_korisnika == rzrv.ID_korisnika && r.Kolicina == rzrv.Kolicina);

                        var zaliha = context.Zalihe.FirstOrDefault(z =>
                            z.ID_lijeka == rzrv.ID_lijeka && z.ID_apoteke == rzrv.ID_apoteke);


                        if (brojPostojecihUBazi > 0)
                        {
                            var rez = context.Rezervirao.First(r =>
                                r.ID_lijeka == rzrv.ID_lijeka &&
                                r.ID_apoteke == rzrv.ID_apoteke &&
                                r.ID_korisnika == rzrv.ID_korisnika &&
                                r.Kolicina == rzrv.Kolicina);

                            zaliha.Kolicina = zaliha.Kolicina - (rez.Kolicina - rzrv.Kolicina);
                            rez.Kolicina = rzrv.Kolicina;

                        }
                        else
                        {
                            context.Rezervirao.Add(new Rezervirao
                            {
                                ID_apoteke = rzrv.ID_apoteke,
                                ID_lijeka = rzrv.ID_lijeka,
                                ID_korisnika = rzrv.ID_korisnika,
                                Kolicina = rzrv.Kolicina
                            });

                            zaliha.Kolicina = zaliha.Kolicina - rzrv.Kolicina;

                        }
                    }

                    foreach (var rzrv in context.Rezervirao.ToList())
                    {
                        var zaliha = context.Zalihe.FirstOrDefault(z =>
                            z.ID_lijeka == rzrv.ID_lijeka && z.ID_apoteke == rzrv.ID_apoteke);

                        var brojPostojecihUBazi = rezervacije.Count(r =>
                            r.ID_lijeka == rzrv.ID_lijeka &&
                            r.ID_apoteke == rzrv.ID_apoteke &&
                            r.ID_korisnika == rzrv.ID_korisnika &&
                            r.Kolicina == rzrv.Kolicina);

                        if (brojPostojecihUBazi == 0)
                        {
                            zaliha.Kolicina = zaliha.Kolicina + rzrv.Kolicina;
                            context.Rezervirao.Remove(rzrv);
                        }
                    }

                    scope.Commit();
                }

                MessageBox.Show(naruceni + naCekanju);
                context.SaveChanges();
        }
    }

        private void rezervacijaDgv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                odabranaRezervacija = (sender as DataGridView).SelectedRows[0].DataBoundItem as Rezervirao;
            }
            catch (Exception exception)
            {

            }
        }
    }
}
