using PI20_014_Apoteka.Entity_Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI20_014_Apoteka.Forms
{
    public partial class PregledLoyaltyKarticaFrm : Form
    {
        private Korisnik prijavljen;
        public PregledLoyaltyKarticaFrm()
        {
            InitializeComponent();
        }
        public PregledLoyaltyKarticaFrm(Korisnik prijavljen)
        {
            InitializeComponent();
            this.prijavljen = prijavljen;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PregledLoyaltyKarticaFrm_Load(object sender, EventArgs e)
        {
            Gui();
        }
        
        private void Gui()
        {
            var context = new PI20_014_DBEntities();
           
            var odabranaApoteka = context.Apoteka.FirstOrDefault(a => a.ID == prijavljen.Apoteka);
            Tvrtka odabrana = context.Tvrtka.FirstOrDefault(t => t.OIB == odabranaApoteka.Tvrtka);

            var query = from k in context.Korisnik.Include("LoyaltyOpcije1")
                            join l in context.LoyaltyOpcije on k.LoyaltyOpcije equals l.ID
                            join t in context.Tvrtka on l.Tvrtka equals t.OIB
                            where l.Tvrtka == odabrana.OIB
                            select k;

            LoyaltyKarticeDataGridView.DataSource = query.ToList();
            LoyaltyKarticeDataGridView.Columns["ID"].Visible = false;
            LoyaltyKarticeDataGridView.Columns["Lozinka"].Visible = false;
            LoyaltyKarticeDataGridView.Columns["Email"].Visible = false;
            LoyaltyKarticeDataGridView.Columns["Uloga"].Visible = false;
            LoyaltyKarticeDataGridView.Columns["LoyaltyOpcije"].Visible = false;
            LoyaltyKarticeDataGridView.Columns["Apoteka"].Visible = false;
            LoyaltyKarticeDataGridView.Columns["Apoteka1"].Visible = false;
            LoyaltyKarticeDataGridView.Columns["Uloga1"].Visible = false;
            LoyaltyKarticeDataGridView.Columns["Narudzbenica"].Visible = false;
            LoyaltyKarticeDataGridView.Columns["Racun"].Visible = false;
            LoyaltyKarticeDataGridView.Columns["Rezervirao"].Visible = false;
            LoyaltyKarticeDataGridView.Columns["Tvrtka"].Visible = false;
           
        }
    }
}
