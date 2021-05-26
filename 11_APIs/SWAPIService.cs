using _11_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _11_APIs
{
    public class SWAPIService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<Person> GetPersonAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"http://swapi.dev/api/people/{id}/");

            //If 200 (ok), carry on
            if (response.IsSuccessStatusCode)
            {
                //Read the content of the response a s Person object
                Person person = await response.Content.ReadAsAsync<Person>();
                //give person back
                return person;
            }
            //If the response is anything other than 200 (ok) give a null;
            return null;
        }

        public async Task<Vehicle> GetVehicleAsync(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Vehicle>();
               // Vehicle vehicle = await response.Content.ReadAsAsync<Vehicle>();
               // return vehicle;
            }
            return null;
        }

        
        public async Task<T> GetAsync<T>(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<T>();
            }
            return default;
        }

        /*
       public async Task<T> GetAsync<T>(int id)
       {
           HttpResponseMessage response = await _httpClient.GetAsync($"http://swapi.dev/api/{T}/{id}/");

           if (response.IsSuccessStatusCode)
           {
               return await response.Content.ReadAsAsync<T>();
           }
           return default;
       }
       */

        public async Task<SearchResult<Person>>  GetPersonSearchAsync(string query)
        {
            HttpResponseMessage response = await _httpClient.GetAsync("https://swapi.dev/api/people/?search=" + query);

            if(response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<Person>>();
            }
            return null;
        }
        
        public async Task<SearchResult<T>> GetSearchResultAsync<T>(string category,string query)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"https://swapi.dev/api/{category}/?search=" + query);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<T>>();
            }
            return null;
        }
        
        //Combo Methods
        public async Task<SearchResult<Vehicle>> GetVehicleSearchAsync(string query)
        {
            return await GetSearchResultAsync<Vehicle>("vehicles", query);
        }


    }
}
