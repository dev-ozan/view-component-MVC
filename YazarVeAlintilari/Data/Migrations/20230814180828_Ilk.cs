using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YazarVeAlintilari.Data.Migrations
{
    /// <inheritdoc />
    public partial class Ilk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Yazars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soz = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Yazars",
                columns: new[] { "Id", "Soz", "YazarAdi" },
                values: new object[,]
                {
                    { 1, "Başarmak için ilk adım atmalısınız.", "Zig Ziglar" },
                    { 2, "Sadece bugünü değil, yarını da düşünerek hareket edin.", "Albert Einstein" },
                    { 3, "Başkalarının sınırlamaları sizi durduramaz, yeter ki inanın.", "Roy T. Bennett" },
                    { 4, "Başarı, en çok denemekten korkmayanların elindedir.", "Robert Kiyosaki" },
                    { 5, "Her adım, hedefe bir adım daha yaklaşmaktır.", "Confucius" },
                    { 6, "Engeller sadece hedefe giden yolda ki yönlendirmelerdir.", "Barbara Sher" },
                    { 7, "Zorluklar, gerçek potansiyelinizi ortaya çıkarmak için fırsatlardır.", "Malcolm X" },
                    { 8, "Başkalarının başarısızlıklarından değil, kendi azminizden etkilenin.", "Denis Waitley" },
                    { 9, "Başlamak için mükemmel bir zaman yoktur, zamanı kendiniz yaratırsınız.", "George Bernard Shaw" },
                    { 10, "Hayal ettiğiniz yaşamı yaşamak için şimdi adım atın.", "Sinan Taşyapar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Yazars");
        }
    }
}
