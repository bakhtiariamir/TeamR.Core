using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamR.Database.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "account");

            migrationBuilder.EnsureSchema(
                name: "organization");

            migrationBuilder.EnsureSchema(
                name: "doc");

            migrationBuilder.CreateTable(
                name: "Account",
                schema: "account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    UseGravatar = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chart",
                schema: "organization",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ChartType = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Folder",
                schema: "doc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Path = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Folder_Folder_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "doc",
                        principalTable: "Folder",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Version",
                schema: "doc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Major = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Minor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Patch = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Version", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Altitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Account_AccountId",
                        column: x => x.AccountId,
                        principalSchema: "account",
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                schema: "organization",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ChartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_Chart_ChartId",
                        column: x => x.ChartId,
                        principalSchema: "organization",
                        principalTable: "Chart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Department_Department_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "organization",
                        principalTable: "Department",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Document",
                schema: "doc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Extension = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    VersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Body = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FolderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Document_Folder_FolderId",
                        column: x => x.FolderId,
                        principalSchema: "doc",
                        principalTable: "Folder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Document_Version_VersionId",
                        column: x => x.VersionId,
                        principalSchema: "doc",
                        principalTable: "Version",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                schema: "organization",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ChartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Capacity = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_Chart_ChartId",
                        column: x => x.ChartId,
                        principalSchema: "organization",
                        principalTable: "Chart",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Post_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "organization",
                        principalTable: "Department",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PostRelation",
                schema: "organization",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostRelation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostRelation_Post_PostId",
                        column: x => x.PostId,
                        principalSchema: "organization",
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Department_ChartId",
                schema: "organization",
                table: "Department",
                column: "ChartId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_ParentId",
                schema: "organization",
                table: "Department",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_FolderId",
                schema: "doc",
                table: "Document",
                column: "FolderId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_Name_Url",
                schema: "doc",
                table: "Document",
                columns: new[] { "Name", "Url" });

            migrationBuilder.CreateIndex(
                name: "IX_Document_VersionId",
                schema: "doc",
                table: "Document",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Folder_Name",
                schema: "doc",
                table: "Folder",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Folder_ParentId",
                schema: "doc",
                table: "Folder",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_ChartId",
                schema: "organization",
                table: "Post",
                column: "ChartId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_DepartmentId",
                schema: "organization",
                table: "Post",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PostRelation_PostId",
                schema: "organization",
                table: "PostRelation",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_User_AccountId",
                schema: "account",
                table: "User",
                column: "AccountId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document",
                schema: "doc");

            migrationBuilder.DropTable(
                name: "PostRelation",
                schema: "organization");

            migrationBuilder.DropTable(
                name: "User",
                schema: "account");

            migrationBuilder.DropTable(
                name: "Folder",
                schema: "doc");

            migrationBuilder.DropTable(
                name: "Version",
                schema: "doc");

            migrationBuilder.DropTable(
                name: "Post",
                schema: "organization");

            migrationBuilder.DropTable(
                name: "Account",
                schema: "account");

            migrationBuilder.DropTable(
                name: "Department",
                schema: "organization");

            migrationBuilder.DropTable(
                name: "Chart",
                schema: "organization");
        }
    }
}
