using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_II
{
    public partial class FrmGlavniMeni : Form
    {

        ProdavnicaDataSet ds;
        public List<Proizvod> korpa;
        double racun = 0;
        ProdavnicaDataSetTableAdapters.ProizvodiTableAdapter daProizvod;
        ProdavnicaDataSetTableAdapters.RacuniTableAdapter daRacun;
        public FrmGlavniMeni(ProdavnicaDataSet ds, ProdavnicaDataSetTableAdapters.ProizvodiTableAdapter daProizvod, ProdavnicaDataSetTableAdapters.RacuniTableAdapter daRacun)
        {
            InitializeComponent();
            this.ds = ds;
            this.daProizvod = daProizvod;
            this.daRacun = daRacun;
            korpa = new List<Proizvod>();
        }

        protected void DodajProizvod(object sender, EventArgs e)
        {
            Button kliknutoDugme = sender as Button;
            if (kliknutoDugme == null) // just to be on the safe side
                return;
            FrmProizvod f = new FrmProizvod(ds, daProizvod, daRacun);
            f.PrimiDugme(kliknutoDugme);
            f.Primiinfo(korpa, racun);
            f.MdiParent = FrmMain.ActiveForm;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void FrmGlavniMeni_Load(object sender, EventArgs e)
        {
            foreach (Proizvod p in korpa)
            {
                listBox1.Items.Add(p.ToString());
            }
            lblRacun.Text = racun + " RSD";

        }

        private void btnNoviProizvod_Click(object sender, EventArgs e)
        {
            FrmNoviProizvod f = new FrmNoviProizvod(ds, daProizvod);
            f.Show();
        }
        public void Primiinfo(List<Proizvod> k, double r)
        {
            korpa = k;
            racun = r;
        }

        private void btnIzbaci_Click(object sender, EventArgs e)
        {
            if (korpa.Count < 1)
                return;
            racun -= korpa[listBox1.SelectedIndex].Cena;
            korpa.RemoveAt(listBox1.SelectedIndex);
            lblRacun.Text = racun + " RSD";
            listBox1.Items.Clear();
            foreach (Proizvod p in korpa)
                listBox1.Items.Add(p.ToString());

            MessageBox.Show("Proizvod izbacen.");
        }

        private void btnIsprazni_Click(object sender, EventArgs e)
        {
            if (korpa.Count < 1)
                return;
            racun = 0;
            lblRacun.Text = racun + " RSD";
            korpa.Clear();
            listBox1.Items.Clear();
            MessageBox.Show("Korpa ispraznjena.");
        }

        private void btnRacuni_Click(object sender, EventArgs e)
        {
            FrmRacun f = new FrmRacun();
            f.Show();
        }

        private void btnPlati_Click(object sender, EventArgs e)
        {
            racun = Math.Round(racun, 2);
            if (racun == 0) {
                MessageBox.Show("Nemate nijedan proizvod u korpi.");
                return;
            }
            ProdavnicaDataSet.RacuniRow red = ds.Racuni.NewRacuniRow();
            red.Ukupna_cena = racun;
            red.Trenutno_vreme = DateTime.Now;
            red.Datum_izdavanja = DateTime.Now;
            ds.Racuni.AddRacuniRow(red);
            daRacun.Update(ds);
            MessageBox.Show("Racun uspesno placen");

        }
    }
}
