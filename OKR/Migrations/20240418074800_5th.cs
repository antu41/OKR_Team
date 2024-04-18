using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OKR.Migrations
{
    /// <inheritdoc />
    public partial class _5th : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Milestones_Projects_ProjectId",
                table: "Milestones");

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

            migrationBuilder.AlterColumn<string>(
                name: "MilestoneId",
                table: "MilestoneTasks",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "AssigneeId",
                table: "MilestoneTasks",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "MilestoneTaskId",
                table: "MilestoneSubTasks",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "IsCompleted",
                table: "MilestoneSubTasks",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "AssigneeId",
                table: "MilestoneSubTasks",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectId",
                table: "Milestones",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "AssigneeId",
                table: "Milestones",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_Milestones_Projects_ProjectId",
                table: "Milestones",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Milestones_Projects_ProjectId",
                table: "Milestones");

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

            migrationBuilder.AlterColumn<string>(
                name: "MilestoneId",
                table: "MilestoneTasks",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssigneeId",
                table: "MilestoneTasks",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MilestoneTaskId",
                table: "MilestoneSubTasks",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsCompleted",
                table: "MilestoneSubTasks",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssigneeId",
                table: "MilestoneSubTasks",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectId",
                table: "Milestones",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssigneeId",
                table: "Milestones",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Milestones_Projects_ProjectId",
                table: "Milestones",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Milestones_TeamMembers_AssigneeId",
                table: "Milestones",
                column: "AssigneeId",
                principalTable: "TeamMembers",
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
                name: "FK_MilestoneSubTasks_TeamMembers_AssigneeId",
                table: "MilestoneSubTasks",
                column: "AssigneeId",
                principalTable: "TeamMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MilestoneTasks_Milestones_MilestoneId",
                table: "MilestoneTasks",
                column: "MilestoneId",
                principalTable: "Milestones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MilestoneTasks_TeamMembers_AssigneeId",
                table: "MilestoneTasks",
                column: "AssigneeId",
                principalTable: "TeamMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
