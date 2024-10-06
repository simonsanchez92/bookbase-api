using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bookbase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class reading_status_model_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "user_book");

            migrationBuilder.AddColumn<int>(
                name: "reading_status",
                table: "user_book",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "reading_statuses",
                columns: table => new
                {
                    reding_status_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reading_statuses", x => x.reding_status_id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_user_book_reading_status",
                table: "user_book",
                column: "reading_status");

            migrationBuilder.AddForeignKey(
                name: "FK_user_book_reading_statuses_reading_status",
                table: "user_book",
                column: "reading_status",
                principalTable: "reading_statuses",
                principalColumn: "reding_status_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_book_reading_statuses_reading_status",
                table: "user_book");

            migrationBuilder.DropTable(
                name: "reading_statuses");

            migrationBuilder.DropIndex(
                name: "IX_user_book_reading_status",
                table: "user_book");

            migrationBuilder.DropColumn(
                name: "reading_status",
                table: "user_book");

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "user_book",
                type: "text",
                nullable: false,
                defaultValue: "");

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
    }
}
