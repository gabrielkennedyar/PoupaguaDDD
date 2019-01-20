using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace PoupaguaDDD.Infra.Data.Context
{
    public class PoupaguaContextConfiguration : DbConfiguration
    {
        public PoupaguaContextConfiguration()
        {
            this.SetDatabaseInitializer(new DropCreateDatabaseAlways<PoupaguaContext>());
            this.SetProviderServices(SqlProviderServices.ProviderInvariantName, SqlProviderServices.Instance);
        }
    }
}
