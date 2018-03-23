using core_manager.Models;
using System.Data.Entity;

namespace core_manager.Contexts
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class _dbContext : DbContext
    {
        public _dbContext() : base(nameOrConnectionString: "MainConnection") { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}