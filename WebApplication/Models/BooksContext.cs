using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _7
{
    public partial class BooksContext : DbContext
    {
        public BooksContext()
        {
        }

        public BooksContext(DbContextOptions<BooksContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
               optionsBuilder.UseLazyLoadingProxies();
               optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=task7;Trusted_Connection=True;");
            }
        }

       
    }
}
