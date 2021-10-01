using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class Bina:IEntity
    {
        public int BinaId { get; set; }
        public string BinaAdi { get; set; }
        public string Adres { get; set; }
        public int KatSayisi { get; set; }
        public int Yasi { get; set; }
    }
}
