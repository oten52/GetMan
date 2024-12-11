using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace OtenTool.PostmanCore.Migrations
{
    /// <inheritdoc />
    public partial class Migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tHeaders");

            migrationBuilder.DropTable(
                name: "tTreeItemProperties");

            migrationBuilder.AddColumn<int>(
                name: "RequestItemId",
                table: "tTreeItems",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tProjectUserMaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ProjectId = table.Column<int>(type: "integer", nullable: false),
                    t_UserId = table.Column<int>(type: "integer", nullable: true),
                    tProjectId = table.Column<int>(type: "integer", nullable: true),
                    CreatedId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tProjectUserMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tProjectUserMaps_tProjects_tProjectId",
                        column: x => x.tProjectId,
                        principalTable: "tProjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tProjectUserMaps_tUsers_CreatedId",
                        column: x => x.CreatedId,
                        principalTable: "tUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tProjectUserMaps_tUsers_t_UserId",
                        column: x => x.t_UserId,
                        principalTable: "tUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tRequestItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Json = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CreatedId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tRequestItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tRequestItems_tUsers_CreatedId",
                        column: x => x.CreatedId,
                        principalTable: "tUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tTreeItems_RequestItemId",
                table: "tTreeItems",
                column: "RequestItemId");

            migrationBuilder.CreateIndex(
                name: "IX_tProjectUserMaps_CreatedId",
                table: "tProjectUserMaps",
                column: "CreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_tProjectUserMaps_t_UserId",
                table: "tProjectUserMaps",
                column: "t_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tProjectUserMaps_tProjectId",
                table: "tProjectUserMaps",
                column: "tProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_tRequestItems_CreatedId",
                table: "tRequestItems",
                column: "CreatedId");

            migrationBuilder.AddForeignKey(
                name: "FK_tTreeItems_tRequestItems_RequestItemId",
                table: "tTreeItems",
                column: "RequestItemId",
                principalTable: "tRequestItems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tTreeItems_tRequestItems_RequestItemId",
                table: "tTreeItems");

            migrationBuilder.DropTable(
                name: "tProjectUserMaps");

            migrationBuilder.DropTable(
                name: "tRequestItems");

            migrationBuilder.DropIndex(
                name: "IX_tTreeItems_RequestItemId",
                table: "tTreeItems");

            migrationBuilder.DropColumn(
                name: "RequestItemId",
                table: "tTreeItems");

            migrationBuilder.CreateTable(
                name: "tTreeItemProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedId = table.Column<int>(type: "integer", nullable: false),
                    TreeItemId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tTreeItemProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tTreeItemProperties_tTreeItems_TreeItemId",
                        column: x => x.TreeItemId,
                        principalTable: "tTreeItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tTreeItemProperties_tUsers_CreatedId",
                        column: x => x.CreatedId,
                        principalTable: "tUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedId = table.Column<int>(type: "integer", nullable: false),
                    TreeItemPropertyId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Key = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Value = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    tTreeItemPropertyId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tHeaders_tTreeItemProperties_tTreeItemPropertyId",
                        column: x => x.tTreeItemPropertyId,
                        principalTable: "tTreeItemProperties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tHeaders_tTreeItems_TreeItemPropertyId",
                        column: x => x.TreeItemPropertyId,
                        principalTable: "tTreeItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tHeaders_tUsers_CreatedId",
                        column: x => x.CreatedId,
                        principalTable: "tUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tHeaders_CreatedId",
                table: "tHeaders",
                column: "CreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_tHeaders_TreeItemPropertyId",
                table: "tHeaders",
                column: "TreeItemPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_tHeaders_tTreeItemPropertyId",
                table: "tHeaders",
                column: "tTreeItemPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_tTreeItemProperties_CreatedId",
                table: "tTreeItemProperties",
                column: "CreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_tTreeItemProperties_TreeItemId",
                table: "tTreeItemProperties",
                column: "TreeItemId");
        }
    }
}
