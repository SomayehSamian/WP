using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkProject.Domain.Models;

namespace WorkProject.Infrastructure.Mapper
{
    public class CustomMap : IEntityTypeConfiguration<CustomModel>
    {
        public void Configure(EntityTypeBuilder<CustomModel> builder)
        {
            builder.HasKey(x => x.Id).HasName("PK_CustomId");
            builder.Property(x => x.Id).ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");

            builder.Property(x => x.Code)
                .HasColumnName("Code")
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            builder.Property(x => x.link)
                .HasColumnName("link")
                .HasColumnType("nvarchar(100)")
                .IsRequired();

            //builder.Property(x => x.CreatedDate)
            //    .HasColumnName("Created_Date")
            //    .HasColumnType("datetime");

            //builder.Property(x => x.ModifiedDate)
            //    .HasColumnName("Modified_Date")
            //    .HasColumnType("datetime");


            builder.Property(x => x.IsActive)
                .HasColumnName("Is_Active")
                .HasColumnType("bit");

        }
    }
}
