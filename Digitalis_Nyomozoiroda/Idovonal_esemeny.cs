using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_Nyomozoiroda
{
    internal class Idovonal_esemeny
    {
        private DateTime datum;
        private string esemeny;

        public Idovonal_esemeny(DateTime datum, string esemeny)
        {
            this.datum = datum;
            this.esemeny = esemeny;
        }

        public DateTime Datum { get => datum; set => datum = value; }
        public string Esemeny { get => esemeny; set => esemeny = value; }

        public override string ToString()
        {
            return $"{this.datum}: {this.esemeny}";
        }
    }
}
