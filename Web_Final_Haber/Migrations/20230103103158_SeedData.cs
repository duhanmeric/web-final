using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebFinalHaber.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleCover = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
