using System;
using FirebirdSql.EntityFrameworkCore.Firebird.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace easywork_backend2.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "principal");

            migrationBuilder.EnsureSchema(
                name: "extras");

            migrationBuilder.EnsureSchema(
                name: "security");

            migrationBuilder.EnsureSchema(
                name: "connections");

            migrationBuilder.CreateTable(
                name: "priorities",
                schema: "extras",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_priorities", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                schema: "security",
                columns: table => new
                {
                    Id = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "VARCHAR(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "states",
                schema: "extras",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_states", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                schema: "security",
                columns: table => new
                {
                    Id = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    first_name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    last_name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "VARCHAR(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "VARCHAR(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "VARCHAR(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "VARCHAR(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    PasswordHash = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    LockoutEnd = table.Column<string>(type: "VARCHAR(48)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tasks",
                schema: "principal",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    description = table.Column<string>(type: "VARCHAR(350)", maxLength: 350, nullable: false),
                    state = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    start_time = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    end_time = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    coment = table.Column<string>(type: "VARCHAR(300)", maxLength: 300, nullable: false),
                    priority_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tasks", x => x.id);
                    table.ForeignKey(
                        name: "FK_tasks_priorities_priority_id",
                        column: x => x.priority_id,
                        principalSchema: "extras",
                        principalTable: "priorities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "roles_claims",
                schema: "security",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    ClaimType = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles_claims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_roles_claims_roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "security",
                        principalTable: "roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users_claims",
                schema: "security",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    ClaimType = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users_claims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_users_claims_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "security",
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users_login",
                schema: "security",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    ProviderKey = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    UserId = table.Column<string>(type: "VARCHAR(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users_login", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_users_login_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "security",
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users_roles",
                schema: "security",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    RoleId = table.Column<string>(type: "VARCHAR(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users_roles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_users_roles_roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "security",
                        principalTable: "roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_roles_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "security",
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users_token",
                schema: "security",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    LoginProvider = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    Value = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users_token", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_users_token_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "security",
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "asignations",
                schema: "principal",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    description = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    state = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    task_id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asignations", x => x.id);
                    table.ForeignKey(
                        name: "FK_asignations_tasks_task_id",
                        column: x => x.task_id,
                        principalSchema: "principal",
                        principalTable: "tasks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                schema: "principal",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    name = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    description = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: false),
                    start_time = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    end_time = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    project_type = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    task_id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    state_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.id);
                    table.ForeignKey(
                        name: "FK_projects_states_state_id",
                        column: x => x.state_id,
                        principalSchema: "extras",
                        principalTable: "states",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_projects_tasks_task_id",
                        column: x => x.task_id,
                        principalSchema: "principal",
                        principalTable: "tasks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tasks_project",
                schema: "connections",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    task_id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    project_id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tasks_project", x => x.id);
                    table.ForeignKey(
                        name: "FK_tasks_project_projects_proj~",
                        column: x => x.project_id,
                        principalSchema: "principal",
                        principalTable: "projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tasks_project_tasks_task_id",
                        column: x => x.task_id,
                        principalSchema: "principal",
                        principalTable: "tasks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_asignations_task_id",
                schema: "principal",
                table: "asignations",
                column: "task_id");

            migrationBuilder.CreateIndex(
                name: "IX_projects_state_id",
                schema: "principal",
                table: "projects",
                column: "state_id");

            migrationBuilder.CreateIndex(
                name: "IX_projects_task_id",
                schema: "principal",
                table: "projects",
                column: "task_id");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "security",
                table: "roles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_roles_claims_RoleId",
                schema: "security",
                table: "roles_claims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_tasks_priority_id",
                schema: "principal",
                table: "tasks",
                column: "priority_id");

            migrationBuilder.CreateIndex(
                name: "IX_tasks_project_project_id",
                schema: "connections",
                table: "tasks_project",
                column: "project_id");

            migrationBuilder.CreateIndex(
                name: "IX_tasks_project_task_id",
                schema: "connections",
                table: "tasks_project",
                column: "task_id");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "security",
                table: "users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "security",
                table: "users",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_claims_UserId",
                schema: "security",
                table: "users_claims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_users_login_UserId",
                schema: "security",
                table: "users_login",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_users_roles_RoleId",
                schema: "security",
                table: "users_roles",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asignations",
                schema: "principal");

            migrationBuilder.DropTable(
                name: "roles_claims",
                schema: "security");

            migrationBuilder.DropTable(
                name: "tasks_project",
                schema: "connections");

            migrationBuilder.DropTable(
                name: "users_claims",
                schema: "security");

            migrationBuilder.DropTable(
                name: "users_login",
                schema: "security");

            migrationBuilder.DropTable(
                name: "users_roles",
                schema: "security");

            migrationBuilder.DropTable(
                name: "users_token",
                schema: "security");

            migrationBuilder.DropTable(
                name: "projects",
                schema: "principal");

            migrationBuilder.DropTable(
                name: "roles",
                schema: "security");

            migrationBuilder.DropTable(
                name: "users",
                schema: "security");

            migrationBuilder.DropTable(
                name: "states",
                schema: "extras");

            migrationBuilder.DropTable(
                name: "tasks",
                schema: "principal");

            migrationBuilder.DropTable(
                name: "priorities",
                schema: "extras");
        }
    }
}
