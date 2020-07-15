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
    public partial class PregledKorisnikaFrm : Form
    {
        private Korisnik prijavljen;
        public PregledKorisnikaFrm()
        {
            InitializeComponent();
        }
        public PregledKorisnikaFrm(Korisnik prijavljen)
        {
            InitializeComponent();
            this.prijavljen = prijavljen;
        }

        private void PregledKorisnikaFrm_Load(object sender, EventArgs e)
        {
            GUI();
        }

        private void GUI()
        {
            using (var context = new PI20_014_DBEntities())
            {
                var odabranaApoteka = context.Apoteka.FirstOrDefault(a => a.ID == prijavljen.Apoteka);
                Tvrtka odabrana = context.Tvrtka.FirstOrDefault(t => t.OIB == odabranaApoteka.Tvrtka);

                var query = (from k in context.Korisnik
                             join l in context.LoyaltyOpcije on k.LoyaltyOpcije equals l.ID
                             join t in context.Tvrtka on l.Tvrtka equals t.OIB 
                             where l.Tvrtka == odabrana.OIB 
                             select k).ToList();

                KorisniciDataGridView.DataSource = query;
                KorisniciDataGridView.Columns["Lozinka"].Visible = false;
                KorisniciDataGridView.Columns["ID"].Visible = false;
                KorisniciDataGridView.Columns["Apoteka"].Visible = false;
                KorisniciDataGridView.Columns["Apoteka1"].Visible = false;
                KorisniciDataGridView.Columns["LoyaltyOpcije"].Visible = false;
                KorisniciDataGridView.Columns["LoyaltyOpcije1"].Visible = false;
                KorisniciDataGridView.Columns["Uloga1"].Visible = false;
                KorisniciDataGridView.Columns["Narudzbenica"].Visible = false;
                KorisniciDataGridView.Columns["Racun"].Visible = false;
                KorisniciDataGridView.Columns["Rezervirao"].Visible = false;
                KorisniciDataGridView.Columns["Tvrtka"].Visible = false;
            }
        }

        private void KorisniciDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
