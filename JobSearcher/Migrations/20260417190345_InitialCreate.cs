using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace JobSearcher.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    CompanyPosition = table.Column<int>(type: "integer", nullable: false),
                    CompanyLocation = table.Column<string>(type: "text", nullable: false),
                    CompanyAppliedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CompanyStatus = table.Column<int>(type: "integer", nullable: false),
                    CompanyMinorNotes = table.Column<string>(type: "text", nullable: false),
                    CompanyJobLink = table.Column<string>(type: "text", nullable: false),
                    CompanyContactPerson = table.Column<string>(type: "text", nullable: false),
                    CompanyTopOfMind = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CompanyWebsite = table.Column<string>(type: "text", nullable: false),
                    CompanyCallOrNot = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
