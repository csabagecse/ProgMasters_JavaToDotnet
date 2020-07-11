using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace ProgMasters.Mordor.Izek.Repository.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hordak",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hordak", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrkTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    KillCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrkTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrkWeapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Weapon = table.Column<string>(nullable: true),
                    DbOrkId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrkWeapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrkWeapons_OrkTable_DbOrkId",
                        column: x => x.DbOrkId,
                        principalTable: "OrkTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrkTable_Name",
                table: "OrkTable",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrkWeapons_DbOrkId",
                table: "OrkWeapons",
                column: "DbOrkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hordak");

            migrationBuilder.DropTable(
                name: "OrkWeapons");

            migrationBuilder.DropTable(
                name: "OrkTable");
        }
    }
}
