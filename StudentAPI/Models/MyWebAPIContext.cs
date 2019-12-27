using System;
using Microsoft.EntityFrameworkCore;
namespace StudentAPI.Models
{
    public class MyWebAPIContext:DbContext
    {
        public MyWebAPIContext(DbContextOptions<MyWebAPIContext> options ):base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Group { get; set; }
    }
}
