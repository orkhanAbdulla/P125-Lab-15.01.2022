using FiorelloP125.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloP125.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<FlowerImage> FlowerImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FlowerCategory> FlowerCategories { get; set; }
        public DbSet<Compaign> Compaigns { get; set; }




    }
}
