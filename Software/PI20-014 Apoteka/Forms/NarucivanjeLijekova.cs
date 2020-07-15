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
    public partial class NarucivanjeLijekovaFrm : Form
    {
        private Korisnik prijavljen;
        private Dobavljac dobavljac;
        private StavkeNarudzbenice odabranaRezervacija;

        BindingList<StavkeNarudzbenice> rezervacije = new BindingList<StavkeNarudzbenice>();


        public NarucivanjeLijekovaFrm()
        {
            InitializeComponent();
        }

        public NarucivanjeLijekovaFrm(Korisnik proslijeden)
        {
            InitializeComponent();
            this.prijavljen = proslijeden;
        }

        private void NarucivanjeLijekova_Load(object sender, EventArgs e)
        {
            Tvrtka tvrtka;
            PI20_014_Apoteka.Entity_Framework.Apoteka apoteka;

            using (var context = new PI20_014_DBEntities())
            {
                dobavljacCmb.DataSource = context.Dobavljac.ToList(); 
                apoteka = context.Apoteka.FirstOrDefault(a => a.ID == prijavljen.Apoteka);

                tvrtka = context.Tvrtka.FirstOrDefault(t => apoteka.Tvrtka==t.OIB);
            }

            brojNarudzbeniceLbl.Text = (DohvatiNarudzbenicu() + 1).ToString();
            adresaLbl.Text = apoteka.Adresa;
            tvrtkaLbl.Text = tvrtka.Naziv;
            dateLbl.Text = DateTime.Now.Date.ToString();
            zaposlenikLbl.Text = prijavljen.KorisnickoIme;
        }

        private void naruciBtn_Click(object sender, EventArgs e)
        {
            IzradiNarudzbenicu();

            rezervacije.Clear();
            stavkeNarudzbeniceDgv.DataSource = null;
            lijekoviDgv.DataSource = null;
        }

        private void IzradiNarudzbenicu()
        {
            using (var context = new PI20_014_DBEntities())
            {
                var apoteka = context.Apoteka.FirstOrDefault(a => a.ID == prijavljen.Apoteka);

                context.Narudzbenica.Add(new Narudzbenica
                {
                    ID_apoteke = apoteka.ID,
                    ID_zaposlenika = prijavljen.ID,
                    Datum = DateTime.Now.Date
                });

                foreach (var rzrv in rezervacije.ToList())
                {

                    var zalihaDobavljaca = context.Dostupno.FirstOrDefault(z =>
                        z.ID_lijeka == rzrv.ID_lijeka && z.ID_dobavljaca == rzrv.ID_dobavljaca);

                    context.StavkeNarudzbenice.Add(new StavkeNarudzbenice
                    {
                        ID_dobavljaca = rzrv.ID_dobavljaca,
                        ID_lijeka = rzrv.ID_lijeka,
                        Kolicina = rzrv.Kolicina,
                        ID_narudzbenice = rzrv.ID_narudzbenice
                    });

                    zalihaDobavljaca.Kolicina = zalihaDobavljaca.Kolicina - rzrv.Kolicina;
                }

                context.SaveChanges();
            }
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var odabranLijek = lijekoviDgv.CurrentRow.DataBoundItem as Lijek;
            var narudzbenica = DohvatiNarudzbenicu() + 1;

            int kolicina = 0;

            if (int.TryParse(kolicinaTxt.Text, out kolicina))
            {
                var postojeci = rezervacije.FirstOrDefault(r => r.ID_lijeka == odabranLijek.ID);

                if (postojeci == null)
                {
                    rezervacije.Add(new StavkeNarudzbenice()
                    {
                        ID_dobavljaca = dobavljac.OIB,
                        ID_lijeka = odabranLijek.ID,
                        ID_narudzbenice = narudzbenica,
                        Kolicina = kolicina
                    });
                }
                else
                {
                    postojeci.Kolicina += kolicina;
                }

                OsvjeziNarudzbeGrid();
            }
            else
                MessageBox.Show("Kolicina ne smije biti prazna");
        }

        private int DohvatiNarudzbenicu()
        {
            using (var context = new PI20_014_DBEntities())
            {
                var query = context.Narudzbenica.OrderByDescending(n => n.ID).FirstOrDefault();
                if (query!=null)
                {
                    return query.ID;
                }
                else
                {
                    return 0;
                }
            }
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

                    OsvjeziNarudzbeGrid();
                }

            }
            else
                MessageBox.Show("Kolicina ne smije biti prazna");
        }

        private void odaberiBtn_Click(object sender, EventArgs e)
        {
            dobavljac = dobavljacCmb.SelectedItem as Dobavljac;
            dobavljacCmb.Enabled = false;

            GUI();
            OsvjeziNarudzbeGrid();
        }

        private void OsvjeziNarudzbeGrid()
        {
            foreach (var r in rezervacije)
            {
                using (var context = new PI20_014_DBEntities())
                {
                    r.Lijek = context.Lijek.First(l => l.ID == r.ID_lijeka);
                }
            }

            stavkeNarudzbeniceDgv.DataSource = null;
            stavkeNarudzbeniceDgv.DataSource = rezervacije;
            stavkeNarudzbeniceDgv.Columns["Lijek"].DisplayIndex = 0;
            stavkeNarudzbeniceDgv.Columns["Kolicina"].DisplayIndex = 1;

            stavkeNarudzbeniceDgv.Columns["ID_dobavljaca"].Visible = false;
            stavkeNarudzbeniceDgv.Columns["ID_narudzbenice"].Visible = false;
            stavkeNarudzbeniceDgv.Columns["ID_lijeka"].Visible = false;
        }

        private void GUI()
        {
            using (var context = new PI20_014_DBEntities())
            {
                IQueryable<Lijek> query = from l in context.Lijek
                    join d in context.Dostupno on l.ID equals d.ID_lijeka
                    where d.ID_dobavljaca == dobavljac.OIB
                    select l;

                lijekoviDgv.DataSource = query.ToList();
                lijekoviDgv.Columns["ID"].Visible = false;
                lijekoviDgv.Columns["Dostupno"].Visible = false;
                lijekoviDgv.Columns["Rezervirao"].Visible = false;
                lijekoviDgv.Columns["StavkeNarudzbenice"].Visible = false;
                lijekoviDgv.Columns["StavkeRacuna"].Visible = false;
                lijekoviDgv.Columns["Zalihe"].Visible = false;
                lijekoviDgv.Columns["StavkePrimke"].Visible = false;


            }
        }

      
    }
}
