using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Košarica_za_kupovinu
{
    class Program
    {
        static void Ispisi_Kosaricu(Kosarica k)
        {
            Console.WriteLine("Košarica ID: {0}", k.VratiID());
            Console.WriteLine("Kupac: {0}", k.VratiVlasnika());
            Console.WriteLine("*********************************************************************************");

            List<Stavka_kosarice> kosarica = k.VratiStavke();
            for (int x = 0; x < kosarica.Count; x++)
                Console.WriteLine("{0}.\t{1}", x + 1, kosarica[x]);

            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("Ukupno za platiti: {0}", k.VratiVrijednost());
            Console.WriteLine("Status: {0}\n\n", k.VratiStatus());
        }

        static void Main(string[] args)
        {
            Kosarica k=new Kosarica(new Vlasnik_kosarice("123456789","Robert Horvat","Cakovecka 3,Peklenica"));

            Stavka_kosarice s = new Stavka_kosarice("Olovka HB", 1, 3.99);
            k.DodajStavku(s);
            Stavka_kosarice f = new Stavka_kosarice("Penkala crna", 1, 5.99);
            


            k.DodajStavku("Napolitanke", 1, 25.99);
            k.DodajStavku("Luk rinfuza", 2, 5.99);
            k.DodajStavku("Pen korektor", 2,13.99);
            k.DodajStavku(f);
            k.DodajStavku(s);

            Ispisi_Kosaricu(k);

            k.VratiVlasnika().Promijeni_Adresu("Kralja Tomislava 5,Čakovec");
            k.ObrisiStavku(2);

            k.Storniraj();
            Ispisi_Kosaricu(k);









            Console.ReadLine();

            

        }
    }
}
