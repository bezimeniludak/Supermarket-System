using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_II
{
    public partial class FrmMain : Form
    {
        ProdavnicaDataSet ds;
        ProdavnicaDataSetTableAdapters.ProizvodiTableAdapter daProizvod;
        ProdavnicaDataSetTableAdapters.RacuniTableAdapter daRacun;
        public FrmMain()
        {
            InitializeComponent();
            ds = new ProdavnicaDataSet();
            daProizvod = new ProdavnicaDataSetTableAdapters.ProizvodiTableAdapter();
            daRacun = new ProdavnicaDataSetTableAdapters.RacuniTableAdapter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            daProizvod.Fill(ds.Proizvodi);
            FrmGlavniMeni f = new FrmGlavniMeni(ds,daProizvod,daRacun);
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();

        }
    }
}
