using _11_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _11_APIs
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage respsonse = httpClient.GetAsync("http://swapi.dev/api/people/1/").Result;
            //List <Vehicle> vehicle = new List<Vehicle>();

            if(respsonse.IsSuccessStatusCode)
            {
                //Console.WriteLine(respsonse.Content.ReadAsStringAsync().Result); //Shows the result as a JSON string
            }

            Person person = respsonse.Content.ReadAsAsync<Person>().Result;
            Console.WriteLine($"{person.Name} Has {person.Hair_Color} Hair");

            foreach(string vehicleURL in person.Vehicles)
            {
                HttpResponseMessage vehicleResponse = httpClient.GetAsync(vehicleURL).Result;
               // Console.WriteLine(vehicleResponse.Content.ReadAsStringAsync().Result);  //shows results as a JSON string
                Vehicle vehicle = vehicleResponse.Content.ReadAsAsync<Vehicle>().Result;
                Console.WriteLine(vehicle.Name);
            }

            SWAPIService swapiService = new SWAPIService();

            Person personTwo = swapiService.GetPersonAsync(5).Result;
            if(personTwo != null)
            {
                Console.WriteLine(personTwo.Name);
                foreach(string vehicleUrl in personTwo.Vehicles)
                {
                    Vehicle vehicle = swapiService.GetVehicleAsync(vehicleUrl).Result;
                    Console.WriteLine(vehicle.Name);
                }
            }
          


            // Generic request to send an object and get it back
            Vehicle genericRepsonse = swapiService.GetAsync<Vehicle>("http://swapi.dev/api/vehicles/4/").Result;

            if (genericRepsonse != null)
            {
                Console.WriteLine(genericRepsonse.Name);
            }
            else
                Console.WriteLine("No Vehicles exist here");



            SearchResult<Person> skywalkers = swapiService.GetPersonSearchAsync("Skywalker").Result;
            Console.WriteLine(skywalkers.Count);

            foreach(Person personResult in skywalkers.Results)
            {
                Console.WriteLine(personResult.Name);
            }



            SearchResult<Vehicle> starfighters = swapiService.GetVehicleSearchAsync("starfighter").Result;
            Console.WriteLine(starfighters.Count);

            foreach(Vehicle vehicleResult in starfighters.Results)
            {
                Console.WriteLine(vehicleResult.Name);
            }

            Console.ReadLine();
        }
    }
}
