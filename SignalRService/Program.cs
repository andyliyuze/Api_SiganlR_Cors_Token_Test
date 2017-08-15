using System;
using Microsoft.Owin.Hosting;


namespace SignalRService
{
    class Program
    {
        static void Main(string[] args)
        {

            const string uri = "http://localhost:52026/";
      
            using (WebApp.Start(uri))
            {
                Console.WriteLine("Started listening on " + uri);
                Console.ReadLine();
            }
          
        }
    }
}
