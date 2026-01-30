using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_Nyomozoiroda
{
    internal class Bizonyitek
    {
        private int azonosito;
        private string tipus;
        private string leiras;
        private int megbizhatosagi_ertek;

        public Bizonyitek(int azonosito, string tipus, string leiras, int megbizhatosagi_ertek)
        {
            this.azonosito = azonosito;
            this.tipus = tipus;
            this.leiras = leiras;
            this.megbizhatosagi_ertek = megbizhatosagi_ertek;
        }

        public int Azonosito { get => azonosito; set => azonosito = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public int Megbizhatosagi_ertek { get => megbizhatosagi_ertek; set => megbizhatosagi_ertek = value; }

        public override string ToString()
        {
            return $"{this.azonosito}: {this.tipus}: {this.leiras}, megbízhatósága: {this.megbizhatosagi_ertek}";
        }
    }
}
