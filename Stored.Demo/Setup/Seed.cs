using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ploeh.AutoFixture;
using Stored;
using Stored.Postgres;
using Stored.Demo.Models;


namespace Stored.Demo.Setup
{
    public class Seed
    {
        public static void Run(string connectionString)
        {
            var fixture = new Fixture();
            var cars = fixture.CreateMany<Car>();
            var garages = fixture.CreateMany<Garage>();

            var store = new PostgresStore(connectionString);
            using (var session = store.CreateSession())
            {
                var existing  = session.Query<Garage>().Where(c => c.Capacity).NotEqual("0").ToList();
                session.DeleteAll<Garage>(existing);
                foreach (var garage in garages)
                {
                    session.Create<Garage>(garage);
                }

                session.Commit();
            }
        }
    }
}
