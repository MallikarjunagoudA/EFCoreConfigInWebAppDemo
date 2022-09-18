using EFCoreWebAppDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreWebAppDemo
{
    public class EFcoreDbContext : DbContext
    {
        public EFcoreDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> student {get; set;}
    }
}
