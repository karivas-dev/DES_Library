using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace library.DAL
{
    public class libraryDBContextFactory : IDesignTimeDbContextFactory<libraryDBContext>
    {
        public libraryDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<libraryDBContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=library;Trusted_Connection=True");

            return new libraryDBContext(optionsBuilder.Options);
        }
    }
}   
