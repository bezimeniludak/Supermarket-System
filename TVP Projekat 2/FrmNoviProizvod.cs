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
    public partial class FrmNoviProizvod : Form
    {
        ProdavnicaDataSet ds;
        ProdavnicaDataSetTableAdapters.ProizvodiTableAdapter daProizvod;
        public FrmNoviProizvod(ProdavnicaDataSet ds, ProdavnicaDataSetTableAdapters.ProizvodiTableAdapter daProizvod)
        {
            InitializeComponent();
            this.ds = ds;
            this.daProizvod = daProizvod;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProdavnicaDataSet.ProizvodiRow red = ds.Proizvodi.NewProizvodiRow();
            red.Naziv = txtNaziv.Text;
            red.Kategorija = cbKategorija.SelectedItem.ToString();
            red.Cena = Double.Parse(txtCena.Text);
            ds.Proizvodi.AddProizvodiRow(red);
            daProizvod.Update(ds);
            MessageBox.Show("Proizvod uspesno dodat.");
        }

        private void FrmNoviProizvod_Load(object sender, EventArgs e)
        {
            string[] kategorije =  { "Pice, kafa i caj", "Mlecni proizvodi", "Voce i povrce", "Slatko i slano", "Osnovne namirnice", "Licna higijena", "Kancelarijski pribor" };
            foreach (string s in kategorije)
            {
                cbKategorija.Items.Add(s);
            }
        }
    }
}
