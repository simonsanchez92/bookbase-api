using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookbase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class userbook_updatedAt_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "user_book",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 9,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 10,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 11,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 12,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 13,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 14,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 15,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 16,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 17,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 18,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 19,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 20,
                column: "created_at",
                value: new DateTime(2024, 9, 30, 14, 9, 10, 192, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 9, 9, 802, DateTimeKind.Utc).AddTicks(5077), "$2a$11$mvkbHEhrN7VRPI7EVEY5.OqBt1H5wkRyGTKUcScvJvMrnD7JKucDa" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 2,
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 9, 9, 995, DateTimeKind.Utc).AddTicks(9200), "$2a$11$HS455AakBhQLm.VdplNNK.jjzcV34RL49ZYsQSRd7Hads5/vNY97S" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "user_book");

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

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2024, 9, 30, 13, 6, 55, 777, DateTimeKind.Utc).AddTicks(9629), "$2a$11$rluAH2Ig.XSLMcL7d1f8cOwuUdmGuIH7q82S9SqJWpdPkCLZUGIBy" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 2,
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2024, 9, 30, 13, 6, 55, 967, DateTimeKind.Utc).AddTicks(8672), "$2a$11$KthaptbTpm6L22xE9qvTTOcPXEbL7r37pteX/XQC/qT8/FBeAz63i" });
        }
    }
}
