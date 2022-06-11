using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer
{
    public class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server = (localdb)\\MSSQLLocalDB; database = HotelsDb; integrated security = true;");
        }

        public DbSet<Hotel> Hotels { get; set; }

    }
}
