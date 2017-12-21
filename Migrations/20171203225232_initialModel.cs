using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace web.Migrations
{
    public partial class initialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    Price = table.Column<string>(maxLength: 255, nullable: false),
                    ProductName = table.Column<string>(maxLength: 255, nullable: false),
                    Type = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 255, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    NumTelephone = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
