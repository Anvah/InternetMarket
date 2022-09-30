using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class MarketContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Ad> Ads { get; set; }
        public DbSet<EmailCode> EmailCodes { get; set; }
        public MarketContext(DbContextOptions<MarketContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
