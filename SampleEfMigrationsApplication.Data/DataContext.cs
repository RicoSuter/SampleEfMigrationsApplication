using System.Data.Entity;

namespace SampleEfMigrationsApplication.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
