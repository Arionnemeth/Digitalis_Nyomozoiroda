using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_Nyomozoiroda
{
    internal class Ugy_allapota
    {
        private string aktualis_statusz;

        public Ugy_allapota(string aktualis_statusz)
        {
            this.aktualis_statusz = aktualis_statusz;
        }

        public string Aktualis_statusz { get => aktualis_statusz; set => aktualis_statusz = value; }

        public void AllapotValtoztatas(string allapot)
        {
            this.aktualis_statusz = allapot;
        }
    }
}
