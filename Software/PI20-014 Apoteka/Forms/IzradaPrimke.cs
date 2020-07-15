using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI20_014_Apoteka.Entity_Framework;

namespace PI20_014_Apoteka.Forms
{
    public partial class IzradaPrimke : Form
    {
        private Korisnik prijavljen;
        private Dobavljac odabranDobavljac;

        BindingList<StavkePrimke> primke = new BindingList<StavkePrimke>();

        public IzradaPrimke()
        {
            InitializeComponent();
        }

        private void IzradaPrimke_Load(object sender, EventArgs e)
        {
            odaberiBtn.Enabled = true;
            lijekCmb.Enabled = false;
            dodajBtn.Enabled = false;
            izradiBtn.Enabled = false;

            GUI();
        }

        private void GUI()
        {
            using (var context = new PI20_014_DBEntities())
            {
                brojPrimkeLbl.Text = (context.Primka.LastOrDefault().ID + 1).ToString();
                apotekaLbl.Text = (context.Apoteka.FirstOrDefault(a => a.ID == prijavljen.Apoteka)).Naziv;

                dobavljacCmb.DataSource = context.Dobavljac.ToList();

                lijekCmb.DataSource = context.Lijek.ToList();
                lijekoviDgv.DataSource = primke;
            }
        }

        public IzradaPrimke(Korisnik proslijeden)
        {
            InitializeComponent();
            prijavljen = proslijeden;
        }

        private void odaberiBtn_Click(object sender, EventArgs e)
        {
            odabranDobavljac = dobavljacCmb.SelectedItem as Dobavljac;
            
            odaberiBtn.Enabled = false;
            lijekCmb.Enabled = true;
            izradiBtn.Enabled = true;
            dodajBtn.Enabled = true;
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            using (var context = new PI20_014_DBEntities())
            {
                Lijek odabran = lijekCmb.SelectedItem as Lijek;
                int kolicina = 0;

                if (int.TryParse(kolicinaTxt.Text,out kolicina) )
                {
                    primke.Add(new StavkePrimke
                    {
                        ID_dobavljaca = odabranDobavljac.OIB,
                        ID_lijek = odabran.ID,
                        ID_primke = context.Primka.LastOrDefault().ID + 1,
                        Kolicina = kolicina
                    });
                }
                else
                    MessageBox.Show("Kolicina ne smije biti prazna");
            }
            GUI();
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            primke.Clear();
        }

        private void izradiBtn_Click(object sender, EventArgs e)
        {
            using (var context = new PI20_014_DBEntities())
            {

                Entity_Framework.Apoteka odabranaApoteka =context.Apoteka.FirstOrDefault(a => a.ID == prijavljen.Apoteka);

                context.Primka.Add(new Primka
                {
                    ID_apoteke = odabranaApoteka.ID,
                    Datum = DateTime.Now.Date,
                    ID_otpremnice = int.Parse(brojOtpremniceTxt.Text)
                });
                foreach (var item in primke)
                {
                    context.StavkePrimke.Add(item);
                }

                context.SaveChanges();
            }
        }
    }
}
