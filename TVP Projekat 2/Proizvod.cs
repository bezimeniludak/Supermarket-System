using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_II
{
    public class Proizvod
    {
        int kolicina;
        string naziv;
        double cena;

        public int Kolicina { get => kolicina; set => kolicina = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public double Cena { get => cena; set => cena = value; }

        public Proizvod(string naziv, int kolicina,double cena)
        {
            this.Naziv = naziv;
            this.Kolicina = kolicina;
            this.Cena = cena;
        }
        public override string ToString()
        {
            return Naziv+", Kolicina: "+Kolicina+", Cena:"+Cena+" RSD";
        }

    }
}
