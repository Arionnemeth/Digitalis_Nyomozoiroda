using System.ComponentModel;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Digitalis_Nyomozoiroda
{
    internal class Program
    {
    
      
        static void Main(string[] args)
        {
            Szemely s1 = new Szemely("Koczka Steve", 67, "Úszómester");
            Szemely s2 = new Szemely("Urbin Pork", 69, "CISCO mester");
            Szemely s3 = new Szemely("Kis János", 8, "Fél");
            Szemely s4 = new Szemely("Juliska", 10, "Ő is fél");
            Tanu t1 = new Tanu(s3,"Azt hittem úszásra megyek", new DateTime(2025,06,05));
            Tanu t2 = new Tanu(s4, "Azt hittem nyaralni megyek", new DateTime(2025,07,07));
            Felhasznalo f1 = new Felhasznalo("Andrew Tate ügynök", 007, "Nyomozó");
            Felhasznalo f2 = new Felhasznalo("BGY ügynök", 676, "Nyomozó");
            Bizonyitek b1 = new Bizonyitek(01, "digitális adat", "Limux keresési előzmények", 3);
            Bizonyitek b2 = new Bizonyitek(02, "fotó", "Kép az Urbin Islandről", 5);
            Idovonal_esemeny i1 = new Idovonal_esemeny(new DateTime(2025,06,05), "Kihallgattuk Kis Jánost");
            Idovonal_esemeny i2 = new Idovonal_esemeny(new DateTime(2025, 07, 07), "Kihallgattuk Juliskát");
            Ugy u1 = new Ugy("001", "Koczka", "jkhj", "jhghjg");
            u1.HozzatartozoSzemelyekFelvetel(s1);
            u1.HozzatartozoBizonyitekFelvetel(b1);
            Ugy u2 = new Ugy("002", "Urbin", "hjhkjh", "kljk");
            u2.HozzatartozoSzemelyekFelvetel(s2);
            u2.HozzatartozoBizonyitekFelvetel(b2);
            Gyanusitott g1 = new Gyanusitott(s1, 70, "őrizetben");
            Gyanusitott g2 = new Gyanusitott(s2, 67, "megfigyelés alatt");
            Donteshozo donteshozo = new Donteshozo();

            List<Idovonal_esemeny> idovonalesemeny = new List<Idovonal_esemeny>();
            idovonalesemeny.Add(i1);
            idovonalesemeny.Add(i2);
            List<Tanu> tanuk = new List<Tanu>();
            tanuk.Add(t1);
            tanuk.Add(t2);
            List<Gyanusitott> gyanusitottak = new List<Gyanusitott>();
            gyanusitottak.Add(g1);
            gyanusitottak.Add(g2);
            List<Ugy> ugyek = new List<Ugy>();
            ugyek.Add(u1);
            ugyek.Add(u2);
            List<Felhasznalo> felhasznalok = new List<Felhasznalo>();
            felhasznalok.Add(f1);
            felhasznalok.Add(f2);
            List<Szemely> szemelyek = new List<Szemely>();
            szemelyek.Add(s1);
            szemelyek.Add(s2);
            szemelyek.Add(s3);
            szemelyek.Add(s4);
            List<Bizonyitek> bizonyitekok = new List<Bizonyitek>();
            bizonyitekok.Add(b1);
            bizonyitekok.Add(b2);
            Adattar a = new Adattar(felhasznalok, ugyek,szemelyek, bizonyitekok, gyanusitottak, tanuk, idovonalesemeny);
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
                    Console.Write("Bizonyíték azonosító: ");
                    int azonosito = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Típus (kép,videó,dokumentum,digitális adat): ");
                    string tipus = Console.ReadLine();
                    Console.Write("Leírás: ");
                    string leiras = Console.ReadLine();
                    Console.Write("Megbízhatóság(1-5): ");
                    int megbizhato = Convert.ToInt32(Console.ReadLine());
                    Bizonyitek ujbizonyitek = new Bizonyitek(azonosito,tipus,leiras,megbizhato);
                    bizonyitekok.Add(ujbizonyitek);
                   
                }
                if (bekeres == 4)
                {
                    Console.Write("Add meg az évet: ");
                    int ev = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg a hónapot: ");
                    int honap = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg a napot: ");
                    int nap = Convert.ToInt32(Console.ReadLine());
                    DateTime ujido = new DateTime(ev, honap, nap);
                    Console.Write("Adj meg egy eseményt: ");
                    string esemeny = Console.ReadLine();
                    Idovonal_esemeny ujesemeny = new Idovonal_esemeny(ujido, esemeny);
                    Console.WriteLine(ujido);
                    idovonalesemeny.Add(ujesemeny);
                }
                if (bekeres == 5)
                {
                    Console.WriteLine("1. Új gyanúsított felvétel\r\n2. Döntéshozás");
                    int valasztas = Convert.ToInt32(Console.ReadLine());

                    if (valasztas == 1)
                    {
                        Console.WriteLine("Ki a gyanúsított a személyek közül: ");
                        a.ListazasSzemelyek();
                        int szemelyszam = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Hányas gyanúsítottszintje van: ");
                        int gyanusitottszint = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Milyen állapotban van a gyanusított: ");
                        string gyanusitottallapot = Console.ReadLine();
                        Gyanusitott ujgyanusitott = new Gyanusitott(a.Szemelylista[szemelyszam - 1], gyanusitottszint, gyanusitottallapot);
                        gyanusitottak.Add(ujgyanusitott);
                    }
                    else if (valasztas == 2) 
                    {

                        Console.WriteLine("Vélassz egy gyanúsítottat: ");
                        a.ListazasGyanusitottak();
                        int gyanusitottszama = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("Vélassz egy bizonyítékot: ");
                        a.ListazasBizonyítékok();
                        int bizonyitekszam = Convert.ToInt32(Console.ReadLine());

                        donteshozo.Donteshozas(a.Gyanusitottlista[gyanusitottszama - 1], a.Bizonyiteklista[bizonyitekszam - 1]);
                    }


                }

            }
            while (bekeres != 6);
        }
    }
}
