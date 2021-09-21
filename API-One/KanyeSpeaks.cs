using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace API_One
{
    public class KanyeSpeaks
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine("**********************");
            Console.WriteLine($"Kanye: {kanyeQuote}");
            Console.WriteLine("**********************");
        }
    }
}
