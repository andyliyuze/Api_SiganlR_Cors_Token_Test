using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace webApiToken
{
    class Program
    {
        static void Main(string[] args)
        {
            //string baseAddress = "http://localhost:50046/";

            //// Start OWIN host
            //using (WebApp.Start<Startup>(url: baseAddress))
            //{
            //    // Create HttpCient and make a request to api/values
            //    //HttpClient client = new HttpClient();

            //    //HttpResponseMessage response = client.GetAsync(baseAddress + "api/values").Result;

            //    Console.WriteLine("启动监听");
            //    //Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            //}
            const string uri = "http://localhost:50046/";

            using (WebApp.Start(uri, Startup.Configuration))
            {
                Console.WriteLine("Started listening on " + uri);
                Console.ReadLine();
                Console.WriteLine("Shutting down...");
            }
            Console.ReadLine();
        }
    }
}
