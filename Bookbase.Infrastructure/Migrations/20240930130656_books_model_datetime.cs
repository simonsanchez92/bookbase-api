using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bookbase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class books_model_datetime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "publish_date",
                table: "books",
                newName: "publish_year");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "books",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 9,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 10,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 11,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 12,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 13,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 14,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 15,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 16,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 17,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 18,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 19,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 20,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 13, 6, 56, 158, DateTimeKind.Utc).AddTicks(3154));

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "user_id", "created_at", "deleted", "email", "password", "role_id", "username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 30, 13, 6, 55, 777, DateTimeKind.Utc).AddTicks(9629), false, "admin@admin.com", "$2a$11$rluAH2Ig.XSLMcL7d1f8cOwuUdmGuIH7q82S9SqJWpdPkCLZUGIBy", 1, "admin" },
                    { 2, new DateTime(2024, 9, 30, 13, 6, 55, 967, DateTimeKind.Utc).AddTicks(8672), false, "user@user.com", "$2a$11$KthaptbTpm6L22xE9qvTTOcPXEbL7r37pteX/XQC/qT8/FBeAz63i", 2, "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "users");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "books");

            migrationBuilder.RenameColumn(
                name: "publish_year",
                table: "books",
                newName: "publish_date");
        }
    }
}
