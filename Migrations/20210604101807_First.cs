using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab_18.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlaneTikets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeDepart = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaneTikets", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaneTiketID = table.Column<int>(type: "int", nullable: true),
                    PlaneTiketID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Airports_PlaneTikets_PlaneTiketID",
                        column: x => x.PlaneTiketID,
                        principalTable: "PlaneTikets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Airports_PlaneTikets_PlaneTiketID1",
                        column: x => x.PlaneTiketID1,
                        principalTable: "PlaneTikets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birstdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaneTiketID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Persons_PlaneTikets_PlaneTiketID",
                        column: x => x.PlaneTiketID,
                        principalTable: "PlaneTikets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Airports_PlaneTiketID",
                table: "Airports",
                column: "PlaneTiketID");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_PlaneTiketID1",
                table: "Airports",
                column: "PlaneTiketID1");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PlaneTiketID",
                table: "Persons",
                column: "PlaneTiketID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "PlaneTikets");
        }
    }
}
