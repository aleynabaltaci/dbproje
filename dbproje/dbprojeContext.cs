using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dbproje
{
    public class dbprojeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;database=Ecommerce;Trusted_Connection=true;");
        }
        public DbSet<Araba> Arabalar { get; set; } //SQLde böyle bi tablo oluşturduk.
    }
}
