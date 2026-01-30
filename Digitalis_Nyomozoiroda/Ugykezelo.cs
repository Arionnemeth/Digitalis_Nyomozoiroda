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
    }
}
