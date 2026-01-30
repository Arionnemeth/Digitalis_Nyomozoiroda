using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_Nyomozoiroda
{
    internal class Tanu
    {
        private Szemely tanusitott_ember;
        private string vallomas_szovege;
        private DateTime vallomas_datuma;

        public Tanu(Szemely tanusitott_ember, string vallomas_szovege, DateTime vallomas_datuma)
        {
            this.tanusitott_ember = tanusitott_ember;
            this.vallomas_szovege = vallomas_szovege;
            this.vallomas_datuma = vallomas_datuma;
        }

        public string Vallomas_szovege { get => vallomas_szovege; set => vallomas_szovege = value; }
        public DateTime Vallomas_datuma { get => vallomas_datuma; set => vallomas_datuma = value; }
        internal Szemely Tanusitott_ember { get => tanusitott_ember; set => tanusitott_ember = value; }

        public override string ToString()
        {
            return $"{tanusitott_ember} szövege: {vallomas_szovege} dátuma: {vallomas_datuma}";
        }
    }
}
