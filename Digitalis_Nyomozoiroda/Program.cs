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
            Donteshozo donteshozo = new Donteshozo();
           List<Idovonal_esemeny> idovonalesemeny = new List<Idovonal_esemeny>();
            List<Tanu> tanuk = new List<Tanu>();
            List<Gyanusitott> gyanusitottak = new List<Gyanusitott>();
            List<Ugy> ugyek = new List<Ugy>();
            List<Felhasznalo> felhasznalok = new List<Felhasznalo>();
            List<Szemely> szemelyek = new List<Szemely>();
            List<Bizonyitek> bizonyitekok = new List<Bizonyitek>();
            List<Bizonyitek> raktar = new List<Bizonyitek>();
            Adattar a = new Adattar(felhasznalok, ugyek,szemelyek, bizonyitekok, gyanusitottak, tanuk, idovonalesemeny);
            int bekeres = 0;
            Ugy ujugy = new Ugy();


            do
            {
                Console.WriteLine("1. Ügyek kezelése\r\n2. Személyek kezelése\r\n3. Bizonyítékok kezelése\r\n4. Idővonal megtekintése\r\n5. Elemzés / döntések\r\n6. Kilépés");
                 bekeres = Convert.ToInt32(Console.ReadLine());

                if (bekeres == 1)
                {
                    Console.WriteLine("1. Új ügy létrehozása\r\n2. Ügy állapotának megváltoztatása");
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
                        ujugy = new Ugy(azonosito, cim, leiras, allapot);
                        ugyek.Add(ujugy);
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
                    Console.WriteLine("1. Új személy hozzáadása\r\n2. Új tanu hozzáadása");
                    int valasztas = Convert.ToInt32(Console.ReadLine());
                    if(valasztas == 1)
                    {
                        a.ListazasSzemelyek();
                        Console.Write("Név: ");
                        string nev = Console.ReadLine();
                        Console.Write("Életkor: ");
                        int eletkor = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Megjegyzés: ");
                        string megjegyzes = Console.ReadLine();
                        Szemely ujszemely = new Szemely(nev, eletkor, megjegyzes);
                        szemelyek.Add(ujszemely);
                    }
                    else if (valasztas == 2)
                    {
                        Console.WriteLine("Ki a tanu a személyek közül: ");
                        a.ListazasSzemelyek();
                        int szemelyszam = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Mi a tanu vallomása: ");
                        string vallomasa = Console.ReadLine();
                        Console.Write("Add meg az évet: ");
                        int ev = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Add meg a hónapot: ");
                        int honap = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Add meg a napot: ");
                        int nap = Convert.ToInt32(Console.ReadLine());
                        DateTime ujido = new DateTime(ev, honap, nap);
                        Tanu ujtanu = new Tanu(a.Szemelylista[szemelyszam - 1], vallomasa, ujido);
                        tanuk.Add(ujtanu);
                        a.Szemelylista.Remove(a.Szemelylista[szemelyszam - 1]);
                    }
                }
                if (bekeres == 3)
                {
                    Console.WriteLine("1. Új bizonyíték hozzáadása\r\n2. Bizonyíték törlése");
                    int valasztas = Convert.ToInt32(Console.ReadLine());
                    if (valasztas == 1)
                    {
                        Console.Write("Bizonyíték azonosító: ");
                        int azonosito = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Típus (kép,videó,dokumentum,digitális adat): ");
                        string tipus = Console.ReadLine();
                        Console.Write("Leírás: ");
                        string leiras = Console.ReadLine();
                        Console.Write("Megbízhatóság(1-5): ");
                        int megbizhato = Convert.ToInt32(Console.ReadLine());
                        Bizonyitek ujbizonyitek = new Bizonyitek(azonosito, tipus, leiras, megbizhato);
                        if (bizonyitekok.Contains(ujbizonyitek))
                        {
                            Console.WriteLine("A bizonyíték már szerepel a listában!");
                        }
                        else if (raktar.Contains(ujbizonyitek))
                        {
                            bizonyitekok.Add(ujbizonyitek);
                            raktar.Remove(ujbizonyitek);
                        }
                        else
                        {
                            bizonyitekok.Add(ujbizonyitek);
                        }
                     
                    }
                    else if (valasztas == 2)
                    {
                        Console.WriteLine("Melyik bizonyítékot szeretnéd törölni: ");
                        a.ListazasBizonyítékok();
                        int valasztasod = Convert.ToInt32(Console.ReadLine());
                        raktar.Add(a.Bizonyiteklista[valasztasod - 1]);
                        bizonyitekok.Remove(a.Bizonyiteklista[valasztasod - 1]);
                        Console.WriteLine("Sikeresen törölted a bizonyítékot!");
                    }
                    
                   
                }
                if (bekeres == 4)
                {
                    Console.WriteLine("1. Új esemény hozzáadása\r\n2. Idővonal megtekintése\r\n3. Tanu összekötettése az eseménnyel");
                    int valasztas = Convert.ToInt32(Console.ReadLine());
                    if (valasztas == 1)
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
                    else if (valasztas == 2)
                    {
                        Console.WriteLine("Az összes esemény eddig: ");
                        a.ListazasIdovonalak();
                    }
                    else if (valasztas == 3)
                    {
                        Console.WriteLine("Válaszd ki a tanut: ");
                        int szemelyszama = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Válaszd ki az eseményt: ");
                        int esemenyszam = Convert.ToInt32(Console.ReadLine());
                        if (a.Tanuk[szemelyszama - 1].Vallomas_datuma == a.Idovonalesemeny[esemenyszam - 1].Datum)
                        {
                            Console.WriteLine("Ez az esemény a tanúhoz kapcsolódik!");
                        }
                        else 
                        {
                            Console.WriteLine("Ez az esemény nem ehhez a tanúhoz kapcsolódik!");
                        }
                        
                    }
                }
                if (bekeres == 5)
                {
                    Console.WriteLine("1. Új gyanúsított felvéte\r\n2. Döntéshozás");
                    int valasztas = Convert.ToInt32(Console.ReadLine());

                    if (valasztas == 1)
                    {
                        Console.WriteLine("Ki a gyanúsított a személyek közül: ");
                        a.ListazasSzemelyek();
                        int szemelyszam = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Hányas gyanúsítottszintje van(1-100): ");
                        int gyanusitottszint = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Milyen állapotban van a gyanusított: ");
                        string gyanusitottallapot = Console.ReadLine();
                        Gyanusitott ujgyanusitott = new Gyanusitott(a.Szemelylista[szemelyszam - 1], gyanusitottszint, gyanusitottallapot);
                        gyanusitottak.Add(ujgyanusitott);
                        a.Szemelylista.Remove(a.Szemelylista[szemelyszam-1]);
                    }
                    else if (valasztas == 2) 
                    {

                        Console.WriteLine("Válassz egy gyanúsítottat: ");
                        a.ListazasGyanusitottak();
                        int gyanusitottszama = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("Válassz egy bizonyítékot: ");
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
