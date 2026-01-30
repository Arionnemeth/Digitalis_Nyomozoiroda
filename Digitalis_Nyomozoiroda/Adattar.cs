using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_Nyomozoiroda
{
    internal class Adattar
    {
        List<Felhasznalo> felhasznalolista;
        List<Ugy> ugyeklista;
        List<Szemely> szemelylista;
        List<Bizonyitek> bizonyiteklista;

        public Adattar(List<Felhasznalo> felhasznalolista, List<Ugy> ugyeklista, List<Szemely> szemelylista, List<Bizonyitek> bizonyiteklista)
        {
            this.felhasznalolista = new List<Felhasznalo> ();
            this.ugyeklista = new List<Ugy> ();
            this.szemelylista = new List<Szemely> ();
            this.bizonyiteklista = new List<Bizonyitek> ();
        }

        internal List<Felhasznalo> Felhasznalolista { get => felhasznalolista; set => felhasznalolista = value; }
        internal List<Ugy> Ugyeklista { get => ugyeklista; set => ugyeklista = value; }
        internal List<Szemely> Szemelylista { get => szemelylista; set => szemelylista = value; }
        internal List<Bizonyitek> Bizonyiteklista { get => bizonyiteklista; set => bizonyiteklista = value; }
    }
}
