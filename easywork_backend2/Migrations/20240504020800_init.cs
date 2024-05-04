using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace easywork_backend2.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    Action = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    Time = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    User_Id = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");
        }
    }
}
