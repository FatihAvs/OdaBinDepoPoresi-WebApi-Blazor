using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class DepoViewModel
    {
        public int BinaId { get; set; }
        public int DepoFiyatı { get; set; }
        public int DepoM2 { get; set; }
        public string Aciklama { get; set; }
    }
}
