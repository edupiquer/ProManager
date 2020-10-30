using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProManager.EntityFramework
{
    public class ProManagerDbContextFactory : IDesignTimeDbContextFactory<ProManagerDbContext>
    {
        public ProManagerDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<ProManagerDbContext>();
            options.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProManager; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            return new ProManagerDbContext(options.Options);
        }
    }
}
