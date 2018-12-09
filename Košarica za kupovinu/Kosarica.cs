using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Košarica_za_kupovinu
{
    class Kosarica
    {
        private Guid id;
        private Vlasnik_kosarice vlasnik;
        private List<Stavka_kosarice> stavke = new List<Stavka_kosarice>();
        private Status_kosarice status;

        public Kosarica(Vlasnik_kosarice vlasnik)
        {
            this.vlasnik = vlasnik;
        }

        private bool Zakljucana()
        {
            if (status == Status_kosarice.Placena || status == Status_kosarice.Stornirana)
            {
                return true;
            }
            else
                return false;
        }

        public Guid VratiID()
        {
            return id;
        }

        public Vlasnik_kosarice VratiVlasnika()
        {
            return vlasnik;
        }

        public Status_kosarice VratiStatus()
        {
            return status;
        }

        public List<Stavka_kosarice> VratiStavke()
        {
            return stavke;

        }

        public double VratiVrijednost()
        {
            double vrijednost = 0;
            for (int x=0;x<stavke.Count();x++)
            {
                vrijednost+=stavke.ElementAt(x).Vrati_Vrijednost();
            }

            return vrijednost;
        }

        public void DodajStavku(Stavka_kosarice stavka)
        {
            if (Zakljucana() == false)
            {
                stavke.Add(stavka);
                status = Status_kosarice.Aktivna;
            }
            else
                Console.WriteLine("Kosarica zakljucana!!");
            
        }

        public void DodajStavku(string _opis,int _kolicina,double _cijena)
        {
            if(Zakljucana()==false)
            {
                Stavka_kosarice stavka = new Stavka_kosarice(_opis,_kolicina,_cijena);
                stavke.Add(stavka);
            }
            else
                Console.WriteLine("Kosarica zakljucana!!");
        }

        public void ObrisiStavku(int index)
        {
            if(Zakljucana()==false)
            {
                stavke.RemoveAt(index);
            }
        }

        public void ObrisiStavku(Stavka_kosarice stavka)
        {
            if(Zakljucana()==false)
            {
                stavke.Remove(stavka);
            }
        }

        public void Isprazni()
        {
            foreach(Stavka_kosarice stavka in stavke)
            {
                stavke.Remove(stavka);
            }
        }

        public void Plati()
        {
            status = Status_kosarice.Placena;
        }

        public void Storniraj()
        {
            status = Status_kosarice.Stornirana;
        }

    }
}
