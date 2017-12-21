using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace web.Migrations
{
    public partial class SecondModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achat",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 255, nullable: false),
                    Price = table.Column<string>(maxLength: 255, nullable: false),
                    ProductName = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achat", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achat");
        }
    }
}
