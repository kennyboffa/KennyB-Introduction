using Microsoft.EntityFrameworkCore;
using KennyB.Models;

namespace KennyB.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Comment> Comments { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
           
        //}
    }
}