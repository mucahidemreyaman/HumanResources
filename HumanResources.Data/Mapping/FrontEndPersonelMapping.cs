using HumanResources.Domain.Absract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResources.Domain.Entity;

namespace HumanResources.Data.Mapping
{
    public class FrontEndPersonelMapping : IEntityTypeConfiguration<BasePersonel>
    {



        public void Configure(EntityTypeBuilder<BasePersonel> builder)
        {

            builder.HasKey(x => x.PersonelId);
            builder.Property(x => x.PersonelId)
                .IsRequired()
                .HasColumnName("ID_PERSONEL")
                .HasColumnOrder(1);

            builder.Property(x => x.IdentityId)
                .IsRequired()
                .HasColumnName("IDENTITY_ID")
                .HasColumnType("nvarchar(30)")
                .HasColumnOrder(2);

            builder.Property(x => x.LoginDate)
                .IsRequired()
                .HasColumnName("LOGIN_DATE")
                .HasColumnType("nvarchar(30)")
                .HasColumnOrder(3);

            builder.Property(x => x.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasColumnType("nvarchar(50)")
                .HasColumnOrder(4);

            builder.Property(x => x.LastName)
           .HasColumnName("LAST_NAME")
           .HasColumnType("nvarchar(50)")
           .HasColumnOrder(5);

            builder.Property(x => x.Gender)
            .HasColumnName("GENDER")
            .HasColumnType("nvarchar(50)")
            .HasColumnOrder(6);

            builder.Property(x => x.Email)
           .HasColumnName("EMAIL")
           .HasColumnType("nvarchar(50)")
           .HasColumnOrder(7);

            builder.Property(x => x.Birthday)
           .HasColumnName("BIRTHDAY")
           .HasColumnType("nvarchar(30)")
           .HasColumnOrder(8);

            builder.Property(x => x.PermissionDays)
           .HasColumnName("PERMISSION_DAYS")
           .HasColumnType("nvarchar(10)")
           .HasColumnOrder(9);

            builder.Property(x => x.Salary)
           .HasColumnName("SALARY")
           .HasColumnType("nvarchar(10)")
           .HasColumnOrder(10);

        }
    }

}
