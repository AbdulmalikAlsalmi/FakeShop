using FakeShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeShop.Infra
{
    public class FakeShopDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ServerName;Database=FakeShopDB;Encrypt=False;Trusted_Connection=True;");
        }
    }
}
