
using Microsoft.EntityFrameworkCore;
using HumanResources.Domain.Absract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResources.Data.Mapping
{
    public abstract class AccountInfoMapping<T> : IEntityTypeConfiguration<T> where T : AccountInfo
    {
        public abstract void ConfigureDerivedEntityMapping(EntityTypeBuilder<T> builder);
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Username);

            builder.Property(x => x.Username)
                .IsRequired()
                .HasColumnName("USER_NAME")
                .HasColumnType("nvarchar(20)")
                .HasColumnOrder(11);

            builder.Property(x=> x.Password)
                .IsRequired()
                .HasColumnName("PASSWORD")
                .HasColumnType("nvarchar(16)")
                .HasColumnOrder(12);
            
        }
    }




}
