using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Unicore.Services.Entities;

namespace Unicore.Services.DBContexts
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<UnicoreFarm> UnicoreFarm { get; set; }
    }
}
