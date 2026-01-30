using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_Nyomozoiroda
{
    internal class Ugykezelo
    {
        private List<Ugy> ugyek;

        public Ugykezelo(List<Ugy> ugyek)
        {
            this.ugyek = new List<Ugy>();
        }

        internal List<Ugy> Ugyek { get => ugyek; set => ugyek = value; }

        public void Uj_Ugyletrehozasa(Ugy u)
        {
            ugyek.Add(u);
        }

        public void Ugyek_Listazasa()
        {
            foreach (var item in ugyek)
            {
                Console.WriteLine(item);
            }
        }

        public void Hozzarendeles_Bizonyitek(Bizonyitek b, Ugy u)
        {
            foreach (var item in ugyek)
            {
                if(item.Ugy_azonosito == u.Ugy_azonosito)
                {
                    item.Bizonyitekok.Add(b);
                }
            }
        }

        public void Hozzarendeles_Szemely(Szemely s, Ugy u)
        {
            foreach (var item in ugyek)
            {
                if (item.Ugy_azonosito == u.Ugy_azonosito)
                {
                    item.Resztvevok.Add(s);
                }
            }
        }
    }
}
