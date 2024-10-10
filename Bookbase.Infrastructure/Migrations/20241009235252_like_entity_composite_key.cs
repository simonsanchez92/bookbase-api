using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bookbase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class like_entity_composite_key : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_likes",
                table: "likes");

            migrationBuilder.DropIndex(
                name: "IX_likes_user_id",
                table: "likes");

            migrationBuilder.DropColumn(
                name: "like_id",
                table: "likes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_likes",
                table: "likes",
                columns: new[] { "user_id", "review_id" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_likes",
                table: "likes");

            migrationBuilder.AddColumn<int>(
                name: "like_id",
                table: "likes",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_likes",
                table: "likes",
                column: "like_id");

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
                name: "IX_likes_user_id",
                table: "likes",
                column: "user_id");
        }
    }
}
