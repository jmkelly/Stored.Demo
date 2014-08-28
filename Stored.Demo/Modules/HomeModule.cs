using System;
using Nancy;
using Stored.Demo.Models;

namespace Stored.Demo.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule(IStore store)
        {
            Get["/"] = param =>
            {
                return "hello world";
            };

            Get["/garages"] = _ =>
                {
                   using (var session = store.CreateSession())
                   {
                       var data = session.All<Garage>();
                       return Response.AsJson(data);
                   }
                };
        }
    }
}
