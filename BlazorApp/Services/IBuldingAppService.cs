using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public interface IBuldingAppService
    {
        public string Message {get;set;}
        Task<List<Bina>> BinalariGetir();
        Task<List<Oda>> OdalariGetir();
        Task<List<Depo>> DepolarıGetir();
        Task<string> AddBina(Bina bina);
        Task<string> AddDepo(Depo depo);
        Task<string> AddOda(Oda oda);
        Task<string> DeleteBina(int id);
        Task<string> DeleteOda(int id);
        Task<string> DeleteDepo(int id);
        Task<Bina> BinayiGetir(int id);
        Task<Oda> OdayiGetir(int id);
        Task<Depo> DepoyuGetir(int id);



    }
}
