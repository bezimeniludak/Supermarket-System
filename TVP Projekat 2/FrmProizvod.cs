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
    public partial class FrmProizvod : Form
    {
        List<Proizvod> korpa;
        string naziv;
        double racun;
        public Button poslatodugme;
        System.Data.EnumerableRowCollection<Projekat_II.ProdavnicaDataSet.ProizvodiRow> filtriraniproizvodi;
        ProdavnicaDataSet ds;
        ProdavnicaDataSetTableAdapters.ProizvodiTableAdapter daProizvod;
        ProdavnicaDataSetTableAdapters.RacuniTableAdapter daRacun;
        public FrmProizvod(ProdavnicaDataSet ds, ProdavnicaDataSetTableAdapters.ProizvodiTableAdapter daProizvod, ProdavnicaDataSetTableAdapters.RacuniTableAdapter daRacun)
        {
            InitializeComponent();
            this.ds = ds;
            this.daProizvod = daProizvod;
            this.daRacun = daRacun;
            korpa = new List<Proizvod>();
        }

        private void Proizvod_Load(object sender, EventArgs e)
        {
            lblRacun.Text = racun + " RSD";
            Button dugme = poslatodugme;
            var linq = from x in ds.Proizvodi
                       select x;
            switch (dugme.Name)
            {
                case "btnPice":
                    linq = from x in ds.Proizvodi
                           where x.Kategorija.Equals("Pice,kafa i caj")
                           select x;
                    break;
                case "btnMleko":
                    linq = from x in ds.Proizvodi
                           where x.Kategorija.Equals("Mlecni proizvodi")
                           select x;
                    break;
                case "btnHigijena":
                    linq = from x in ds.Proizvodi
                           where x.Kategorija.Equals("Licna higijena")
                           select x;
                    break;
                case "btnVoce":
                    linq = from x in ds.Proizvodi
                           where x.Kategorija.Equals("Voce i povrce")
                           select x;
                    break;
                case "btnOsnovno":
                    linq = from x in ds.Proizvodi
                           where x.Kategorija.Equals("Osnovne namirnice")
                           select x;
                    break;
                case "btnSlatko":
                    linq = from x in ds.Proizvodi
                           where x.Kategorija.Equals("Slatko i slano")
                           select x;
                    break;
                case "btnPribor":
                    linq = from x in ds.Proizvodi
                           where x.Kategorija.Equals("Kancelarijski pribor")
                           select x;
                    break;
                default:
                    MessageBox.Show("Nista");
                    break;
            }
            dataGridView1.DataSource = linq.CopyToDataTable();
            dataGridView1.Sort(dataGridView1.Columns["Naziv"], ListSortDirection.Ascending);
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            filtriraniproizvodi = linq;

        }
        public void PrimiDugme(Button dugme)
        {
            poslatodugme = dugme;
        }

        private void btnDodajUKorpu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count < 1)
            {
                MessageBox.Show("Niste izabrali nijedan proizvod.");
                return;
            }
            else if (dataGridView1.AreAllCellsSelected(true))
            {
                MessageBox.Show("Izabrali ste sve proizvode.");
                return;
            }
            else if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Izaberite kolicinu proizvoda.");
            }
            else
            {
                int redindex = dataGridView1.CurrentCell.RowIndex;
                naziv = dataGridView1.Rows[redindex].Cells[1].Value.ToString();
                racun += (double)dataGridView1.Rows[redindex].Cells[3].Value * (double)numericUpDown1.Value;
                Proizvod p = new Proizvod(naziv, (int)numericUpDown1.Value, (double)dataGridView1.Rows[redindex].Cells[3].Value);
                korpa.Add(p);
                MessageBox.Show("Proizvod: "+naziv+" dodat u korpu.");
            }

        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            FrmGlavniMeni f = new FrmGlavniMeni(ds, daProizvod, daRacun);
            f.Primiinfo(korpa,racun);
            f.MdiParent = FrmMain.ActiveForm;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var linq = from x in filtriraniproizvodi
                       where x.Naziv.ToLower().Contains(textBox1.Text.ToLower())
                       select x;
            dataGridView1.DataSource = linq.CopyToDataTable();
            dataGridView1.Sort(dataGridView1.Columns["Naziv"], ListSortDirection.Ascending);
        }
        public void Primiinfo(List<Proizvod> k, double r)
        {
            korpa = k;
            racun = r;
        }
    }
}
