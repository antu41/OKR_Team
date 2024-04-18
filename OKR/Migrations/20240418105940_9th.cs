using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OKR.Migrations
{
    /// <inheritdoc />
    public partial class _9th : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MilestoneId",
                table: "MilestoneTasks",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MilestoneTaskId",
                table: "MilestoneSubTasks",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectId",
                table: "Milestones",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MilestoneTasks_MilestoneId",
                table: "MilestoneTasks",
                column: "MilestoneId");

            migrationBuilder.CreateIndex(
                name: "IX_MilestoneSubTasks_MilestoneTaskId",
                table: "MilestoneSubTasks",
                column: "MilestoneTaskId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_MilestoneSubTasks_MilestoneTasks_MilestoneTaskId",
                table: "MilestoneSubTasks",
                column: "MilestoneTaskId",
                principalTable: "MilestoneTasks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MilestoneTasks_Milestones_MilestoneId",
                table: "MilestoneTasks",
                column: "MilestoneId",
                principalTable: "Milestones",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Milestones_Projects_ProjectId",
                table: "Milestones");

            migrationBuilder.DropForeignKey(
                name: "FK_MilestoneSubTasks_MilestoneTasks_MilestoneTaskId",
                table: "MilestoneSubTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_MilestoneTasks_Milestones_MilestoneId",
                table: "MilestoneTasks");

            migrationBuilder.DropIndex(
                name: "IX_MilestoneTasks_MilestoneId",
                table: "MilestoneTasks");

            migrationBuilder.DropIndex(
                name: "IX_MilestoneSubTasks_MilestoneTaskId",
                table: "MilestoneSubTasks");

            migrationBuilder.DropIndex(
                name: "IX_Milestones_ProjectId",
                table: "Milestones");

            migrationBuilder.DropColumn(
                name: "MilestoneId",
                table: "MilestoneTasks");

            migrationBuilder.DropColumn(
                name: "MilestoneTaskId",
                table: "MilestoneSubTasks");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Milestones");
        }
    }
}
