using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_Nyomozoiroda
{
    internal class Gyanusitott
    {
        private Szemely gyanusitott_szemely;
        private int gyanusitottsagi_szint;
        private string statusz;

        public Gyanusitott(Szemely gyanusitott_szemely, int gyanusitottsagi_szint, string statusz)
        {
            this.gyanusitott_szemely = gyanusitott_szemely;
            this.gyanusitottsagi_szint = gyanusitottsagi_szint;
            this.statusz = statusz;
        }

        public int Gyanusitottsagi_szint { get => gyanusitottsagi_szint; set => gyanusitottsagi_szint = value; }
        public string Statusz { get => statusz; set => statusz = value; }
        internal Szemely Gyanusitott_szemely { get => gyanusitott_szemely; set => gyanusitott_szemely = value; }

        public override string ToString()
        {
            return $"{this.gyanusitott_szemely}: {this.gyanusitottsagi_szint}, {this.statusz}";
        }
    }
}
