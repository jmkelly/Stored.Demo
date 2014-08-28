using Stored.Postgres;

namespace Stored.Demo.Setup
{
    public class DefaultStore : PostgresStore
    {
        public DefaultStore()
            : base(Database.ConnectionString())
        {
        }
    }
}
