using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1
{
    public partial class bookshopdbContext : DbContext
    {
        public bookshopdbContext()
        {
        }

        public bookshopdbContext(DbContextOptions<bookshopdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookKinds> BookKinds { get; set; }
        public virtual DbSet<Books> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=bookshopdb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasIndex(e => e.TypeId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.TypeId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
