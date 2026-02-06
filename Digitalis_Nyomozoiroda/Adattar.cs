using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_Nyomozoiroda
{
    internal class Adattar
    {
        private List<Felhasznalo> felhasznalolista;
        private List<Ugy> ugyeklista;
        private List<Szemely> szemelylista;
        private List<Bizonyitek> bizonyiteklista;
        private List<Gyanusitott> gyanusitottlista;

        public Adattar(List<Felhasznalo> felhasznalolista, List<Ugy> ugyeklista, List<Szemely> szemelylista, List<Bizonyitek> bizonyiteklista, List<Gyanusitott> gyanusitottlista)
        {
            this.felhasznalolista = felhasznalolista ;
            this.ugyeklista = ugyeklista;
            this.szemelylista = szemelylista;
            this.bizonyiteklista = bizonyiteklista;
            this.gyanusitottlista = gyanusitottlista;
        }

        internal List<Felhasznalo> Felhasznalolista { get => felhasznalolista; set => felhasznalolista = value; }
        internal List<Ugy> Ugyeklista { get => ugyeklista; set => ugyeklista = value; }
        internal List<Szemely> Szemelylista { get => szemelylista; set => szemelylista = value; }
        internal List<Bizonyitek> Bizonyiteklista { get => bizonyiteklista; set => bizonyiteklista = value; }
        internal List<Gyanusitott> Gyanusitottlista { get => gyanusitottlista; set => gyanusitottlista = value; }

        public void ListazasUgyek() 
        {
            int i = 1;
            foreach (var item in this.ugyeklista)
            {
                Console.WriteLine(i + ". :" + item);
                i++;
            }
        }

        public void ListazasFelhasznalok()
        {
            int i = 1;
            foreach (var item in this.felhasznalolista)
            {
                Console.WriteLine(i + ". :" + item);
                i++;
            }
        }

        public void ListazasBizonyítékok()
        {
            int i = 1;
            foreach (var item in this.bizonyiteklista)
            {
                Console.WriteLine(i + ". :" + item);
                i++;
            }
        }

        public void ListazasSzemelyek()
        {
            int i = 1;
            foreach (var item in this.szemelylista)
            {
                Console.WriteLine(i + ". :" + item);
                i++;
            }
        }

        public void ListazasGyanusitottak()
        {
            int i = 1;
            foreach (var item in this.gyanusitottlista)
            {
                Console.WriteLine(i + ". :" + item);
                i++;
            }
        }
    }
}
