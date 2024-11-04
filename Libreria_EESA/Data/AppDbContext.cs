using libreria_EESA.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace libreria_EESA.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
