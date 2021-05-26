using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_API_Implementation
{
    class JokeService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<Joke> getJoke(string category)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"https://v2.jokeapi.dev/joke/{category}");

            if (response.IsSuccessStatusCode)
            {
                Joke myJoke = await response.Content.ReadAsAsync<Joke>();
                return myJoke;
            }
            return null;
        }

    }
}
