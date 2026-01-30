using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Digitalis_Nyomozoiroda
{
    internal class Bizonyitekkezelo
    {
        private Adattar adattarolo;
        private List<Bizonyitek> bizonyitekok;
        private List<Bizonyitek> raktar;


        public Bizonyitekkezelo(List<Bizonyitek> bizonyitekok)
        {
            this.bizonyitekok = bizonyitekok; 
            this.raktar = new List<Bizonyitek>();
        }

        internal List<Bizonyitek> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
        internal List<Bizonyitek> Raktar { get => raktar; set => raktar = value; }

        public void Bizonyitek_hozzaadas(Bizonyitek b)
        {
           if (raktar.Contains(b))
            {
                bizonyitekok.Add(b);
                raktar.Remove(b);
            }
            else if (bizonyitekok.Contains(b))
            {
                Console.WriteLine("Ez a bizonyíték már része a bizonyítékoknak!");
            }
            else
            {
               
                bizonyitekok.Add(b);
               
            }
               
        }
        public Bizonyitek Bizonyitek_torlese(Bizonyitek b)
        {
            if (!bizonyitekok.Contains(b))
            {
                Console.WriteLine("Nincs ilyen bizonyíték a bizonyítékok között!");
            }
            else
            {
                raktar.Add(b);
                bizonyitekok.Remove(b);
            }

            return b;
               
        }
    }
}
