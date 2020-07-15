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
    public partial class PregledDobavljacaFrm : Form
    {
        public PregledDobavljacaFrm()
        {
            InitializeComponent();
        }

        private void DostupniDobavljaciFrm_Load(object sender, EventArgs e)
        {
            GUI();
        }

        private void GUI()
        {
            using (var contex = new PI20_014_DBEntities())
            {
                dobavljaciDgv.DataSource = contex.Dobavljac.ToList();
                dobavljaciDgv.Columns["Dostupno"].Visible = false;
                dobavljaciDgv.Columns["StavkeNarudzbenice"].Visible = false;
                dobavljaciDgv.Columns["StavkePrimke"].Visible = false;

            }
        }

        private void dobavljaciDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
