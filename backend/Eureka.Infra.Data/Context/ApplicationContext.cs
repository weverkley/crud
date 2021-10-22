using Eureka.Domain.Model;
using Eureka.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Eureka.Infra.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Crud> Cruds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CrudConfiguration());
        }
    }
}