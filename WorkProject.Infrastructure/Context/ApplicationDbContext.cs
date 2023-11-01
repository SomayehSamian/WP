using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WorkProject.Domain.Models;
using WorkProject.Infrastructure.Mapper;

namespace WorkProject.Infrastructure.Context
{
    public class ApplicationDbContext:DbContext
    {
        #region Constrocter
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {

        }
        #endregion Constrocter
        public DbSet<CustomModel> Custom { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //.AddJsonFile("appsettings.json")
            //    .Build();

            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("myConn"));
           
           optionsBuilder.UseSqlServer("Server=.;Database=WorkProjectDb;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomMap());
            base.OnModelCreating(modelBuilder);
            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomModel>().HasData(
                new CustomModel { Id = 1, Code = "abc123", link = "www.google.com" },
                new CustomModel { Id = 2, Code = "def456", link = "www.yahoo.com" }
            );
        }
    }
}
