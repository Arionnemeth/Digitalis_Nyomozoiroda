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
            Ugy u1 = new Ugy("001", "Koczka", "jkhj", "jhghjg");
            u1.HozzatartozoSzemelyekFelvetel(s1);
            u1.HozzatartozoBizonyitekFelvetel(b1);
            Ugy u2 = new Ugy("002", "Urbin", "hjhkjh", "kljk");
            u2.HozzatartozoSzemelyekFelvetel(s2);
            u2.HozzatartozoBizonyitekFelvetel(b2);

            List<Ugy> ugyek = new List<Ugy>();
            ugyek.Add(u1);
            ugyek.Add(u2);
            List<Felhasznalo> felhasznalok = new List<Felhasznalo>();
            felhasznalok.Add(f1);
            felhasznalok.Add(f2);
            List<Szemely> szemelyek = new List<Szemely>();
            szemelyek.Add(s1);
            szemelyek.Add(s2);
            List<Bizonyitek> bizonyitekok = new List<Bizonyitek>();
            bizonyitekok.Add(b1);
            bizonyitekok.Add(b2);
            Adattar a = new Adattar(felhasznalok, ugyek,szemelyek, bizonyitekok);
            int bekeres = 0;
            Ugy ujugy = new Ugy();
           
            do
            {
                Console.WriteLine("1. Ügyek kezelése\r\n2. Személyek kezelése\r\n3. Bizonyítékok kezelése\r\n4. Idővonal megtekintése\r\n5. Elemzés / döntések\r\n6. Kilépés");
                 bekeres = Convert.ToInt32(Console.ReadLine());

                if (bekeres == 1)
                {
                    Console.WriteLine("1. Új ügy létrehozása\r\n2. Ügy állapotáak megváltoztatása");
                    int valasztasod = Convert.ToInt32(Console.ReadLine());
                    if (valasztasod == 1)
                    {
                        Console.Write("Ügy azonosító: ");
                        string azonosito = Console.ReadLine();
                        Console.Write("Cím: ");
                        string cim = Console.ReadLine();
                        Console.Write("Leírás: ");
                        string leiras = Console.ReadLine();
                        Console.Write("Állapot: ");
                        string allapot = Console.ReadLine();
                        ujugy = new Ugy("001", cim, leiras, allapot);
                        ujugy.HozzatartozoSzemelyekFelvetel(s2);
                        ujugy.HozzatartozoBizonyitekFelvetel(b2);
                    }
                    else if (valasztasod == 2)
                    {
                        Console.WriteLine("Melyik ügyet akarja változtatni: ");
                        a.ListazasUgyek();
                        int ugyszam = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ügy állapotának változtatása erre: ");
                        string ujallapot = Console.ReadLine();
                        a.Ugyeklista[ugyszam - 1].AllapotValtoztatas(ujallapot);
                    }
                }
                if (bekeres == 2)
                {
                    a.ListazasSzemelyek();
                    Console.Write("Név: ");
                    string nev = Console.ReadLine();
                    Console.Write("Életkor: ");
                    int eletkor = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Megjegyzés: ");
                    string megjegyzes = Console.ReadLine();
                    Szemely ujszemely = new Szemely(nev, eletkor , megjegyzes);
                    szemelyek.Add(ujszemely);
                }
                if (bekeres == 3)
                {

                }
                if (bekeres == 4)
                {
                   
                }
                if (bekeres == 5)
                {

                }

            }
            while (bekeres != 6);
        }
    }
}
