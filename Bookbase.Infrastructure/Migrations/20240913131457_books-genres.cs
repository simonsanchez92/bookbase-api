using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bookbase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class booksgenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookGenre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_book",
                table: "user_book");

            migrationBuilder.DropIndex(
                name: "IX_user_book_user_id",
                table: "user_book");

            migrationBuilder.AlterColumn<int>(
                name: "user_book_id",
                table: "user_book",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_book",
                table: "user_book",
                columns: new[] { "user_id", "book_id" });

            migrationBuilder.CreateTable(
                name: "BookGenres",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    GenreId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenres", x => new { x.BookId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_BookGenres_books_BookId",
                        column: x => x.BookId,
                        principalTable: "books",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenres_genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "genres",
                        principalColumn: "genre_id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_BookGenres_GenreId",
                table: "BookGenres",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_book",
                table: "user_book");

            migrationBuilder.DeleteData(
                table: "genres",
                keyColumn: "genre_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "genres",
                keyColumn: "genre_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "genres",
                keyColumn: "genre_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "genres",
                keyColumn: "genre_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "genres",
                keyColumn: "genre_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "genres",
                keyColumn: "genre_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "genres",
                keyColumn: "genre_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "genres",
                keyColumn: "genre_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "genres",
                keyColumn: "genre_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "genres",
                keyColumn: "genre_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "genres",
                keyColumn: "genre_id",
                keyValue: 11);

            migrationBuilder.AlterColumn<int>(
                name: "user_book_id",
                table: "user_book",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_book",
                table: "user_book",
                column: "user_book_id");

            migrationBuilder.CreateTable(
                name: "BookGenre",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "integer", nullable: false),
                    GenresId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenre", x => new { x.BooksId, x.GenresId });
                    table.ForeignKey(
                        name: "FK_BookGenre_books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "books",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenre_genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "genres",
                        principalColumn: "genre_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_user_book_user_id",
                table: "user_book",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenre_GenresId",
                table: "BookGenre",
                column: "GenresId");
        }
    }
}
