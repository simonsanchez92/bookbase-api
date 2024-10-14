using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookbase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class like_id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "likes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7562), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7728), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7734), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7738), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7742), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7746), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7749), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7753), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7756), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7760), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7764), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7768), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7783), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7786), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7796), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7800), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7804), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7807), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7811), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7815), new DateTime(2024, 10, 14, 23, 16, 5, 714, DateTimeKind.Utc).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 326, DateTimeKind.Utc).AddTicks(3603), "$2a$11$pP3PNKuoxmPaXv11ndBqGOHjYOkrZ4EIyoYj8VmlYfAIS0.K5O.xC", new DateTime(2024, 10, 14, 23, 16, 5, 326, DateTimeKind.Utc).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 2,
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 5, 518, DateTimeKind.Utc).AddTicks(643), "$2a$11$PHe8iW79q7FIspdBwH6Sne08n2Jp.id9hJ/hwZThQLwMfpKCyC3Zy", new DateTime(2024, 10, 14, 23, 16, 5, 518, DateTimeKind.Utc).AddTicks(647) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "likes");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9126), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9138), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9143), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9147), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9151), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9155), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9159), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9163), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9167), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9170), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9174), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9179), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9192), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9196), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9206), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9214), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9217), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9221), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9224), new DateTime(2024, 10, 14, 23, 13, 2, 470, DateTimeKind.Utc).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 34, DateTimeKind.Utc).AddTicks(1124), "$2a$11$7JOE0TmtNbolc8ofr/DdyewqxNtoVandSyijT3fkX44rem8ihn5/q", new DateTime(2024, 10, 14, 23, 13, 2, 34, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 2,
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 13, 2, 233, DateTimeKind.Utc).AddTicks(8849), "$2a$11$fGJyRXzP3LYHq06nQSwclebPVN.3yZH0d4cZ.uh9yN9GwnVECi37G", new DateTime(2024, 10, 14, 23, 13, 2, 233, DateTimeKind.Utc).AddTicks(8853) });
        }
    }
}
