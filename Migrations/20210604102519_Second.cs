using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab_18.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airports_PlaneTikets_PlaneTiketID",
                table: "Airports");

            migrationBuilder.DropForeignKey(
                name: "FK_Airports_PlaneTikets_PlaneTiketID1",
                table: "Airports");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_PlaneTikets_PlaneTiketID",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PlaneTiketID",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Airports_PlaneTiketID",
                table: "Airports");

            migrationBuilder.DropIndex(
                name: "IX_Airports_PlaneTiketID1",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "PlaneTiketID",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PlaneTiketID",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "PlaneTiketID1",
                table: "Airports");

            migrationBuilder.AddColumn<string>(
                name: "ArrivePort",
                table: "PlaneTikets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartPort",
                table: "PlaneTikets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Person",
                table: "PlaneTikets",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivePort",
                table: "PlaneTikets");

            migrationBuilder.DropColumn(
                name: "DepartPort",
                table: "PlaneTikets");

            migrationBuilder.DropColumn(
                name: "Person",
                table: "PlaneTikets");

            migrationBuilder.AddColumn<int>(
                name: "PlaneTiketID",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlaneTiketID",
                table: "Airports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlaneTiketID1",
                table: "Airports",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PlaneTiketID",
                table: "Persons",
                column: "PlaneTiketID");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_PlaneTiketID",
                table: "Airports",
                column: "PlaneTiketID");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_PlaneTiketID1",
                table: "Airports",
                column: "PlaneTiketID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Airports_PlaneTikets_PlaneTiketID",
                table: "Airports",
                column: "PlaneTiketID",
                principalTable: "PlaneTikets",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Airports_PlaneTikets_PlaneTiketID1",
                table: "Airports",
                column: "PlaneTiketID1",
                principalTable: "PlaneTikets",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_PlaneTikets_PlaneTiketID",
                table: "Persons",
                column: "PlaneTiketID",
                principalTable: "PlaneTikets",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
