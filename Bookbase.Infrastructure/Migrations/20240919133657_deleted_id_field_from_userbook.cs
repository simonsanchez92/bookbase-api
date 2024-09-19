using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookbase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class deleted_id_field_from_userbook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "user_book_id",
                table: "user_book");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "user_book_id",
                table: "user_book",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
