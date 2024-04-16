using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OKR.Migrations
{
    /// <inheritdoc />
    public partial class _2nd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMembers_TeamMembers_AssigneeId",
                table: "TeamMembers");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMembers_Employees_AssigneeId",
                table: "TeamMembers",
                column: "AssigneeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMembers_Employees_AssigneeId",
                table: "TeamMembers");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMembers_TeamMembers_AssigneeId",
                table: "TeamMembers",
                column: "AssigneeId",
                principalTable: "TeamMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
