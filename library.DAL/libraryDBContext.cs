using Microsoft.EntityFrameworkCore;
using library.BE.Models;

namespace library.DAL
{
    public class libraryDBContext : DbContext
    {
        public libraryDBContext(DbContextOptions<libraryDBContext> options) : base(options) { }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
