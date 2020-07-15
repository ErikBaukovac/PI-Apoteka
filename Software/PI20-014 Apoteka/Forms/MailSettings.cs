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
    public partial class MailSettings : Form
    {
        public int BrojDanaNestanka { get; set; }
        public int BrojDanaAnalize { get; set; } 
        public MailSettings()
        {
            InitializeComponent();
            BrojDanaAnalize= int.Parse(nestajeLbl.Text);
            BrojDanaNestanka = int.Parse(statistikaLbl.Text);
            
        }

        private void MailSettings_Load(object sender, EventArgs e)
        {
            predvidanjeTrc.Value = int.Parse(nestajeLbl.Text);
            statistikaTrc.Value = int.Parse(statistikaLbl.Text);
        }

        private void predvidanjeTrc_Scroll(object sender, EventArgs e)
        {
            nestajeLbl.Text = predvidanjeTrc.Value.ToString();
            BrojDanaNestanka= predvidanjeTrc.Value;
        }

        private void statistikaTrc_Scroll(object sender, EventArgs e)
        {
            statistikaLbl.Text = statistikaTrc.Value.ToString();
            BrojDanaAnalize = statistikaTrc.Value;
        }

    }
}
