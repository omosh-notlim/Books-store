using Microsoft.EntityFrameworkCore;
using AmazonBooks.Models;

namespace AmazonBooks.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){

        }

        //Defining the DbSet properties
        public DbSet<BooksEntity> Books { get; set; }
    }
}