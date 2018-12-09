using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Košarica_za_kupovinu
{
    public class Vlasnik_kosarice
    {
        //privatne varijable
        private string id;
        private string naziv;
        private string adresa;

        public Vlasnik_kosarice(string id,string naziv,string adresa)
        {
            this.id = id;
            this.naziv = naziv;
            this.adresa = adresa;
        }

        public string Vrati_ID()
        {
            return id;
        }

        public string Vrati_Naziv()
        {
            return naziv;
        }

        public void Promijeni_Naziv(string naziv)
        {
            this.naziv = naziv;
        }

        public string Vrati_Adresu()
        {
            return adresa;
        }

        public void Promijeni_Adresu(string adresa)
        {
            this.adresa = adresa;
        }

        public override string ToString()
        {
            return id + "\t" + naziv + "\t" + adresa;
        }
    }
}
