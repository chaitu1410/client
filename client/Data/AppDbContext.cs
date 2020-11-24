using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace client.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<SaleReturn> SaleReturns { get; set; }
        public DbSet<TotalSale> TotalSales { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
