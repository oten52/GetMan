using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtenTool.PostmanCore.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tUsers",
                columns: new[] { "Id", "CreatedId", "IsDeleted", "Mail", "Password", "UserName" },
                values: new object[] { 1, 1, false, "oten@gmail.com", "admin", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tUsers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
