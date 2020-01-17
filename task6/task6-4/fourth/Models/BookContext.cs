using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fourth.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookKind> BookKinds { get; set; }

        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=bookshopdb;Trusted_Connection=True;");
    }
}
