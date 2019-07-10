using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Modelo.Domain.Entities;
using Modelo.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Modelo.Infra.Data.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public SqlContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                             .SetBasePath(Directory.GetCurrentDirectory())
                             .AddJsonFile("appsettings.json")
                             .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Usuario
            modelBuilder.ApplyConfiguration(new LembreteMap());
            base.OnModelCreating(modelBuilder);
            //Lembrete
            modelBuilder.ApplyConfiguration(new LembreteMap());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> User { get; set; }
        public DbSet<Lembrete> Lembrete { get; set; }
    }
}

