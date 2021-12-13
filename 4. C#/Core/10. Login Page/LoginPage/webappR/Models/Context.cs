using Microsoft.EntityFrameworkCore;

namespace webappR.Models {
    public class Context : DbContext {
        public Context(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        

    }
}