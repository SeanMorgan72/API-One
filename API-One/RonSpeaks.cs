using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace API_One
{
    public class RonSpeaks
    {
        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine("**********************");
            Console.WriteLine($"Ron: {ronQuote}");
            Console.WriteLine("**********************");

        }
    }
}
