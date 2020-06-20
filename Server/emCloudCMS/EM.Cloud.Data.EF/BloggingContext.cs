using EM.Cloud.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EM.Cloud.Data.EF
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8MD6M17\\SQLEXPRESS;Database=emCloudCMS;Integrated Security=true;");
                //@"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // add your own configuration here
        //}
    }
}
