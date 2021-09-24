using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        //constructor. the options for the class are being taken from the base class (DbContext)
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        // property of class DataContext
        public DbSet<Activity> Activities { get; set; }
    }
}