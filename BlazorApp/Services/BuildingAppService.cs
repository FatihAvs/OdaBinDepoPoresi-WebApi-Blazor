using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class BuildingAppService : IBuldingAppService
    {
        private readonly HttpClient httpClient;

        public BuildingAppService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public string Message { get; set; }

        public async Task<string> AddBina(Bina bina)
        {
           var result =  await httpClient.PostAsJsonAsync<Bina>("api/bina/add", bina);

           Message = await result.Content.ReadFromJsonAsync<string>();
           return Message;
            
        }
        public async Task<string> AddDepo(Depo depo)
        {
            var result = await httpClient.PostAsJsonAsync<Depo>("api/depo/add", depo);

            Message = await result.Content.ReadFromJsonAsync<string>();
            return Message;

        }
        public async Task<string> AddOda(Oda oda)
        {
            var result = await httpClient.PostAsJsonAsync<Oda>("api/oda/add", oda);

            Message = await result.Content.ReadFromJsonAsync<string>();
            return Message;

        }

        public async Task<List<Bina>> BinalariGetir()
        {
            
            return await httpClient.GetFromJsonAsync<List<Bina>>("api/bina/getall");

}

        public async Task<List<Depo>> DepolarıGetir()
        {
            return await httpClient.GetFromJsonAsync<List<Depo>>("api/depo/getall");
        }

        public async Task<List<Oda>> OdalariGetir()
        {

            return await httpClient.GetFromJsonAsync<List<Oda>>("api/oda/getall");

        }
      


    }
   

}
