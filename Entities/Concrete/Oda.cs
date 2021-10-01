using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Oda: IEntity
    {
        public int OdaId { get; set; }
        public int BinaId { get; set; }
        public int OdaM2 { get; set; }
        public int OdaFiyati { get; set; }
        public int OdaKati { get; set; }
        public string Acıklama { get; set; }
    }
}
