using Microsoft.EntityFrameworkCore;

namespace Library.Models{

    public class LibraryDbContext : DbContext{
        public LibraryDbContext(DbContextOptions<LibraryDbContext> data)
        :base (data){}


        public DbSet<Author> Authors{get; set;}
        public DbSet<Book> Books{get; set;}
       
        

    }
}