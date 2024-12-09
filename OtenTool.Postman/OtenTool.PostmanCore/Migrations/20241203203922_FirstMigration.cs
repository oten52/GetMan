using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace OtenTool.PostmanCore.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: false),
                    Mail = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tUsers_tUsers_CreatedId",
                        column: x => x.CreatedId,
                        principalTable: "tUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProjectName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tProjects_tUsers_CreatedId",
                        column: x => x.CreatedId,
                        principalTable: "tUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tTreeItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ProjectItemId = table.Column<int>(type: "integer", nullable: false),
                    ParentId = table.Column<int>(type: "integer", nullable: true),
                    IsRequest = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tTreeItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tTreeItems_tProjects_ProjectItemId",
                        column: x => x.ProjectItemId,
                        principalTable: "tProjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tTreeItems_tTreeItems_ParentId",
                        column: x => x.ParentId,
                        principalTable: "tTreeItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tTreeItems_tUsers_CreatedId",
                        column: x => x.CreatedId,
                        principalTable: "tUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tTreeItemProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Url = table.Column<string>(type: "text", nullable: false),
                    TreeItemId = table.Column<int>(type: "integer", nullable: false),
                    CreatedId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
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
                    TreeItemPropertyId = table.Column<int>(type: "integer", nullable: false),
                    Key = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Value = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: false),
                    tTreeItemPropertyId = table.Column<int>(type: "integer", nullable: true),
                    CreatedId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
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
                name: "IX_tProjects_CreatedId",
                table: "tProjects",
                column: "CreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_tTreeItemProperties_CreatedId",
                table: "tTreeItemProperties",
                column: "CreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_tTreeItemProperties_TreeItemId",
                table: "tTreeItemProperties",
                column: "TreeItemId");

            migrationBuilder.CreateIndex(
                name: "IX_tTreeItems_CreatedId",
                table: "tTreeItems",
                column: "CreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_tTreeItems_ParentId",
                table: "tTreeItems",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_tTreeItems_ProjectItemId",
                table: "tTreeItems",
                column: "ProjectItemId");

            migrationBuilder.CreateIndex(
                name: "IX_tUsers_CreatedId",
                table: "tUsers",
                column: "CreatedId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tHeaders");

            migrationBuilder.DropTable(
                name: "tTreeItemProperties");

            migrationBuilder.DropTable(
                name: "tTreeItems");

            migrationBuilder.DropTable(
                name: "tProjects");

            migrationBuilder.DropTable(
                name: "tUsers");
        }
    }
}
