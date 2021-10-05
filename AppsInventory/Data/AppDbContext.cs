using AppsInventory.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsInventory.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        { 
            
        }

        public DbSet<ConfigList> ConfigLists { get; set; }
        public DbSet<ConfigItem> ConfigItem { get; set; }
    }
}
