using Microsoft.EntityFrameworkCore;

namespace webapp.Models {
    public class Context : DbContext {

        public Context(DbContextOptions options) : base(options) {}
        public DbSet<User> Users { get; set; }

    }
}