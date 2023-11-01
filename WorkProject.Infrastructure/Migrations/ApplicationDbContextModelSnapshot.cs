﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkProject.Infrastructure.Context;

#nullable disable

namespace WorkProject.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WorkProject.Domain.Models.CustomModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Code");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("Is_Active");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("link");

                    b.HasKey("Id")
                        .HasName("PK_CustomId");

                    b.ToTable("Custom");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "abc123",
                            CreatedDate = new DateTime(2023, 10, 29, 10, 45, 43, 254, DateTimeKind.Utc).AddTicks(4638),
                            IsActive = false,
                            link = "www.google.com"
                        },
                        new
                        {
                            Id = 2,
                            Code = "def456",
                            CreatedDate = new DateTime(2023, 10, 29, 10, 45, 43, 254, DateTimeKind.Utc).AddTicks(4641),
                            IsActive = false,
                            link = "www.yahoo.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}