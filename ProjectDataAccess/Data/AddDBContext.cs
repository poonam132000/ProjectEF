using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectModels;
using ProjectModels.Models;

namespace ProjectDataAccess.Data
{
    public class AddDBContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }

        public DbSet<Categories> Category { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }


        //Connection set up
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-MGIBAHI;Database=PracticeEF;TrustServerCertificate=True;Trusted_Connection=True;");
            }

        //Seed data in genre table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre{ GenreId = 1, GenreName="First",Display=1}
            );
        }
    }
}
