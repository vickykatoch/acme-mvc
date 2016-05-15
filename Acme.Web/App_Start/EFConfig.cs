using Acme.Data;
using System.Data.Entity;

namespace Acme.Web
{
    public static class EFConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AcmeContext>());
        }
    }
}
