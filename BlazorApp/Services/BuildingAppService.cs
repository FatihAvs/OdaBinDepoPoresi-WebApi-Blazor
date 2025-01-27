﻿using System;
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
        public async Task<Bina> BinayiGetir(int id)
        {

            return await httpClient.GetFromJsonAsync<Bina>($"api/bina/getbyid?id={id}");

        }
        public async Task<Depo> DepoyuGetir(int id)
        {

            return await httpClient.GetFromJsonAsync<Depo>($"api/depo/getbyid?id={id}");

        }
        public async Task<Oda> OdayiGetir(int id)
        {

            return await httpClient.GetFromJsonAsync<Oda>($"api/oda/getbyid?id={id}");

        }

        public async Task<string> DeleteBina(int id)
        {
            var result =  await httpClient.PostAsJsonAsync<string>($"api/bina/delete?id={id}",null);
            Message = await result.Content.ReadFromJsonAsync<string>();
            return Message;
        }
        public async Task<string> DeleteOda(int id)
        {
            var result = await httpClient.PostAsJsonAsync<string>($"api/oda/delete?id={id}", null);
            Message = await result.Content.ReadFromJsonAsync<string>();
            return Message;
        }
        public async Task<string> DeleteDepo(int id)
        {
            var result = await httpClient.PostAsJsonAsync<string>($"api/depo/delete?id={id}", null);
            Message = await result.Content.ReadFromJsonAsync<string>();
            return Message;
        }
    }


}
