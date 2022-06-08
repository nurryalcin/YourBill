using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //context:db tabloları ile proje classlarını bağlar.
    public class NortWindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-LR94RRE;Database=NortWind;Trusted_Connection=true");
        }
        public DbSet <Product> Products { get; set; }
        public DbSet<Adisyon> Adisyons { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet <City>Cities { get; set; }
        public DbSet<District> Districties { get; set; }
        public DbSet<BillImage> BillImages { get; set; }
      





    }

}
