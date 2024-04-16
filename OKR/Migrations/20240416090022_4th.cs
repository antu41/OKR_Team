using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OKR.Migrations
{
    /// <inheritdoc />
    public partial class _4th : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MilestoneId",
                table: "MilestoneTasks",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "MilestoneSubTasks",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MilestoneTaskId",
                table: "MilestoneSubTasks",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProjectId",
                table: "Milestones",
                type: "text",
                nullable: false,
                defaultValue: "");

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
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MilestoneSubTasks_MilestoneTasks_MilestoneTaskId",
                table: "MilestoneSubTasks",
                column: "MilestoneTaskId",
                principalTable: "MilestoneTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MilestoneTasks_Milestones_MilestoneId",
                table: "MilestoneTasks",
                column: "MilestoneId",
                principalTable: "Milestones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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
                name: "IsCompleted",
                table: "MilestoneSubTasks");

            migrationBuilder.DropColumn(
                name: "MilestoneTaskId",
                table: "MilestoneSubTasks");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Milestones");
        }
    }
}
