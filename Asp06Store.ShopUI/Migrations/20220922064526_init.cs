using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asp06Store.ShopUI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Mobile", "sumsumng 1 best mobile for this price", "sumsumng 1", 30000000 },
                    { 2, "Mobile", " sumsumng 2 best mobile for this price", "sumsumng 2", 30000000 },
                    { 3, "Mobile", " IPhone 2 best mobile for this price", "IPhone 3", 30000000 },
                    { 4, "Mobile", " IPhone 4 best mobile for this price", "IPhone 4", 30000000 },
                    { 5, "Mobile", " IPhone 5 best mobile for this price", "Xiomi 5", 30000000 },
                    { 6, "Loptop", "sumsumng 1 best mobile for this price", "asus 6", 30000000 },
                    { 7, "Loptop", " sumsumng 2 best mobile for this price", "hp 7", 30000000 },
                    { 8, "Loptop", " IPhone 2 best mobile for this price", "vivo 8", 30000000 },
                    { 9, "Loptop", " IPhone 4 best mobile for this price", "asus 9", 30000000 },
                    { 10, "Loptop", " IPhone 5 best mobile for this price", "Xiomi 10", 30000000 },
                    { 11, "Pc", " sumsumng 2 best mobile for this price", "pc 11", 30000000 },
                    { 12, "Pc", " IPhone 2 best mobile for this price", "vivo 12", 30000000 },
                    { 13, "Pc", " IPhone 4 best mobile for this price", "asus 13", 30000000 },
                    { 14, "Pc", " IPhone 4 best mobile for this price", "asus 14", 30000000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
