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
    public partial class IzradaLoyaltyOpcijeFrm : Form
    {

        private Korisnik prijavljen;

        public IzradaLoyaltyOpcijeFrm()
        {
            InitializeComponent();
        }

        private void IzradaLoyaltyOpcijeFrm_Load(object sender, EventArgs e)
        {
            TvrtkaComboBox.DataSource = DohvatiTvrtku();
        }

        private object DohvatiTvrtku()
        {
            using (var context = new PI20_014_DBEntities())
            {
                var query = (from t in context.Tvrtka
                             where t.Admin==prijavljen.ID
                             select t.Naziv).ToList();
                return query;
            }
        }

        public IzradaLoyaltyOpcijeFrm(Korisnik prijavljen)
        {
            InitializeComponent();
            this.prijavljen = prijavljen;
        }


        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonIzradi_Click(object sender, EventArgs e)
        {
            string naziv = textBoxOpcija.Text;
            int popust = int.Parse(textBoxPopust.Text);
            string tvrtka = TvrtkaComboBox.Text;
            using (var context = new PI20_014_DBEntities())
            {
                var query = (from t in context.Tvrtka
                             join k in context.Korisnik on t.Admin equals k.ID
                             where t.Naziv==tvrtka
                             select t).First();

                UnesiOpciju(naziv, popust, query);
                MessageBox.Show("Uspješno uneseno!");
                PregledLoyaltyOpcijeFrm forma = new PregledLoyaltyOpcijeFrm(prijavljen);
                forma.ShowDialog();
            }

        }

        private void UnesiOpciju(string naziv, int popust, Tvrtka tvrtka)
        {
            using (var context = new PI20_014_DBEntities())
            {
                LoyaltyOpcije novi = new LoyaltyOpcije
                {
                    Naziv = naziv,
                    Popust = popust,
                    Tvrtka = tvrtka.OIB,
                };

                context.LoyaltyOpcije.Add(novi);
                context.SaveChanges();
            }
        }

        private bool OpcijaPostoji(string naziv)
        {
            using (var context = new PI20_014_DBEntities())
            {
                var query = (from o in context.LoyaltyOpcije
                             where o.Naziv == naziv
                             select o).Count();

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
    }
}

