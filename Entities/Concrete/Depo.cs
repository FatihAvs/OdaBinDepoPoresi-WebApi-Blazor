using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Depo: IEntity
    {
        public int DepoId { get; set; }
        public int BinaId { get; set; }
        public int DepoFiyatı { get; set; }
        public int DepoM2 { get; set; }
        public string Aciklama { get; set; }
    }
}
