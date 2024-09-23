using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bookbase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initialMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    book_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    author = table.Column<string>(type: "text", nullable: false),
                    publish_date = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    cover_url = table.Column<string>(type: "text", nullable: false),
                    pages = table.Column<int>(type: "integer", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.book_id);
                });

            migrationBuilder.CreateTable(
                name: "genres",
                columns: table => new
                {
                    genre_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genres", x => x.genre_id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    role_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.role_id);
                });

            migrationBuilder.CreateTable(
                name: "book_genre",
                columns: table => new
                {
                    book_id = table.Column<int>(type: "integer", nullable: false),
                    genre_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book_genre", x => new { x.book_id, x.genre_id });
                    table.ForeignKey(
                        name: "FK_book_genre_books_book_id",
                        column: x => x.book_id,
                        principalTable: "books",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_book_genre_genres_genre_id",
                        column: x => x.genre_id,
                        principalTable: "genres",
                        principalColumn: "genre_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    role_id = table.Column<int>(type: "integer", nullable: false),
                    deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_users_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "roles",
                        principalColumn: "role_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_book",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    book_id = table.Column<int>(type: "integer", nullable: false),
                    user_book_id = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_book", x => new { x.user_id, x.book_id });
                    table.ForeignKey(
                        name: "FK_user_book_books_book_id",
                        column: x => x.book_id,
                        principalTable: "books",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_book_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "book_id", "author", "cover_url", "deleted", "description", "pages", "publish_date", "title" },
                values: new object[,]
                {
                    { 1, "J.R.R. Tolkien", "https://example.com/hobbit.jpg", false, "A fantasy novel about a hobbit's adventure.", 310, 1937, "The Hobbit" },
                    { 2, "Frank Herbert", "https://example.com/dune.jpg", false, "A science fiction novel set on a desert planet.", 412, 1965, "Dune" },
                    { 3, "Arthur Conan Doyle", "https://example.com/hound.jpg", false, "A mystery novel featuring Sherlock Holmes.", 256, 1902, "The Hound of the Baskervilles" },
                    { 4, "Bram Stoker", "https://example.com/dracula.jpg", false, "A horror novel about Count Dracula.", 418, 1897, "Dracula" },
                    { 5, "Jane Austen", "https://example.com/pride.jpg", false, "A classic romance novel about Elizabeth Bennet.", 279, 1813, "Pride and Prejudice" },
                    { 6, "F. Scott Fitzgerald", "https://example.com/gatsby.jpg", false, "A fiction novel about the American dream.", 180, 1925, "The Great Gatsby" },
                    { 7, "George Orwell", "https://example.com/1984.jpg", false, "A dystopian novel about totalitarianism.", 328, 1949, "1984" },
                    { 8, "Cormac McCarthy", "https://example.com/road.jpg", false, "A novel about a father and son surviving in a post-apocalyptic world.", 241, 2006, "The Road" },
                    { 9, "Walter Isaacson", "https://example.com/jobs.jpg", false, "A biography of the co-founder of Apple.", 656, 2011, "Steve Jobs" },
                    { 10, "Yuval Noah Harari", "https://example.com/sapiens.jpg", false, "A history of humankind.", 443, 2011, "Sapiens" },
                    { 11, "Dale Carnegie", "https://example.com/win.jpg", false, "A classic self-help book on communication.", 288, 1936, "How to Win Friends and Influence People" },
                    { 12, "Eric Ries", "https://example.com/lean.jpg", false, "A guide to startups and innovation.", 336, 2011, "The Lean Startup" },
                    { 13, "Paulo Coelho", "https://example.com/alchemist.jpg", false, "A novel about following dreams.", 208, 1988, "The Alchemist" },
                    { 14, "Stephen King", "https://example.com/shining.jpg", false, "A horror novel about a haunted hotel.", 447, 1977, "The Shining" },
                    { 15, "Gillian Flynn", "https://example.com/gonegirl.jpg", false, "A thriller about a woman's disappearance.", 432, 2012, "Gone Girl" },
                    { 16, "Stephen Hawking", "https://example.com/briefhistory.jpg", false, "A book on cosmology and black holes.", 256, 1988, "A Brief History of Time" },
                    { 17, "Harper Lee", "https://example.com/mockingbird.jpg", false, "A novel about racial injustice in the South.", 281, 1960, "To Kill a Mockingbird" },
                    { 18, "J.D. Salinger", "https://example.com/catcher.jpg", false, "A novel about adolescent angst.", 234, 1951, "The Catcher in the Rye" },
                    { 19, "Sun Tzu", "https://example.com/artofwar.jpg", false, "An ancient Chinese text on military strategy.", 68, -500, "The Art of War" },
                    { 20, "Andy Weir", "https://example.com/martian.jpg", false, "A science fiction novel about survival on Mars.", 369, 2011, "The Martian" }
                });

            migrationBuilder.InsertData(
                table: "genres",
                columns: new[] { "genre_id", "name" },
                values: new object[,]
                {
                    { 1, "fantasy" },
                    { 2, "Science Fiction" },
                    { 3, "Mystery" },
                    { 4, "Horror" },
                    { 5, "Fiction" },
                    { 6, "Romance" },
                    { 7, "Short Story" },
                    { 8, "Biography" },
                    { 9, "self-help" },
                    { 10, "History" },
                    { 11, "Technology" }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "role_id", "name" },
                values: new object[,]
                {
                    { 1, "admin" },
                    { 2, "user" }
                });

            migrationBuilder.InsertData(
                table: "book_genre",
                columns: new[] { "book_id", "genre_id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 6 },
                    { 6, 5 },
                    { 7, 2 },
                    { 8, 7 },
                    { 9, 8 },
                    { 10, 10 },
                    { 11, 9 },
                    { 12, 10 },
                    { 13, 1 },
                    { 14, 4 },
                    { 15, 3 },
                    { 16, 10 },
                    { 17, 1 },
                    { 18, 1 },
                    { 19, 10 },
                    { 20, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_book_genre_genre_id",
                table: "book_genre",
                column: "genre_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_book_book_id",
                table: "user_book",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_users_role_id",
                table: "users",
                column: "role_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "book_genre");

            migrationBuilder.DropTable(
                name: "user_book");

            migrationBuilder.DropTable(
                name: "genres");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "roles");
        }
    }
}
