using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReStartUp.Migrations
{
    public partial class Initdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EMAIL",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMAIL", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EMAIL");
        }
    }
}
