using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookbase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class added_unique_reviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_reviews_user_id",
                table: "reviews");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 3,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 4,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 5,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 6,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 7,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 8,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 9,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 10,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 11,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 12,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 13,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 14,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 15,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 16,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 17,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 18,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 19,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "book_id",
                keyValue: 20,
                column: "created_at",
                value: new DateTime(2024, 10, 8, 21, 11, 52, 821, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 1,
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2024, 10, 8, 21, 11, 52, 430, DateTimeKind.Utc).AddTicks(7477), "$2a$11$/40ipDYVS0fBgx3VSdG./.NFrO2SzAFjW3n2CCmM6sP0ouhWAvl7G" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: 2,
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2024, 10, 8, 21, 11, 52, 623, DateTimeKind.Utc).AddTicks(8304), "$2a$11$k3f3E36QqQOVSkuSBTXYX.uuxPBLDdp/UNPlmCFXg2q7ZNTiPNxou" });

            migrationBuilder.CreateIndex(
                name: "IX_reviews_user_id_book_id",
                table: "reviews",
                columns: new[] { "user_id", "book_id" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_reviews_user_id_book_id",
                table: "reviews");

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
                name: "IX_reviews_user_id",
                table: "reviews",
                column: "user_id");
        }
    }
}
