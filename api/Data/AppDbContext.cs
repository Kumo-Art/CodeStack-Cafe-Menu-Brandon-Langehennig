using System.Security.Cryptography.X509Certificates;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Categories> Categories {get;set;}

        public DbSet<Items> Items {get;set;}

        public DbSet<Restaurant> Restaurant {get;set;}
    }
}