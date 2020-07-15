using PI20_014_Apoteka.Dodatne_klase;
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
    public partial class unosLijekaFrm : Form
    {

        public unosLijekaFrm()
        {
            InitializeComponent();
        }

        private void unosLijekaFrm_Load(object sender, EventArgs e)
        {
           
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            double cijena; 
            bool valjanaCijena = double.TryParse(cijenaTxt.Text,out cijena);
            string naziv = nazivTxt.Text;

            if (ProvjeraUnosa.ValidacijaLijeka(naziv) && valjanaCijena)
            {
                UnesiLijek(naziv, cijena);
                IsprazniPolja();
                MessageBox.Show("Uspjesno uneseno");
            }
            else
            {
                MessageBox.Show("Cijena mora biti brojčana vrijednost");
                IsprazniPolja();
            }
        }
        private void IsprazniPolja()
        {
            nazivTxt.Clear();
            cijenaTxt.Clear();
        }
        private void UnesiLijek(string naziv, double cijena)
        {
            using (var context = new PI20_014_DBEntities())
            {
                Lijek noviLijek = new Lijek
                {
                    Naziv = naziv,
                    Cijena = cijena
                };

                context.Lijek.Add(noviLijek);
                context.SaveChanges();
            }
        }

    }
}
