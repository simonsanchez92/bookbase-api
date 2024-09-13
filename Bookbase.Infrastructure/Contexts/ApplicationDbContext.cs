using Bookbase.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookbase.Infrastructure.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }


        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data can be configured here.
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "admin" },
                new Role { Id = 2, Name = "user" }
            );

            modelBuilder.Entity<Genre>().HasData(
             new Genre { Id = 1, Name = "fantasy" },
             new Genre { Id = 2, Name = "Science Fiction" },
             new Genre { Id = 3, Name = "Mystery" },
             new Genre { Id = 4, Name = "Horror" },
             new Genre { Id = 5, Name = "Fiction" },
             new Genre { Id = 6, Name = "Romance" },
             new Genre { Id = 7, Name = "Short Story" },
             new Genre { Id = 8, Name = "Biography" },
             new Genre { Id = 9, Name = "self-help" },
             new Genre { Id = 10, Name = "History" },
             new Genre { Id = 11, Name = "Technology" }
         );

            // Configure the composite key for the join table
            modelBuilder.Entity<UserBook>()
              .HasKey(ub => new { ub.UserId, ub.BookId });

            //Configure the relationship
            modelBuilder.Entity<UserBook>()
                .HasOne(ub => ub.User)
                .WithMany(b => b.UserBooks)
                .HasForeignKey(ub => ub.UserId);

            modelBuilder.Entity<UserBook>()
                .HasOne(ub => ub.Book)
                .WithMany(b => b.UserBooks)
                .HasForeignKey(ub => ub.BookId);



            // Configure the composite key for the BookGenre join table
            modelBuilder.Entity<BookGenre>()
                .HasKey(bg => new { bg.BookId, bg.GenreId });

            //Configure the relationship
            modelBuilder.Entity<BookGenre>()
                .HasOne(bg => bg.Book)
                .WithMany(b => b.BookGenres)
                .HasForeignKey(bg => bg.BookId);

            modelBuilder.Entity<BookGenre>()
                .HasOne(bg => bg.Genre)
                .WithMany(b => b.BookGenres)
                .HasForeignKey(bg => bg.GenreId);
        }
    }
}
