using System;
using FirebirdSql.EntityFrameworkCore.Firebird.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace easywork_backend2.Migrations.EasyWorkDb
{
    /// <inheritdoc />
    public partial class addLogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "VARCHAR(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    FirstName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Priorities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
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
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRole~",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
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
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUser~",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    ProviderKey = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    UserId = table.Column<string>(type: "VARCHAR(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUser~",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    RoleId = table.Column<string>(type: "VARCHAR(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles~",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers~",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    LoginProvider = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    Value = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUser~",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: false),
                    Start_Time = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    End_Time = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Project_Type = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    User_Id = table.Column<string>(type: "VARCHAR(256)", nullable: true),
                    State = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(350)", maxLength: 350, nullable: false),
                    State = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    Start_Time = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    End_Time = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Coment = table.Column<string>(type: "VARCHAR(300)", maxLength: 300, nullable: false),
                    Assigner_To_Id = table.Column<string>(type: "VARCHAR(256)", nullable: true),
                    User_Id = table.Column<string>(type: "VARCHAR(256)", nullable: true),
                    Priority_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_AspNetUsers_Assigner_~",
                        column: x => x.Assigner_To_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tasks_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tasks_Priorities_Priority_Id",
                        column: x => x.Priority_Id,
                        principalTable: "Priorities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asignations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    State = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    Task_Id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asignations_Tasks_Task_Id",
                        column: x => x.Task_Id,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TasksProjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    Task_Id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    Project_Id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TasksProjects_Projects_Proj~",
                        column: x => x.Project_Id,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TasksProjects_Tasks_Task_Id",
                        column: x => x.Task_Id,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asignations_Task_Id",
                table: "Asignations",
                column: "Task_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_User_Id",
                table: "Projects",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_Assigner_To_Id",
                table: "Tasks",
                column: "Assigner_To_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_Priority_Id",
                table: "Tasks",
                column: "Priority_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_User_Id",
                table: "Tasks",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TasksProjects_Project_Id",
                table: "TasksProjects",
                column: "Project_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TasksProjects_Task_Id",
                table: "TasksProjects",
                column: "Task_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asignations");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "TasksProjects");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Priorities");
        }
    }
}
