using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Košarica_za_kupovinu
{
    public class Stavka_kosarice
    {
        private string opis;
        private int kolicina;
        private double cijena;

        public Stavka_kosarice(string opis,int kolicina,double cijena)
        {
            this.opis = opis;
            this.kolicina = kolicina;
            this.cijena = cijena;
        }
        public Stavka_kosarice(string opis,double cijena)
        {
            this.opis = opis;
            this.cijena = cijena;
            kolicina = 1;
        }

        public string Vrati_Opis()
        {
            return opis;
        }

        public int Vrati_Kolicinu()
        {
            return kolicina;
        }

        public double Vrati_Cijenu()
        {
            return cijena;
        }

        public double Vrati_Vrijednost()
        {
            return cijena * kolicina;
        }

        public override string ToString()
        {
            return opis + "\t\t" + kolicina.ToString() + "\t" + Vrati_Cijenu().ToString() + "\t" + Vrati_Vrijednost().ToString();
        }



    }
}
