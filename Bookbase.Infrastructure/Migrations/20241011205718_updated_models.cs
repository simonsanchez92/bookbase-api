using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookbase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updated_models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "user_book",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "books",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9511), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9521), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9526), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9529), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9533), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9537), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9537) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9541), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9544), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9548), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9552), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9555), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9559), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9573), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9577), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9587), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9591), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9595), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9598), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9602), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9606), new DateTime(2024, 10, 11, 20, 57, 17, 318, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 16, 918, DateTimeKind.Utc).AddTicks(9302), "$2a$11$erpv5QyotjwbvlZ2EMOZreJ2F0HtaQDjoAg3lzeSiVgjZjY2PVLei", new DateTime(2024, 10, 11, 20, 57, 16, 918, DateTimeKind.Utc).AddTicks(9304) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 2,
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 57, 17, 111, DateTimeKind.Utc).AddTicks(9284), "$2a$11$e.gguylWnQ7PKHbSVQMUDOPP29evZYwk4H9U6YECMzRytVlRaJ8ji", new DateTime(2024, 10, 11, 20, 57, 17, 111, DateTimeKind.Utc).AddTicks(9288) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "user_book");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "books");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 9,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 10,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 11,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 12,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 13,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 14,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 15,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 16,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 17,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 18,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 19,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 20,
                column: "created_at",
                value: new DateTime(2024, 10, 9, 23, 52, 51, 315, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2024, 10, 9, 23, 52, 50, 863, DateTimeKind.Utc).AddTicks(7814), "$2a$11$Muz4UeOMiGpi6SwHJ6W/OuQa17OQniRdh7ItJKkL.z4MT/QUXr64K" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 2,
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2024, 10, 9, 23, 52, 51, 76, DateTimeKind.Utc).AddTicks(4908), "$2a$11$VeuqOibDVvw7D1n27WR/degHZp.tHH0p9RpenEGrahp9R.MXxqE4S" });
        }
    }
}
