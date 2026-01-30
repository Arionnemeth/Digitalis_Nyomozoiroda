using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_Nyomozoiroda
{
    internal class Bizonyitekkezelo
    {
        private List<Bizonyitek> bizonyitekok;

        public Bizonyitekkezelo(List<Bizonyitek> bizonyitekok)
        {
            this.bizonyitekok = new List<Bizonyitek>(); 
        }

        internal List<Bizonyitek> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }

        public void Bizonyitek_hozzaadas(Bizonyitek b)
        {
            bizonyitekok.Add(b);
        }
        public void Bizonyitek_torlese(Bizonyitek b)
        {
            bizonyitekok.Remove(b);
        }
    }
}
