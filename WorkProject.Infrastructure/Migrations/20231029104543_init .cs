using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Custom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    link = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomId", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Custom",
                columns: new[] { "Id", "Code", "CreatedDate", "Is_Active", "ModifiedDate", "link" },
                values: new object[,]
                {
                    { 1, "abc123", new DateTime(2023, 10, 29, 10, 45, 43, 254, DateTimeKind.Utc).AddTicks(4638), false, null, "www.google.com" },
                    { 2, "def456", new DateTime(2023, 10, 29, 10, 45, 43, 254, DateTimeKind.Utc).AddTicks(4641), false, null, "www.yahoo.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Custom");
        }
    }
}
