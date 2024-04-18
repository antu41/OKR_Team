using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OKR.Migrations
{
    /// <inheritdoc />
    public partial class _7th : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Milestones_TeamMembers_AssigneeId",
                table: "Milestones");

            migrationBuilder.DropForeignKey(
                name: "FK_MilestoneSubTasks_MilestoneTasks_MilestoneTaskId",
                table: "MilestoneSubTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_MilestoneSubTasks_TeamMembers_AssigneeId",
                table: "MilestoneSubTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_MilestoneTasks_Milestones_MilestoneId",
                table: "MilestoneTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_MilestoneTasks_TeamMembers_AssigneeId",
                table: "MilestoneTasks");

            migrationBuilder.DropIndex(
                name: "IX_MilestoneTasks_AssigneeId",
                table: "MilestoneTasks");

            migrationBuilder.DropIndex(
                name: "IX_MilestoneTasks_MilestoneId",
                table: "MilestoneTasks");

            migrationBuilder.DropIndex(
                name: "IX_MilestoneSubTasks_AssigneeId",
                table: "MilestoneSubTasks");

            migrationBuilder.DropIndex(
                name: "IX_MilestoneSubTasks_MilestoneTaskId",
                table: "MilestoneSubTasks");

            migrationBuilder.DropIndex(
                name: "IX_Milestones_AssigneeId",
                table: "Milestones");

            migrationBuilder.DropColumn(
                name: "AssigneeId",
                table: "MilestoneTasks");

            migrationBuilder.DropColumn(
                name: "Dependency",
                table: "MilestoneTasks");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "MilestoneTasks");

            migrationBuilder.DropColumn(
                name: "EstimateTime",
                table: "MilestoneTasks");

            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "MilestoneTasks");

            migrationBuilder.DropColumn(
                name: "MilestoneId",
                table: "MilestoneTasks");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "MilestoneTasks");

            migrationBuilder.DropColumn(
                name: "Tag",
                table: "MilestoneTasks");

            migrationBuilder.DropColumn(
                name: "AssigneeId",
                table: "MilestoneSubTasks");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "MilestoneSubTasks");

            migrationBuilder.DropColumn(
                name: "EstimateTime",
                table: "MilestoneSubTasks");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "MilestoneSubTasks");

            migrationBuilder.DropColumn(
                name: "MilestoneTaskId",
                table: "MilestoneSubTasks");

            migrationBuilder.DropColumn(
                name: "AssigneeId",
                table: "Milestones");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssigneeId",
                table: "MilestoneTasks",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Dependency",
                table: "MilestoneTasks",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "MilestoneTasks",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstimateTime",
                table: "MilestoneTasks",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "MilestoneTasks",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MilestoneId",
                table: "MilestoneTasks",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "MilestoneTasks",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag",
                table: "MilestoneTasks",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssigneeId",
                table: "MilestoneSubTasks",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "MilestoneSubTasks",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstimateTime",
                table: "MilestoneSubTasks",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "MilestoneSubTasks",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MilestoneTaskId",
                table: "MilestoneSubTasks",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssigneeId",
                table: "Milestones",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MilestoneTasks_AssigneeId",
                table: "MilestoneTasks",
                column: "AssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_MilestoneTasks_MilestoneId",
                table: "MilestoneTasks",
                column: "MilestoneId");

            migrationBuilder.CreateIndex(
                name: "IX_MilestoneSubTasks_AssigneeId",
                table: "MilestoneSubTasks",
                column: "AssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_MilestoneSubTasks_MilestoneTaskId",
                table: "MilestoneSubTasks",
                column: "MilestoneTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Milestones_AssigneeId",
                table: "Milestones",
                column: "AssigneeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Milestones_TeamMembers_AssigneeId",
                table: "Milestones",
                column: "AssigneeId",
                principalTable: "TeamMembers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MilestoneSubTasks_MilestoneTasks_MilestoneTaskId",
                table: "MilestoneSubTasks",
                column: "MilestoneTaskId",
                principalTable: "MilestoneTasks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MilestoneSubTasks_TeamMembers_AssigneeId",
                table: "MilestoneSubTasks",
                column: "AssigneeId",
                principalTable: "TeamMembers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MilestoneTasks_Milestones_MilestoneId",
                table: "MilestoneTasks",
                column: "MilestoneId",
                principalTable: "Milestones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MilestoneTasks_TeamMembers_AssigneeId",
                table: "MilestoneTasks",
                column: "AssigneeId",
                principalTable: "TeamMembers",
                principalColumn: "Id");
        }
    }
}
