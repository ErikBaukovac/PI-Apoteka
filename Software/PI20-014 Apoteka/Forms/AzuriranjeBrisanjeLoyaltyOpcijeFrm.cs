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
    public partial class AzuriranjeBrisanjeLoyaltyOpcijeFrm : Form
    {
        private Korisnik prijavljen;

        public AzuriranjeBrisanjeLoyaltyOpcijeFrm()
        {
            InitializeComponent();
        }

        public AzuriranjeBrisanjeLoyaltyOpcijeFrm(Korisnik prijavljen)
        {
            InitializeComponent();
            this.prijavljen = prijavljen;
        }

        private void AzuriranjeBrisanjeLoyaltyOpcijeFrm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private string DohvatiPopust()
        {

            using (var context = new PI20_014_DBEntities())
            {
                var dohvacena = DohvatiTvrtku();

                var query = (from l in context.LoyaltyOpcije
                             where dohvacena.OIB == l.Tvrtka && l.Naziv == NazivComboBox.Text
                             select l).FirstOrDefault();

                return query.Popust.ToString();
            }
        }

        private void Osvjezi()
        {
            NazivComboBox.DataSource = DohvatiNaziv();
            PopustTextBox.Text = DohvatiPopust();
        }

        private Tvrtka DohvatiTvrtku()
        {
            using (var context = new PI20_014_DBEntities())
            {
                return (from t in context.Tvrtka
                             where t.Admin == prijavljen.ID
                             select t).First();
            }
        }

        private object DohvatiNaziv()
        {
            using (var context = new PI20_014_DBEntities())
            {
                var dohvacena = DohvatiTvrtku();

                var query = (from l in context.LoyaltyOpcije
                             where dohvacena.OIB == l.Tvrtka
                             select l.Naziv).ToList();
                return query;
            }
        }

        private void OdustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            string naziv = NazivComboBox.Text;
            int popust = int.Parse(PopustTextBox.Text);

            using (var context = new PI20_014_DBEntities())
            {
                var query = (from l in context.LoyaltyOpcije where l.Naziv == naziv select l).First();
                context.LoyaltyOpcije.Attach(query);
                context.LoyaltyOpcije.Remove(query);
                context.SaveChanges();
                Osvjezi();
                MessageBox.Show("Uspješno obrisano!");
                PregledLoyaltyOpcijeFrm forma = new PregledLoyaltyOpcijeFrm(prijavljen);
                forma.ShowDialog();
            }
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            string naziv = NazivComboBox.Text;
            int popust = int.Parse(PopustTextBox.Text);
            Tvrtka tvrtka = DohvatiTvrtku();

            using (var context = new PI20_014_DBEntities())
            {
                var q = (from o in context.LoyaltyOpcije
                         where o.Naziv == naziv && o.Tvrtka == tvrtka.OIB
                         select o).First();

                q.Popust = popust;
                context.SaveChanges();
                MessageBox.Show("Uspješno ažurirano!");
                PregledLoyaltyOpcijeFrm forma = new PregledLoyaltyOpcijeFrm(prijavljen);
                forma.ShowDialog();
            }

            Osvjezi();
        }

        private void NazivComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            PopustTextBox.Text = DohvatiPopust();
            
        }
    }
}
