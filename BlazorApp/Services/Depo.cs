using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class Depo
    {
        public int DepoId { get; set; }
        public int BinaId { get; set; }
        public int DepoFiyatı { get; set; }
        public int DepoM2 { get; set; }
        public string Aciklama { get; set; }
    }
}
