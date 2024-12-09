using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtenTool.PostmanCore.Migrations
{
    /// <inheritdoc />
    public partial class Migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tProjectUserMaps_tProjects_tProjectId",
                table: "tProjectUserMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_tProjectUserMaps_tUsers_t_UserId",
                table: "tProjectUserMaps");

            migrationBuilder.DropIndex(
                name: "IX_tProjectUserMaps_t_UserId",
                table: "tProjectUserMaps");

            migrationBuilder.DropIndex(
                name: "IX_tProjectUserMaps_tProjectId",
                table: "tProjectUserMaps");

            migrationBuilder.DropColumn(
                name: "tProjectId",
                table: "tProjectUserMaps");

            migrationBuilder.DropColumn(
                name: "t_UserId",
                table: "tProjectUserMaps");

            migrationBuilder.CreateIndex(
                name: "IX_tProjectUserMaps_ProjectId",
                table: "tProjectUserMaps",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_tProjectUserMaps_UserId",
                table: "tProjectUserMaps",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_tProjectUserMaps_tProjects_ProjectId",
                table: "tProjectUserMaps",
                column: "ProjectId",
                principalTable: "tProjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tProjectUserMaps_tUsers_UserId",
                table: "tProjectUserMaps",
                column: "UserId",
                principalTable: "tUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tProjectUserMaps_tProjects_ProjectId",
                table: "tProjectUserMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_tProjectUserMaps_tUsers_UserId",
                table: "tProjectUserMaps");

            migrationBuilder.DropIndex(
                name: "IX_tProjectUserMaps_ProjectId",
                table: "tProjectUserMaps");

            migrationBuilder.DropIndex(
                name: "IX_tProjectUserMaps_UserId",
                table: "tProjectUserMaps");

            migrationBuilder.AddColumn<int>(
                name: "tProjectId",
                table: "tProjectUserMaps",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "t_UserId",
                table: "tProjectUserMaps",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tProjectUserMaps_t_UserId",
                table: "tProjectUserMaps",
                column: "t_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tProjectUserMaps_tProjectId",
                table: "tProjectUserMaps",
                column: "tProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_tProjectUserMaps_tProjects_tProjectId",
                table: "tProjectUserMaps",
                column: "tProjectId",
                principalTable: "tProjects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tProjectUserMaps_tUsers_t_UserId",
                table: "tProjectUserMaps",
                column: "t_UserId",
                principalTable: "tUsers",
                principalColumn: "Id");
        }
    }
}
