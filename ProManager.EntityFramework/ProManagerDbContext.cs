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

        public ProManagerDbContext(DbContextOptions options) : base(options) { }
    }
}
