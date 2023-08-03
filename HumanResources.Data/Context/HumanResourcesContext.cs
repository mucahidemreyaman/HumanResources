using HumanResources.Data.Mapping;
using HumanResources.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace HumanResources.Data.Context
{
    public class HumanResourcesContext : DbContext
    {
        // domain katmanındaki semalarımız DB bağlanmak ve nesnelerimizi yönetmek icin domain katmanı kurulur..


        DbSet<Manager> Managers { get; set; }
        DbSet<FrontEndPersonel>FrontEndPersonels { get; set; }
        DbSet<BackEndPersonel>BackEndPersonels { get; set;}
        DbSet<DesignerPersonel>DesignerPersonels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=HumanResources.Data;Trusted_Connection=True;TrustServerCertificate=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AccountInfoMapping());
        }

    }
}
