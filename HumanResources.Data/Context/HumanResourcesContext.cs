using HumanResources.Data.Mapping;
using HumanResources.Domain.Absract;
using HumanResources.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace HumanResources.Data.Context
{
    public class HumanResourcesContext : DbContext
    {
        // domain katmanındaki semalarımız DB bağlanmak ve nesnelerimizi yönetmek icin domain katmanı kurulur..


        public DbSet<Manager> Managers { get; set; }
        public DbSet<FrontEndPersonel> FrontEndPersonels { get; set; }
        public DbSet<BackEndPersonel> BackEndPersonels { get; set; }
        public DbSet<DesignerPersonel> DesignerPersonels { get; set; }

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=HumanResources.Data;Trusted_Connection=True;TrustServerCertificate=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AccountInfoMapping());
            modelBuilder.ApplyConfiguration(new BasePersonelMapping());

            modelBuilder.ApplyConfiguration(new FrontEndPersonelMapping());
            modelBuilder.ApplyConfiguration(new BackEndPersonelMapping());
            modelBuilder.ApplyConfiguration(new DesignerPersonelMapping());

        }

    }
}
