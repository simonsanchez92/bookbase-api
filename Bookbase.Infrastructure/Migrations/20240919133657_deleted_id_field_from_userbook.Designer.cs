﻿// <auto-generated />
using System;
using Bookbase.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bookbase.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240919133657_deleted_id_field_from_userbook")]
    partial class deleted_id_field_from_userbook
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Bookbase.Domain.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("book_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("author");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("text")
                        .HasColumnName("cover_url");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean")
                        .HasColumnName("deleted");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int?>("PageCount")
                        .HasColumnType("integer")
                        .HasColumnName("pages");

                    b.Property<int?>("PublishDate")
                        .HasColumnType("integer")
                        .HasColumnName("publish_date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "J.R.R. Tolkien",
                            CoverUrl = "https://example.com/hobbit.jpg",
                            Deleted = false,
                            Description = "A fantasy novel about a hobbit's adventure.",
                            PageCount = 310,
                            PublishDate = 1937,
                            Title = "The Hobbit"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Frank Herbert",
                            CoverUrl = "https://example.com/dune.jpg",
                            Deleted = false,
                            Description = "A science fiction novel set on a desert planet.",
                            PageCount = 412,
                            PublishDate = 1965,
                            Title = "Dune"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Arthur Conan Doyle",
                            CoverUrl = "https://example.com/hound.jpg",
                            Deleted = false,
                            Description = "A mystery novel featuring Sherlock Holmes.",
                            PageCount = 256,
                            PublishDate = 1902,
                            Title = "The Hound of the Baskervilles"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Bram Stoker",
                            CoverUrl = "https://example.com/dracula.jpg",
                            Deleted = false,
                            Description = "A horror novel about Count Dracula.",
                            PageCount = 418,
                            PublishDate = 1897,
                            Title = "Dracula"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Jane Austen",
                            CoverUrl = "https://example.com/pride.jpg",
                            Deleted = false,
                            Description = "A classic romance novel about Elizabeth Bennet.",
                            PageCount = 279,
                            PublishDate = 1813,
                            Title = "Pride and Prejudice"
                        },
                        new
                        {
                            Id = 6,
                            Author = "F. Scott Fitzgerald",
                            CoverUrl = "https://example.com/gatsby.jpg",
                            Deleted = false,
                            Description = "A fiction novel about the American dream.",
                            PageCount = 180,
                            PublishDate = 1925,
                            Title = "The Great Gatsby"
                        },
                        new
                        {
                            Id = 7,
                            Author = "George Orwell",
                            CoverUrl = "https://example.com/1984.jpg",
                            Deleted = false,
                            Description = "A dystopian novel about totalitarianism.",
                            PageCount = 328,
                            PublishDate = 1949,
                            Title = "1984"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Cormac McCarthy",
                            CoverUrl = "https://example.com/road.jpg",
                            Deleted = false,
                            Description = "A novel about a father and son surviving in a post-apocalyptic world.",
                            PageCount = 241,
                            PublishDate = 2006,
                            Title = "The Road"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Walter Isaacson",
                            CoverUrl = "https://example.com/jobs.jpg",
                            Deleted = false,
                            Description = "A biography of the co-founder of Apple.",
                            PageCount = 656,
                            PublishDate = 2011,
                            Title = "Steve Jobs"
                        },
                        new
                        {
                            Id = 10,
                            Author = "Yuval Noah Harari",
                            CoverUrl = "https://example.com/sapiens.jpg",
                            Deleted = false,
                            Description = "A history of humankind.",
                            PageCount = 443,
                            PublishDate = 2011,
                            Title = "Sapiens"
                        },
                        new
                        {
                            Id = 11,
                            Author = "Dale Carnegie",
                            CoverUrl = "https://example.com/win.jpg",
                            Deleted = false,
                            Description = "A classic self-help book on communication.",
                            PageCount = 288,
                            PublishDate = 1936,
                            Title = "How to Win Friends and Influence People"
                        },
                        new
                        {
                            Id = 12,
                            Author = "Eric Ries",
                            CoverUrl = "https://example.com/lean.jpg",
                            Deleted = false,
                            Description = "A guide to startups and innovation.",
                            PageCount = 336,
                            PublishDate = 2011,
                            Title = "The Lean Startup"
                        },
                        new
                        {
                            Id = 13,
                            Author = "Paulo Coelho",
                            CoverUrl = "https://example.com/alchemist.jpg",
                            Deleted = false,
                            Description = "A novel about following dreams.",
                            PageCount = 208,
                            PublishDate = 1988,
                            Title = "The Alchemist"
                        },
                        new
                        {
                            Id = 14,
                            Author = "Stephen King",
                            CoverUrl = "https://example.com/shining.jpg",
                            Deleted = false,
                            Description = "A horror novel about a haunted hotel.",
                            PageCount = 447,
                            PublishDate = 1977,
                            Title = "The Shining"
                        },
                        new
                        {
                            Id = 15,
                            Author = "Gillian Flynn",
                            CoverUrl = "https://example.com/gonegirl.jpg",
                            Deleted = false,
                            Description = "A thriller about a woman's disappearance.",
                            PageCount = 432,
                            PublishDate = 2012,
                            Title = "Gone Girl"
                        },
                        new
                        {
                            Id = 16,
                            Author = "Stephen Hawking",
                            CoverUrl = "https://example.com/briefhistory.jpg",
                            Deleted = false,
                            Description = "A book on cosmology and black holes.",
                            PageCount = 256,
                            PublishDate = 1988,
                            Title = "A Brief History of Time"
                        },
                        new
                        {
                            Id = 17,
                            Author = "Harper Lee",
                            CoverUrl = "https://example.com/mockingbird.jpg",
                            Deleted = false,
                            Description = "A novel about racial injustice in the South.",
                            PageCount = 281,
                            PublishDate = 1960,
                            Title = "To Kill a Mockingbird"
                        },
                        new
                        {
                            Id = 18,
                            Author = "J.D. Salinger",
                            CoverUrl = "https://example.com/catcher.jpg",
                            Deleted = false,
                            Description = "A novel about adolescent angst.",
                            PageCount = 234,
                            PublishDate = 1951,
                            Title = "The Catcher in the Rye"
                        },
                        new
                        {
                            Id = 19,
                            Author = "Sun Tzu",
                            CoverUrl = "https://example.com/artofwar.jpg",
                            Deleted = false,
                            Description = "An ancient Chinese text on military strategy.",
                            PageCount = 68,
                            PublishDate = -500,
                            Title = "The Art of War"
                        },
                        new
                        {
                            Id = 20,
                            Author = "Andy Weir",
                            CoverUrl = "https://example.com/martian.jpg",
                            Deleted = false,
                            Description = "A science fiction novel about survival on Mars.",
                            PageCount = 369,
                            PublishDate = 2011,
                            Title = "The Martian"
                        });
                });

            modelBuilder.Entity("Bookbase.Domain.Models.BookGenre", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("integer")
                        .HasColumnName("book_id");

                    b.Property<int>("GenreId")
                        .HasColumnType("integer")
                        .HasColumnName("genre_id");

                    b.HasKey("BookId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("book_genre");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            GenreId = 1
                        },
                        new
                        {
                            BookId = 2,
                            GenreId = 2
                        },
                        new
                        {
                            BookId = 3,
                            GenreId = 3
                        },
                        new
                        {
                            BookId = 4,
                            GenreId = 4
                        },
                        new
                        {
                            BookId = 5,
                            GenreId = 6
                        },
                        new
                        {
                            BookId = 6,
                            GenreId = 5
                        },
                        new
                        {
                            BookId = 7,
                            GenreId = 2
                        },
                        new
                        {
                            BookId = 8,
                            GenreId = 7
                        },
                        new
                        {
                            BookId = 9,
                            GenreId = 8
                        },
                        new
                        {
                            BookId = 10,
                            GenreId = 10
                        },
                        new
                        {
                            BookId = 11,
                            GenreId = 9
                        },
                        new
                        {
                            BookId = 12,
                            GenreId = 10
                        },
                        new
                        {
                            BookId = 13,
                            GenreId = 1
                        },
                        new
                        {
                            BookId = 14,
                            GenreId = 4
                        },
                        new
                        {
                            BookId = 15,
                            GenreId = 3
                        },
                        new
                        {
                            BookId = 16,
                            GenreId = 10
                        },
                        new
                        {
                            BookId = 17,
                            GenreId = 1
                        },
                        new
                        {
                            BookId = 18,
                            GenreId = 1
                        },
                        new
                        {
                            BookId = 19,
                            GenreId = 10
                        },
                        new
                        {
                            BookId = 20,
                            GenreId = 2
                        });
                });

            modelBuilder.Entity("Bookbase.Domain.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("genre_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "fantasy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Fiction"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Short Story"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Biography"
                        },
                        new
                        {
                            Id = 9,
                            Name = "self-help"
                        },
                        new
                        {
                            Id = 10,
                            Name = "History"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Technology"
                        });
                });

            modelBuilder.Entity("Bookbase.Domain.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("role_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "user"
                        });
                });

            modelBuilder.Entity("Bookbase.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean")
                        .HasColumnName("deleted");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("role_id");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Bookbase.Domain.Models.UserBook", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.Property<int>("BookId")
                        .HasColumnType("integer")
                        .HasColumnName("book_id");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("status");

                    b.HasKey("UserId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("user_book");
                });

            modelBuilder.Entity("Bookbase.Domain.Models.BookGenre", b =>
                {
                    b.HasOne("Bookbase.Domain.Models.Book", "Book")
                        .WithMany("BookGenres")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookbase.Domain.Models.Genre", "Genre")
                        .WithMany("BookGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Bookbase.Domain.Models.User", b =>
                {
                    b.HasOne("Bookbase.Domain.Models.Role", "role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("role");
                });

            modelBuilder.Entity("Bookbase.Domain.Models.UserBook", b =>
                {
                    b.HasOne("Bookbase.Domain.Models.Book", "Book")
                        .WithMany("UserBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookbase.Domain.Models.User", "User")
                        .WithMany("UserBooks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bookbase.Domain.Models.Book", b =>
                {
                    b.Navigation("BookGenres");

                    b.Navigation("UserBooks");
                });

            modelBuilder.Entity("Bookbase.Domain.Models.Genre", b =>
                {
                    b.Navigation("BookGenres");
                });

            modelBuilder.Entity("Bookbase.Domain.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Bookbase.Domain.Models.User", b =>
                {
                    b.Navigation("UserBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
