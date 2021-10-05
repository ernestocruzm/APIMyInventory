using Microsoft.EntityFrameworkCore.Migrations;

namespace AppsInventory.Migrations
{
    public partial class InitialDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfigLists",
                columns: table => new
                {
                    ConfigListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegBorrado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigLists", x => x.ConfigListId);
                });

            migrationBuilder.CreateTable(
                name: "ConfigItem",
                columns: table => new
                {
                    ConfigItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegBorrado = table.Column<int>(type: "int", nullable: false),
                    ConfigListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigItem", x => x.ConfigItemId);
                    table.ForeignKey(
                        name: "FK_ConfigItem_ConfigLists_ConfigListId",
                        column: x => x.ConfigListId,
                        principalTable: "ConfigLists",
                        principalColumn: "ConfigListId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConfigItem_ConfigListId",
                table: "ConfigItem",
                column: "ConfigListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfigItem");

            migrationBuilder.DropTable(
                name: "ConfigLists");
        }
    }
}
