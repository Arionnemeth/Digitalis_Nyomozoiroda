using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_Nyomozoiroda
{
    internal class Ugy
    {
        private int ugy_azonosito;
        private string cim;
        private string leiras;
        private string allapot;
        private List<Szemely> resztvevok;
        private List<Bizonyitek> bizonyitekok;

        public Ugy(int ugy_azonosito, string cim, string leiras, string allapot)
        {
            this.ugy_azonosito = ugy_azonosito;
            this.cim = cim;
            this.leiras = leiras;
            this.allapot = allapot;
            this.resztvevok = new List<Szemely>();
            this.bizonyitekok = new List<Bizonyitek>();
        }

        public int Ugy_azonosito { get => ugy_azonosito; set => ugy_azonosito = value; }
        public string Cim { get => cim; set => cim = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public string Allapot { get => allapot; set => allapot = value; }
        internal List<Szemely> Resztvevok { get => resztvevok; set => resztvevok = value; }
        internal List<Bizonyitek> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }


        public void HozzatartozoSzemelyekFelvetel(Szemely sz)
        {
            this.resztvevok.Add(sz);
        }

        public void HozzatartozoBizonyitekFelvetel(Bizonyitek b)
        {
            this.bizonyitekok.Add(b);
        }

        public void AllapotValtoztatas(string ujallapt)
        {
            this.allapot = ujallapt;
            Console.WriteLine("Az ügy állapota frissült!");
        }
        public override string ToString()
        {
            return $"{this.ugy_azonosito}: {this.cim}: {this.leiras}: {this.allapot}, résztvett személyek: {this.resztvevok}, bizonyitékok: {this.bizonyitekok}";
        }
    }
}
