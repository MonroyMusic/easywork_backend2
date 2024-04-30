using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace easywork_backend2.Migrations
{
    /// <inheritdoc />
    public partial class change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_asignations_tasks_task_id",
                table: "asignations");

            migrationBuilder.DropForeignKey(
                name: "FK_projects_states_state_id",
                table: "projects");

            migrationBuilder.DropForeignKey(
                name: "FK_projects_tasks_task_id",
                table: "projects");

            migrationBuilder.DropForeignKey(
                name: "FK_tasks_priorities_priority_id",
                table: "tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_tasks_project_projects_proj~",
                table: "tasks_project");

            migrationBuilder.DropForeignKey(
                name: "FK_tasks_project_tasks_task_id",
                table: "tasks_project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tasks",
                table: "tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_states",
                table: "states");

            migrationBuilder.DropPrimaryKey(
                name: "PK_projects",
                table: "projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_priorities",
                table: "priorities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_asignations",
                table: "asignations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tasks_project",
                table: "tasks_project");

            migrationBuilder.RenameTable(
                name: "tasks",
                newName: "Tasks");

            migrationBuilder.RenameTable(
                name: "states",
                newName: "States");

            migrationBuilder.RenameTable(
                name: "projects",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "priorities",
                newName: "Priorities");

            migrationBuilder.RenameTable(
                name: "asignations",
                newName: "Asignations");

            migrationBuilder.RenameTable(
                name: "tasks_project",
                newName: "Tasks_Projects");

            migrationBuilder.RenameIndex(
                name: "IX_tasks_priority_id",
                table: "Tasks",
                newName: "IX_Tasks_priority_id");

            migrationBuilder.RenameIndex(
                name: "IX_projects_task_id",
                table: "Projects",
                newName: "IX_Projects_task_id");

            migrationBuilder.RenameIndex(
                name: "IX_projects_state_id",
                table: "Projects",
                newName: "IX_Projects_state_id");

            migrationBuilder.RenameIndex(
                name: "IX_asignations_task_id",
                table: "Asignations",
                newName: "IX_Asignations_task_id");

            migrationBuilder.RenameIndex(
                name: "IX_tasks_project_task_id",
                table: "Tasks_Projects",
                newName: "IX_Tasks_Projects_task_id");

            migrationBuilder.RenameIndex(
                name: "IX_tasks_project_project_id",
                table: "Tasks_Projects",
                newName: "IX_Tasks_Projects_project_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_States",
                table: "States",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Priorities",
                table: "Priorities",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Asignations",
                table: "Asignations",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks_Projects",
                table: "Tasks_Projects",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignations_Tasks_task_id",
                table: "Asignations",
                column: "task_id",
                principalTable: "Tasks",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_States_state_id",
                table: "Projects",
                column: "state_id",
                principalTable: "States",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Tasks_task_id",
                table: "Projects",
                column: "task_id",
                principalTable: "Tasks",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Priorities_priority_id",
                table: "Tasks",
                column: "priority_id",
                principalTable: "Priorities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects_Projects_pro~",
                table: "Tasks_Projects",
                column: "project_id",
                principalTable: "Projects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects_Tasks_task_id",
                table: "Tasks_Projects",
                column: "task_id",
                principalTable: "Tasks",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignations_Tasks_task_id",
                table: "Asignations");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_States_state_id",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Tasks_task_id",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Priorities_priority_id",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_Projects_pro~",
                table: "Tasks_Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_Tasks_task_id",
                table: "Tasks_Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_States",
                table: "States");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Priorities",
                table: "Priorities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Asignations",
                table: "Asignations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks_Projects",
                table: "Tasks_Projects");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "tasks");

            migrationBuilder.RenameTable(
                name: "States",
                newName: "states");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "projects");

            migrationBuilder.RenameTable(
                name: "Priorities",
                newName: "priorities");

            migrationBuilder.RenameTable(
                name: "Asignations",
                newName: "asignations");

            migrationBuilder.RenameTable(
                name: "Tasks_Projects",
                newName: "tasks_project");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_priority_id",
                table: "tasks",
                newName: "IX_tasks_priority_id");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_task_id",
                table: "projects",
                newName: "IX_projects_task_id");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_state_id",
                table: "projects",
                newName: "IX_projects_state_id");

            migrationBuilder.RenameIndex(
                name: "IX_Asignations_task_id",
                table: "asignations",
                newName: "IX_asignations_task_id");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_Projects_task_id",
                table: "tasks_project",
                newName: "IX_tasks_project_task_id");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_Projects_project_id",
                table: "tasks_project",
                newName: "IX_tasks_project_project_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tasks",
                table: "tasks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_states",
                table: "states",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_projects",
                table: "projects",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_priorities",
                table: "priorities",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_asignations",
                table: "asignations",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tasks_project",
                table: "tasks_project",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_asignations_tasks_task_id",
                table: "asignations",
                column: "task_id",
                principalTable: "tasks",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_projects_states_state_id",
                table: "projects",
                column: "state_id",
                principalTable: "states",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_projects_tasks_task_id",
                table: "projects",
                column: "task_id",
                principalTable: "tasks",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tasks_priorities_priority_id",
                table: "tasks",
                column: "priority_id",
                principalTable: "priorities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tasks_project_projects_proj~",
                table: "tasks_project",
                column: "project_id",
                principalTable: "projects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tasks_project_tasks_task_id",
                table: "tasks_project",
                column: "task_id",
                principalTable: "tasks",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
