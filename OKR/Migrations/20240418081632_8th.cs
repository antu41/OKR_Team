using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OKR.Migrations
{
    /// <inheritdoc />
    public partial class _8th : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Milestones_Projects_ProjectId",
                table: "Milestones");

            migrationBuilder.DropIndex(
                name: "IX_Milestones_ProjectId",
                table: "Milestones");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Milestones");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectId",
                table: "Milestones",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Milestones_ProjectId",
                table: "Milestones",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Milestones_Projects_ProjectId",
                table: "Milestones",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }
    }
}
