using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Bina : IEntity
    {
        public int BinaId { get; set; }
        public string BinaAdi { get; set; }
        public string Adres { get; set; }
        public int KatSayisi { get; set; }
        public int Yasi { get; set; }
    }
}
