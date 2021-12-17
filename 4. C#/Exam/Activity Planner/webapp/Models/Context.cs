using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace webapp.Models {
    public class Context : DbContext {

        public Context(DbContextOptions options) : base(options) {}
        
        public DbSet<User> Users { get; set; }
        
        public DbSet<RSVP> RSVPs { get; set; }
        public DbSet<Activity> Activities { get; set; }

    }
}