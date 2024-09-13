using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookbase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class booksgenresupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookGenres_books_BookId",
                table: "BookGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenres_genres_GenreId",
                table: "BookGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookGenres",
                table: "BookGenres");

            migrationBuilder.RenameTable(
                name: "BookGenres",
                newName: "book_genre");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "book_genre",
                newName: "genre_id");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "book_genre",
                newName: "book_id");

            migrationBuilder.RenameIndex(
                name: "IX_BookGenres_GenreId",
                table: "book_genre",
                newName: "IX_book_genre_genre_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_book_genre",
                table: "book_genre",
                columns: new[] { "book_id", "genre_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_book_genre_books_book_id",
                table: "book_genre",
                column: "book_id",
                principalTable: "books",
                principalColumn: "book_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_book_genre_genres_genre_id",
                table: "book_genre",
                column: "genre_id",
                principalTable: "genres",
                principalColumn: "genre_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_book_genre_books_book_id",
                table: "book_genre");

            migrationBuilder.DropForeignKey(
                name: "FK_book_genre_genres_genre_id",
                table: "book_genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_book_genre",
                table: "book_genre");

            migrationBuilder.RenameTable(
                name: "book_genre",
                newName: "BookGenres");

            migrationBuilder.RenameColumn(
                name: "genre_id",
                table: "BookGenres",
                newName: "GenreId");

            migrationBuilder.RenameColumn(
                name: "book_id",
                table: "BookGenres",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_book_genre_genre_id",
                table: "BookGenres",
                newName: "IX_BookGenres_GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookGenres",
                table: "BookGenres",
                columns: new[] { "BookId", "GenreId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenres_books_BookId",
                table: "BookGenres",
                column: "BookId",
                principalTable: "books",
                principalColumn: "book_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenres_genres_GenreId",
                table: "BookGenres",
                column: "GenreId",
                principalTable: "genres",
                principalColumn: "genre_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
