using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {

        public static void KanyeAndRon()
        {

                Thread.Sleep(2000);
                Console.WriteLine("Kanye and Ron love to talk about the more ethereal side of things; I wonder what they are going to talk about today... \n");
            for (int i = 0; i < 5; i++)
            {


                var client = new HttpClient();

                var client_2 = new HttpClient();

                var kanyeURL = "https://api.kanye.rest/";

                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

                var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

                var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

                var ronResponse = client_2.GetStringAsync(ronURL).Result;

                var ronQuote = JArray.Parse(ronResponse).First.ToString();
                //var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Replace('"', ' ').Trim; -- this is another method to get a similar result.

                Console.Write(". ");
                Thread.Sleep(500);
                Console.Write(". ");
                Thread.Sleep(500);
                Console.Write(". \n\n");
                Thread.Sleep(2000);
                Console.WriteLine($"Kanye says to Ron, '{kanyeQuote}'\n");
                Thread.Sleep(2000);
                Console.WriteLine($"Ron replies to Kanye, '{ronQuote}'\n\n");
                Console.Write(". ");
                Thread.Sleep(250);
                Console.Write(". ");
                Thread.Sleep(250);
                Console.Write(". ");
                Thread.Sleep(500);

            }
            Console.WriteLine("Man, that was powerful...\n\n (sigh)\nI could cry.\n\n");
            Console.WriteLine("------------------------------\n\n\n");
            Thread.Sleep(2000);
            Console.WriteLine("How many conversations with Kanye and Ron would it take to make life just a bit easier?");
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". \n\n");
            Console.WriteLine("The world may never know.");



        }
    }
}

