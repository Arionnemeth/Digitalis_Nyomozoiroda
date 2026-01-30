using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_Nyomozoiroda
{
    internal class Szemely
    {
        private string nev;
        private int eletkor;
        private string megjegyzes;

        public Szemely(string nev, int eletkor, string megjegyzes)
        {
            this.nev = nev;
            this.eletkor = eletkor;
            this.megjegyzes = megjegyzes;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Eletkor { get => eletkor; set => eletkor = value; }
        public string Megjegyzes { get => megjegyzes; set => megjegyzes = value; }

        public override string ToString()
        {
            return $"{this.nev}, {this.eletkor}: {this.megjegyzes}";
        }
    }
}
