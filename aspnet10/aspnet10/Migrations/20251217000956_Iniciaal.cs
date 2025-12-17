using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnet10.Migrations
{
    /// <inheritdoc />
    public partial class Iniciaal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    author = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    launch_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false),
                    last_name = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false),
                    address = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    gender = table.Column<string>(type: "VARCHAR(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "person");
        }
    }
}
