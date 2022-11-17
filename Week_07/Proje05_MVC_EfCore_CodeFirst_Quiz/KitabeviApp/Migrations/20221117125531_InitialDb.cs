using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitabeviApp.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: true),
                    DogumYili = table.Column<int>(type: "INTEGER", nullable: false),
                    Cinsiyet = table.Column<char>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: true),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: true),
                    BasimYili = table.Column<int>(type: "INTEGER", nullable: false),
                    SayfaSayisi = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Ad", "Cinsiyet", "DogumYili" },
                values: new object[] { 1, "Matt Heig", 'E', 1980 });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Ad", "Cinsiyet", "DogumYili" },
                values: new object[] { 2, "Feyyaz Yiğit", 'E', 1990 });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Ad", "Cinsiyet", "DogumYili" },
                values: new object[] { 3, "Gizem Doğan", 'K', 1960 });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Ad", "Cinsiyet", "DogumYili" },
                values: new object[] { 4, "Jack London", 'E', 1930 });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Ad", "Cinsiyet", "DogumYili" },
                values: new object[] { 5, "Margaret Atwood", 'K', 1980 });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Ad", "Cinsiyet", "DogumYili" },
                values: new object[] { 6, "Cem Akaş", 'E', 1980 });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Ad", "Cinsiyet", "DogumYili" },
                values: new object[] { 7, "Zafer Demirkol", 'E', 1980 });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Ad", "Cinsiyet", "DogumYili" },
                values: new object[] { 8, "İlber Ortaylı", 'E', 1980 });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Ad", "Cinsiyet", "DogumYili" },
                values: new object[] { 9, "Seda Yiğit", 'K', 1980 });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Ad", "Cinsiyet", "DogumYili" },
                values: new object[] { 10, "George Orwell", 'E', 1980 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Aciklama", "Ad" },
                values: new object[] { 1, "Çocuk Kitapları", "Çocuk" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Aciklama", "Ad" },
                values: new object[] { 2, "Roman, Hikaye, Şiir Kitapları", "Edebiyat" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Aciklama", "Ad" },
                values: new object[] { 3, "Bilgisayar Kitapları", "Bilgisayar" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Aciklama", "Ad" },
                values: new object[] { 4, "Akademik Kitaplar", "Akademik" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Ad", "AuthorId", "BasimYili", "CategoryId", "SayfaSayisi" },
                values: new object[] { 1, "İnsanlar", 1, 2021, 2, 330 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Ad", "AuthorId", "BasimYili", "CategoryId", "SayfaSayisi" },
                values: new object[] { 2, "Zamanı Durdurmanın Yolları", 1, 2021, 1, 370 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Ad", "AuthorId", "BasimYili", "CategoryId", "SayfaSayisi" },
                values: new object[] { 3, "Demir Ökçe", 4, 2017, 2, 400 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Ad", "AuthorId", "BasimYili", "CategoryId", "SayfaSayisi" },
                values: new object[] { 4, "Huzursuzluk", 9, 2018, 2, 330 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Ad", "AuthorId", "BasimYili", "CategoryId", "SayfaSayisi" },
                values: new object[] { 5, "Serenad", 9, 2020, 2, 300 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Ad", "AuthorId", "BasimYili", "CategoryId", "SayfaSayisi" },
                values: new object[] { 6, "19", 6, 2016, 2, 380 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Ad", "AuthorId", "BasimYili", "CategoryId", "SayfaSayisi" },
                values: new object[] { 7, "C# Programlama Dili", 7, 2011, 3, 730 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Ad", "AuthorId", "BasimYili", "CategoryId", "SayfaSayisi" },
                values: new object[] { 8, "React Uygulama Geliştirme", 3, 2021, 3, 530 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Ad", "AuthorId", "BasimYili", "CategoryId", "SayfaSayisi" },
                values: new object[] { 9, "İnsan Ömrünü Neyle Geçirmeli?", 8, 2021, 2, 330 });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
