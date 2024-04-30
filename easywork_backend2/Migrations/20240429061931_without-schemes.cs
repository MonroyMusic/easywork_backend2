using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace easywork_backend2.Migrations
{
    /// <inheritdoc />
    public partial class withoutschemes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "users_token",
                schema: "security",
                newName: "users_token");

            migrationBuilder.RenameTable(
                name: "users_roles",
                schema: "security",
                newName: "users_roles");

            migrationBuilder.RenameTable(
                name: "users_login",
                schema: "security",
                newName: "users_login");

            migrationBuilder.RenameTable(
                name: "users_claims",
                schema: "security",
                newName: "users_claims");

            migrationBuilder.RenameTable(
                name: "users",
                schema: "security",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "tasks_project",
                schema: "connections",
                newName: "tasks_project");

            migrationBuilder.RenameTable(
                name: "tasks",
                schema: "principal",
                newName: "tasks");

            migrationBuilder.RenameTable(
                name: "states",
                schema: "extras",
                newName: "states");

            migrationBuilder.RenameTable(
                name: "roles_claims",
                schema: "security",
                newName: "roles_claims");

            migrationBuilder.RenameTable(
                name: "roles",
                schema: "security",
                newName: "roles");

            migrationBuilder.RenameTable(
                name: "projects",
                schema: "principal",
                newName: "projects");

            migrationBuilder.RenameTable(
                name: "priorities",
                schema: "extras",
                newName: "priorities");

            migrationBuilder.RenameTable(
                name: "asignations",
                schema: "principal",
                newName: "asignations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "principal");

            migrationBuilder.EnsureSchema(
                name: "extras");

            migrationBuilder.EnsureSchema(
                name: "security");

            migrationBuilder.EnsureSchema(
                name: "connections");

            migrationBuilder.RenameTable(
                name: "users_token",
                newName: "users_token",
                newSchema: "security");

            migrationBuilder.RenameTable(
                name: "users_roles",
                newName: "users_roles",
                newSchema: "security");

            migrationBuilder.RenameTable(
                name: "users_login",
                newName: "users_login",
                newSchema: "security");

            migrationBuilder.RenameTable(
                name: "users_claims",
                newName: "users_claims",
                newSchema: "security");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "users",
                newSchema: "security");

            migrationBuilder.RenameTable(
                name: "tasks_project",
                newName: "tasks_project",
                newSchema: "connections");

            migrationBuilder.RenameTable(
                name: "tasks",
                newName: "tasks",
                newSchema: "principal");

            migrationBuilder.RenameTable(
                name: "states",
                newName: "states",
                newSchema: "extras");

            migrationBuilder.RenameTable(
                name: "roles_claims",
                newName: "roles_claims",
                newSchema: "security");

            migrationBuilder.RenameTable(
                name: "roles",
                newName: "roles",
                newSchema: "security");

            migrationBuilder.RenameTable(
                name: "projects",
                newName: "projects",
                newSchema: "principal");

            migrationBuilder.RenameTable(
                name: "priorities",
                newName: "priorities",
                newSchema: "extras");

            migrationBuilder.RenameTable(
                name: "asignations",
                newName: "asignations",
                newSchema: "principal");
        }
    }
}
