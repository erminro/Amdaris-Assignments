using InernshipApplication.Web.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipApplication.Web.Infrastructure.Data
{
   public class DataContext: DbContext
    {
        public DbSet<Product> Products { get; set; } 
        public DbSet<Review> Reviews { get; set; } 
        public DbSet<Category> Categories { get; set; } 
        public DbSet<User> Users { get; set; }
        public DbSet<ProductsCategories> ProductsCategories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.\\SQLEXPRESS; Database = Internship1; Trusted_Connection = True; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithMany(p => p.Categories)
                .UsingEntity<ProductsCategories>(
                op => op.HasOne(x => x.Product).WithMany().HasForeignKey(x => x.Productid),
                op => op.HasOne(x => x.Category).WithMany().HasForeignKey(x => x.Categoryid)
                );

        }
    }
}
