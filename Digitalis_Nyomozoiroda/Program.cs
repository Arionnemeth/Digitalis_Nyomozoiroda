using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Digitalis_Nyomozoiroda
{
    internal class Program
    {
    
      
        static void Main(string[] args)
        {
            Szemely s1 = new Szemely("Koczka Steve", 67, "Úszómester");
            Szemely s2 = new Szemely("Urbin Pork", 69, "CISCO mester");
            Felhasznalo f1 = new Felhasznalo("Andrew Tate ügynök", 007, "Nyomozó");
            Felhasznalo f2 = new Felhasznalo("BGY ügynök", 676, "Nyomozó");
            Bizonyitek b1 = new Bizonyitek(01, "digitális adat", "Limux keresési előzmények", 3);
            Bizonyitek b2 = new Bizonyitek(02, "fotó", "Kép az Urbin Islandről", 5);

            List<Felhasznalo> felhasznalok = new List<Felhasznalo>();
            felhasznalok.Add(f1);
            felhasznalok.Add(f2);
            List<Szemely> szemelyek = new List<Szemely>();
            szemelyek.Add(s1);
            szemelyek.Add(s2);
            List<Bizonyitek> bizonyitekok = new List<Bizonyitek>();
            bizonyitekok.Add(b1);
            bizonyitekok.Add(b2);

            int bekeres = 0;
            do
            {
                Console.WriteLine("1. Ügyek kezelése\r\n2. Személyek kezelése\r\n3. Bizonyítékok kezelése\r\n4. Idővonal megtekintése\r\n5. Elemzés / döntések\r\n6. Kilépés");
                 bekeres = Convert.ToInt32(Console.ReadLine());

                if (bekeres == 1)
                {
                    Console.Write("Cím: ");
                    string cim = Console.ReadLine();
                    Console.Write("Leírás: ");
                    string leiras = Console.ReadLine();
                    Console.Write("Állapot: ");
                    string allapot = Console.ReadLine();
                    Ugy ujugy = new Ugy(001, cim, leiras, allapot);
                    ujugy.HozzatartozoSzemelyekFelvetel(s2);
                    ujugy.HozzatartozoBizonyitekFelvetel(b2);
                }
                if (bekeres == 2)
                {

                }
                if (bekeres == 3)
                {

                }
                if (bekeres == 4)
                {
                   /* Console.Write("Ügy állapotának változtatása erre: ");
                    string ujallapot = Console.ReadLine();
                    ujugy.AllapotValtoztatas(ujallapot);*/
                }
                if (bekeres == 5)
                {

                }

            }
            while (bekeres != 6);
        }
    }
}
