using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BathBombMVC.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flavour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Flavour", "ListPrice", "Price", "Price100", "Price50", "ProductName", "Size" },
                values: new object[,]
                {
                    { 1, "Gaze at this ancient relic of blue steel, purple iris, and liquid gold foam", "Salted Caramel", 99.0, 90.0, 80.0, 85.0, "Artifact", "220G BATH BOMB" },
                    { 2, "\"Wild\" is the perfect word to describe the hypnotic bath art this bath bomb creates.", "Cake Batter", 40.0, 30.0, 20.0, 25.0, "Wild Child", "220G BATH BOMB" },
                    { 3, "Don't worry, we understand your desire for artisanal and one of a kind products, and the Coffee Snob is just that.", "Fresh Coffee", 55.0, 50.0, 35.0, 40.0, "Coffee Snob", "220G BATH BOMB" },
                    { 4, "Jam Donut has a white fizzy base with a hidden pink centre, topped with pink cocoa butter glaze, vegan sprinkles, and biodegradable silver glitter.", "Raspberry Jam", 70.0, 65.0, 55.0, 60.0, "Jam Donut", "220G BATH BOMB" },
                    { 5, "Fall asleep with the restful smell of lavender and warm tonka", " Lavender & Tonka", 30.0, 27.0, 20.0, 25.0, "Counting Sheep", "220G BATH BOMB" },
                    { 6, "Apple Donut has a coral pink fizzy base, topped with white cocoa butter glaze, vegan sprinkles, and biodegradable gold glitter.", "Spiced Apple", 25.0, 23.0, 20.0, 22.0, "Apple Donut", "220G BATH BOMB" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
