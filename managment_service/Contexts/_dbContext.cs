using managment_service.Models;
using System.Data.Entity;

namespace managment_service.Contexts
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class _dbContext : DbContext
    {
        public _dbContext() : base(nameOrConnectionString: "MainConnection") { }

        public DbSet<Country> Countries { get; set; }
    }
}