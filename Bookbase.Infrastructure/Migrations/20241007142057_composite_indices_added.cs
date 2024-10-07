using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bookbase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class composite_indices_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "books",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    review_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    content = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    book_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviews", x => x.review_id);
                    table.ForeignKey(
                        name: "FK_reviews_books_book_id",
                        column: x => x.book_id,
                        principalTable: "books",
                        principalColumn: "book_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reviews_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    comment_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    content = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    review_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.comment_id);
                    table.ForeignKey(
                        name: "FK_comments_reviews_review_id",
                        column: x => x.review_id,
                        principalTable: "reviews",
                        principalColumn: "review_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_comments_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "likes",
                columns: table => new
                {
                    like_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    review_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_likes", x => x.like_id);
                    table.ForeignKey(
                        name: "FK_likes_reviews_review_id",
                        column: x => x.review_id,
                        principalTable: "reviews",
                        principalColumn: "review_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_likes_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 9,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 10,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 11,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 12,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 13,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 14,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 15,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 16,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 17,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 18,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 19,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 20,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 14, 20, 56, 358, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2024, 10, 7, 14, 20, 55, 880, DateTimeKind.Utc).AddTicks(6013), "$2a$11$shBMSmevqP1ZeKxR9cVH9OjnRH.ayIGo6F1xQIgx0wUug75QcyMw." });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 2,
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2024, 10, 7, 14, 20, 56, 117, DateTimeKind.Utc).AddTicks(5769), "$2a$11$KLymO1GAjbTrucxxyUAqOOyKMxrtcD4yzKsypNrBLb3030RFGv6si" });

            migrationBuilder.CreateIndex(
                name: "IX_user_book_user_id_book_id",
                table: "user_book",
                columns: new[] { "user_id", "book_id" });

            migrationBuilder.CreateIndex(
                name: "IX_book_genre_book_id_genre_id",
                table: "book_genre",
                columns: new[] { "book_id", "genre_id" });

            migrationBuilder.CreateIndex(
                name: "IX_comments_review_id",
                table: "comments",
                column: "review_id");

            migrationBuilder.CreateIndex(
                name: "IX_comments_user_id",
                table: "comments",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_likes_review_id",
                table: "likes",
                column: "review_id");

            migrationBuilder.CreateIndex(
                name: "IX_likes_user_id",
                table: "likes",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_reviews_book_id",
                table: "reviews",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_reviews_user_id",
                table: "reviews",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "likes");

            migrationBuilder.DropTable(
                name: "reviews");

            migrationBuilder.DropIndex(
                name: "IX_user_book_user_id_book_id",
                table: "user_book");

            migrationBuilder.DropIndex(
                name: "IX_book_genre_book_id_genre_id",
                table: "book_genre");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "books",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 9,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 10,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 11,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 12,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 13,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 14,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 15,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 16,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 17,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 18,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 19,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 20,
                column: "created_at",
                value: new DateTime(2024, 10, 7, 13, 2, 30, 115, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2024, 10, 7, 13, 2, 29, 737, DateTimeKind.Utc).AddTicks(8276), "$2a$11$2TxOIm/B1zyhGZ4UpA7DuOTATe9IzUDuDK0QzX1/W3m3FmcqsOV02" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 2,
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2024, 10, 7, 13, 2, 29, 925, DateTimeKind.Utc).AddTicks(9112), "$2a$11$GAoQjbuwk2iFY52nGo9lJebBPFtMEDwIcpD0F0QAv4gcwaYVkAF2y" });
        }
    }
}
