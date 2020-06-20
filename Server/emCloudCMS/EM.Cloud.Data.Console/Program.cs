using em.cloud.data.dapper;
using EM.Cloud.Data.EF;
using EM.Cloud.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EM.Cloud.Data.DataConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var db = new BloggingContext())
            {
                db.Database.EnsureCreated();

                var testBlog = db.Blogs.FirstOrDefault(b => b.Url == "http://test2.com");
                if (testBlog == null)
                {
                    db.Blogs.Add(new Blog { Url = "http://test2.com", Rating = 4, Posts = new List<Post>() { new Post() { Title = "Test", Content = "test content" } } });
                }
                db.SaveChanges();

                var blogs = db.Blogs
                    .Where(b => b.Rating > 3)
                    .OrderBy(b => b.Url)
                    .ToList();


                DapperTest.GetBlogData();
            }
        }
    }
}
