using System;
using System.Collections.Generic;

namespace backend_test
{
    public partial class Automobilis
    {
        public ulong Id { get; set; }
        public string Spalva { get; set; }
        public string Serija { get; set; }
        public string VariklioDarbinisTuris { get; set; }
        public int AutomobilioPagaminimoMetai { get; set; }
        public int? PavaruSkaicius { get; set; }
        public string PavaruDezesKodas { get; set; }
        public int VariklioGalia { get; set; }
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public string Variantas { get; set; }
        public string MetuIntervalas { get; set; }
        public string Tipas { get; set; }
    }
}
