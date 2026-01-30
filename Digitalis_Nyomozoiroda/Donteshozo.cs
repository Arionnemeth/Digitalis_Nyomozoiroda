using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_Nyomozoiroda
{
    internal class Donteshozo
    {
        public void Donteshozas(Gyanusitott g, Bizonyitek b)
        {
            if (b.Megbizhatosagi_ertek >= 3)
            {
                g.Gyanusitottsagi_szint += 10;
            }
            if (g.Gyanusitottsagi_szint >= 70)
            {
                Console.WriteLine("Figyelem elérte a felső szintet a gyanusítottságban!");
            }
        }
       
    }
}
