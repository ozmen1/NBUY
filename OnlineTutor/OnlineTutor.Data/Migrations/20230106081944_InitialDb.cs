using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineTutor.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsApproved = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 16, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
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
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    TeacherInfo = table.Column<string>(type: "TEXT", nullable: true),
                    Department = table.Column<string>(type: "TEXT", nullable: true),
                    TeacherPoint = table.Column<byte>(type: "INTEGER", nullable: false),
                    ResponseRange = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectCategories",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectCategories", x => new { x.SubjectId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_SubjectCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectCategories_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommentText = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Point = table.Column<byte>(type: "INTEGER", nullable: false),
                    TeacherId1 = table.Column<string>(type: "TEXT", nullable: true),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false),
                    StudentId1 = table.Column<string>(type: "TEXT", nullable: true),
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Students_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Teachers_TeacherId1",
                        column: x => x.TeacherId1,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShowCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    SubjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeacherId1 = table.Column<string>(type: "TEXT", nullable: true),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShowCards_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShowCards_Teachers_TeacherId1",
                        column: x => x.TeacherId1,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Expectations = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    ContactNumber = table.Column<string>(type: "TEXT", nullable: false),
                    ResponseTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StudentId1 = table.Column<string>(type: "TEXT", nullable: true),
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    ShowCardId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_ShowCards_ShowCardId",
                        column: x => x.ShowCardId,
                        principalTable: "ShowCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Students_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "CreatedDate", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "IsApproved", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "55dc4a34-a463-46b2-8fb3-e97a76f70cfc", 0, "İstanbul", "2f4bb882-1f44-425e-aab6-40e9774d3330", new DateTime(2023, 1, 6, 11, 19, 44, 547, DateTimeKind.Local).AddTicks(672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "example@example.com", false, "Jane", null, false, false, "Doe", false, null, null, null, null, null, false, "aa330c7f-396b-42ba-810a-da1b9d27c1a9", false, null },
                    { "86c02fd2-67c2-4a94-8113-a751bfe9f71f", 0, "Kocaeli", "6385020e-fdde-4ae5-a768-68b4b2555055", new DateTime(2023, 1, 6, 11, 19, 44, 547, DateTimeKind.Local).AddTicks(648), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "keremozmen34@gmail.com", false, "Kerem", null, false, false, "Özmen", false, null, null, null, null, null, false, "2e6c5701-4c73-49da-adf7-20caf63458d0", false, null },
                    { "dc4ac19a-431c-40f1-a2df-cd49869e3559", 0, "İstanbul", "79a343db-19ce-4832-a752-6bd06402f6d4", new DateTime(2023, 1, 6, 11, 19, 44, 546, DateTimeKind.Local).AddTicks(8974), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "keremozmentr@gmail.com", false, "Kerem", null, false, false, "Özmen", false, null, null, null, null, null, false, "0f79a3ab-2f78-4e74-9947-5ff6e27d854f", false, null },
                    { "fc4ac19b-331c-90f1-z2df-xd49869e3351", 0, "İstanbul", "b46e6515-1e57-4bce-b4b0-24b4351865e9", new DateTime(2023, 1, 6, 11, 19, 44, 546, DateTimeKind.Local).AddTicks(9054), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "example@example.com", false, "John", null, false, false, "Doe", false, null, null, null, null, null, false, "7c9533db-187d-410a-ad55-e5792f6e8328", false, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Bu bir açıklamadır.", "Lise", "lise" },
                    { 2, "Bu bir açıklamadır.", "İlköğretim", "ilkogretim" },
                    { 3, "Bu bir açıklamadır.", "Yazılım", "yazilim" },
                    { 4, "Bu bir açıklamadır.", "Üniversite", "universite" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentText", "Point", "StudentId", "StudentId1", "TeacherId", "TeacherId1", "Url" },
                values: new object[,]
                {
                    { 1, "Mükemmel bir eğitimci.", (byte)0, 2, null, 1, null, "comment-1" },
                    { 2, "Harika bir eğitimci.", (byte)0, 1, null, 2, null, "comment-2" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Bu bir açıklamadır.", null, "Matematik", "matematik" },
                    { 2, "Bu bir açıklamadır.", null, "Fizik", "fizik" },
                    { 3, "Bu bir açıklamadır.", null, "Kimya", "kimya" },
                    { 4, "Bu bir açıklamadır.", null, "C#", "c#" },
                    { 5, "Bu bir açıklamadır.", null, "Javascript", "javascript" },
                    { 6, "Bu bir açıklamadır.", null, "Makine Mühendisliği", "makine-muhendisligi" },
                    { 7, "Bu bir açıklamadır.", null, "Bilgisayar Mühendisliği", "bilgisayar-muhendisligi" },
                    { 8, "Bu bir açıklamadır.", null, "Hayat Bilgisi", "hayat-bilgisi" },
                    { 9, "Bu bir açıklamadır.", null, "İngilizce", "ingilizce" },
                    { 10, "Bu bir açıklamadır.", null, "DotNET", "dotnet" }
                });

            migrationBuilder.InsertData(
                table: "ShowCards",
                columns: new[] { "Id", "Description", "Price", "SubjectId", "TeacherId", "TeacherId1", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "Lise, Üniversite matematik dersleri verilir.", 100m, 1, 1, null, "Online Matematik Dersi", "ozel-ders-1" },
                    { 2, "İngilizce anadilli hocadan ingilizce dersleri.", 100m, 3, 2, null, "Online İngilizce Dersi", "ozel-ders-ing" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Url" },
                values: new object[,]
                {
                    { "55dc4a34-a463-46b2-8fb3-e97a76f70cfc", "lise-ogrencisi" },
                    { "86c02fd2-67c2-4a94-8113-a751bfe9f71f", "universite-ogrencisi" }
                });

            migrationBuilder.InsertData(
                table: "SubjectCategories",
                columns: new[] { "CategoryId", "SubjectId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 2, 8 },
                    { 1, 9 },
                    { 2, 9 },
                    { 4, 10 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Department", "ResponseRange", "TeacherInfo", "TeacherPoint", "Url" },
                values: new object[,]
                {
                    { "dc4ac19a-431c-40f1-a2df-cd49869e3559", null, null, "Deneyimli", (byte)0, "deneyimli" },
                    { "fc4ac19b-331c-90f1-z2df-xd49869e3351", null, null, "Deneyimsiz", (byte)0, "deneyimsiz" }
                });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "ContactNumber", "Expectations", "ResponseTime", "ShowCardId", "StudentId", "StudentId1" },
                values: new object[] { 1, "0555-555-55-55", "Kalkülüs dersi için 5 saatlik özel ders", new DateTime(2023, 1, 6, 11, 19, 44, 547, DateTimeKind.Local).AddTicks(3404), 1, 2, null });

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
                name: "IX_Comments_StudentId1",
                table: "Comments",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TeacherId1",
                table: "Comments",
                column: "TeacherId1");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ShowCardId",
                table: "Requests",
                column: "ShowCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_StudentId1",
                table: "Requests",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_ShowCards_SubjectId",
                table: "ShowCards",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ShowCards_TeacherId1",
                table: "ShowCards",
                column: "TeacherId1");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectCategories_CategoryId",
                table: "SubjectCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "SubjectCategories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ShowCards");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
