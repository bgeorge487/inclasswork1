using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AnimeNerdApp.Models
{
    public class AnimeContext : DbContext
    {

        public DbSet<Anime> Anime { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-4UGD5KM;Database=AnimeDb;Trusted_Connection=True;");
        }
    }
}
