using System;
using Nancy.Hosting.Self;
using Stored.Demo.Setup;

namespace Stored.Demo
{
    class Program
    {
      
        static void Main(string[] args)
        {
            HostConfiguration config = new HostConfiguration();
            config.UrlReservations.CreateAutomatically = true;

            using (var host = new NancyHost(config, new Uri("http://localhost:1234")))
            {
                host.Start();
                Seed.Run(Database.ConnectionString());
                Console.ReadLine();
            }
        }
    }
}
