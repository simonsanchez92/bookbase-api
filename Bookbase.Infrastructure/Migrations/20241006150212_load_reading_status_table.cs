using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bookbase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class load_reading_status_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 9,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 10,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 11,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 12,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 13,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 14,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 15,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 16,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 17,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 18,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 19,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 20,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 15, 2, 12, 271, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.InsertData(
                table: "reading_statuses",
                columns: new[] { "reding_status_id", "name" },
                values: new object[,]
                {
                    { 1, "Want to read" },
                    { 2, "Reading" },
                    { 3, "Read" }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2024, 10, 6, 15, 2, 11, 898, DateTimeKind.Utc).AddTicks(5841), "$2a$11$gCYGhT3VeGjsSaYNKPXK6ujCi5elq9WMzcZQVTeOvqKT9JNn7NuiW" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 2,
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2024, 10, 6, 15, 2, 12, 80, DateTimeKind.Utc).AddTicks(6907), "$2a$11$MvzEv7VWx.cA7Nm/3frDF.DDzrn3zDSSke3z1gU0QK0gFA5ZsAgyO" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "reading_statuses",
                keyColumn: "reding_status_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "reading_statuses",
                keyColumn: "reding_status_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "reading_statuses",
                keyColumn: "reding_status_id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 9,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 10,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 11,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 12,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 13,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 14,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 15,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 16,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 17,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 18,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 19,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 20,
                column: "created_at",
                value: new DateTime(2024, 10, 6, 14, 50, 22, 173, DateTimeKind.Utc).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2024, 10, 6, 14, 50, 21, 781, DateTimeKind.Utc).AddTicks(6938), "$2a$11$TLL.AvOQX/C1rzaxuqq2EuBIP2z.5dlxVk/vUBzUomk.DP0RStwEm" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 2,
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2024, 10, 6, 14, 50, 21, 971, DateTimeKind.Utc).AddTicks(3778), "$2a$11$d7a1OHvmV36t0NhgVxlXKuLyKKsRQWisiO/MDsznzNUKvOqHJhwgS" });
        }
    }
}
