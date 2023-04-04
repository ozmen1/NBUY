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
                    TeacherId = table.Column<string>(type: "TEXT", nullable: true),
                    StudentId = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Teachers_TeacherId",
                        column: x => x.TeacherId,
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
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    SubjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeacherId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShowCards_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShowCards_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShowCards_Teachers_TeacherId",
                        column: x => x.TeacherId,
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
                    StudentId = table.Column<string>(type: "TEXT", nullable: true),
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
                        name: "FK_Requests_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "CreatedDate", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "IsApproved", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "55dc4a34-a463-46b2-8fb3-e97a76f70cfc", 0, "İstanbul", "6f1411f6-7beb-4d1c-b1eb-dbb3b826ca60", new DateTime(2023, 1, 16, 12, 14, 51, 926, DateTimeKind.Local).AddTicks(6533), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "example@example.com", false, "Jane", null, false, false, "Doe", false, null, null, null, null, null, false, "9646bdd1-f123-40fd-af3d-76a72e3b377c", false, null },
                    { "86c02fd2-67c2-4a94-8113-a751bfe9f71f", 0, "Kocaeli", "7c5a37ce-8358-4198-bf07-0add3bd6b1b2", new DateTime(2023, 1, 16, 12, 14, 51, 926, DateTimeKind.Local).AddTicks(6505), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "keremozmen34@gmail.com", false, "Kerem", null, false, false, "Özmen", false, null, null, null, null, null, false, "46bc50e4-6ed0-4233-80b3-e0fdba3c723a", false, null },
                    { "dc4ac19a-431c-40f1-a2df-cd49869e3559", 0, "İstanbul", "fd434691-421f-4937-a525-ff3e724d4102", new DateTime(2023, 1, 16, 12, 14, 51, 926, DateTimeKind.Local).AddTicks(4728), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "keremozmentr@gmail.com", false, "Kerem", null, false, false, "Özmen", false, null, null, null, null, null, false, "7c50d83d-899d-4340-9fdf-1f7d2ce96283", false, null },
                    { "fc4ac19b-331c-90f1-z2df-xd49869e3351", 0, "İstanbul", "a7c7a656-0888-4460-91b2-4a32cae56d36", new DateTime(2023, 1, 16, 12, 14, 51, 926, DateTimeKind.Local).AddTicks(4920), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "example@example.com", false, "John", null, false, false, "Doe", false, null, null, null, null, null, false, "781871e0-02bc-4458-a8bc-44ae72c46fca", false, null }
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
                table: "Comments",
                columns: new[] { "Id", "CommentText", "Point", "StudentId", "TeacherId", "Url" },
                values: new object[,]
                {
                    { 1, "Mükemmel bir eğitimci.", (byte)0, "55dc4a34-a463-46b2-8fb3-e97a76f70cfc", "dc4ac19a-431c-40f1-a2df-cd49869e3559", "comment-1" },
                    { 2, "Harika bir eğitimci.", (byte)0, "86c02fd2-67c2-4a94-8113-a751bfe9f71f", "fc4ac19b-331c-90f1-z2df-xd49869e3351", "comment-2" }
                });

            migrationBuilder.InsertData(
                table: "ShowCards",
                columns: new[] { "Id", "CategoryId", "Description", "IsHome", "Price", "SubjectId", "TeacherId", "Title", "Url" },
                values: new object[,]
                {
                    { 1, 2, "Lise, Üniversite matematik dersleri verilir.", true, 100m, 1, "dc4ac19a-431c-40f1-a2df-cd49869e3559", "Online Matematik Dersi", "ozel-ders-1" },
                    { 2, 9, "İngilizce anadilli hocadan ingilizce dersleri.", false, 100m, 3, "fc4ac19b-331c-90f1-z2df-xd49869e3351", "Online İngilizce Dersi", "ozel-ders-ing" }
                });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "ContactNumber", "Expectations", "ResponseTime", "ShowCardId", "StudentId" },
                values: new object[] { 1, "0555-555-55-55", "Kalkülüs dersi için 5 saatlik özel ders", new DateTime(2023, 1, 16, 12, 14, 51, 926, DateTimeKind.Local).AddTicks(9478), 1, "55dc4a34-a463-46b2-8fb3-e97a76f70cfc" });

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
                name: "IX_Comments_StudentId",
                table: "Comments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TeacherId",
                table: "Comments",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ShowCardId",
                table: "Requests",
                column: "ShowCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_StudentId",
                table: "Requests",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ShowCards_CategoryId",
                table: "ShowCards",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShowCards_SubjectId",
                table: "ShowCards",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ShowCards_TeacherId",
                table: "ShowCards",
                column: "TeacherId");

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
