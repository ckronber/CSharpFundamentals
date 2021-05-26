using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_API_Implementation
{
    class Joke
    {
        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("setup")]
        public string Setup { get; set; }

        [JsonProperty("delivery")]
        public string Delivery { get; set; }

        [JsonProperty("flags")]
        public Flags Flags { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("safe")]
        public bool Safe { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }
    }
}
