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
using System.Threading;
using Prijava;
using PI20_014;

namespace PI20_014_Apoteka.Forms
{
    public partial class MainAdministratorFrm : Form
    {
        Thread dretva;
        private Korisnik prijavljen;

        public MainAdministratorFrm()
        {
            InitializeComponent();
        }

        public MainAdministratorFrm(Korisnik proslijedenKorisnik)
        {
            InitializeComponent();
            prijavljen = proslijedenKorisnik;
            GUI();
        }

        private void MainAdministratorFrm_Load(object sender, EventArgs e)
        {
            GUI();
        }

        private void GUI()
        {
            using (var contex = new PI20_014_DBEntities())
            {
                var odabranaTvrtka = contex.Tvrtka.First(t => t.Admin == prijavljen.ID);

                if (odabranaTvrtka != null)
                {
                    apotekeDgv.DataSource = odabranaTvrtka.Apoteka.ToList();
                    apotekeDgv.Columns["ID"].Visible = false;
                    apotekeDgv.Columns["Tvrtka1"].Visible = false;
                    apotekeDgv.Columns["Korisnik"].Visible = false;
                    apotekeDgv.Columns["Narudzbenica"].Visible = false;
                    apotekeDgv.Columns["Rezervirao"].Visible = false;
                    apotekeDgv.Columns["Zalihe"].Visible = false;
                    apotekeDgv.Columns["Tvrtka"].Visible = false;
                    apotekeDgv.Columns["Primka"].Visible = false;

                    userNameLbl.Text = prijavljen.KorisnickoIme;
                    tvrtkaLbl.Text = odabranaTvrtka.Naziv;
                }
                else
                {
                    MessageBox.Show("Nema podataka");
                }
            
            }
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
        private void lijekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unosLijekaFrm forma = new unosLijekaFrm();
            forma.ShowDialog();
        }
        private void zaposlenikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosZaposlenikaFrm forma = new UnosZaposlenikaFrm(prijavljen);
            forma.ShowDialog();
        }
        private void dobavljacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosDobavljacaFrm forma = new UnosDobavljacaFrm();
            forma.ShowDialog();
        }

        private void lijekToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            azuriranjeLijekovaFrm forma = new azuriranjeLijekovaFrm();
            forma.ShowDialog();
        }
        private void zaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AzuriranjeZaposlenikaFrm forma = new AzuriranjeZaposlenikaFrm(prijavljen);
            forma.ShowDialog();
        }
        private void dobavljačToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AzuriranjeDobavljacaFrm forma = new AzuriranjeDobavljacaFrm();
            forma.ShowDialog();
        }

        private void lijekovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brisanjeLijekovaFrm forma = new brisanjeLijekovaFrm();
            forma.ShowDialog();
        }

        private void zaposlenikaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BrisanjeZaposlenikaFrm forma = new BrisanjeZaposlenikaFrm(prijavljen);
            forma.ShowDialog();
        }

        private void dobavljacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrisanjeDobavljacaFrm forma = new BrisanjeDobavljacaFrm();
            forma.ShowDialog();
        }

        private void loyaltyOpcijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzradaLoyaltyOpcijeFrm forma = new IzradaLoyaltyOpcijeFrm(prijavljen);
            forma.ShowDialog();
        }

        private void loyaltyOpcijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AzuriranjeBrisanjeLoyaltyOpcijeFrm forma = new AzuriranjeBrisanjeLoyaltyOpcijeFrm(prijavljen);
            forma.ShowDialog();
        }

        private void loyaltyOpcijaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AzuriranjeBrisanjeLoyaltyOpcijeFrm forma = new AzuriranjeBrisanjeLoyaltyOpcijeFrm(prijavljen);
            forma.ShowDialog();
        }

        private void loyaltyOpcijaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PregledLoyaltyOpcijeFrm forma = new PregledLoyaltyOpcijeFrm(prijavljen);
            forma.ShowDialog();
        }

        private void postavkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailSettings forma = new MailSettings();
            forma.ShowDialog();
        }
    }
}
