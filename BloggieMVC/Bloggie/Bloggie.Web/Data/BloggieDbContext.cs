using Bloggie.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Web.Data
{
    public class BloggieDbContext: DbContext
    {
        //Constroctor
        public BloggieDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; } //Create table

        public DbSet<Tag> Tags { get; set; } // Create table
    }
}
