using _125_MusicLibraryBinusTask.Model;
using Microsoft.EntityFrameworkCore;

namespace _125_MusicLibraryBinusTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Songs{ get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
