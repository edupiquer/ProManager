using Microsoft.EntityFrameworkCore;
using ProManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProManager.EntityFramework
{
    public class ProManagerDbContext : DbContext
    {
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Person> People { get; set; }        
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProManager; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
