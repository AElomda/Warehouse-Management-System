using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WarehouseManagement.Migrations
{
    /// <inheritdoc />
    public partial class CreateTablesWithData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3d051043-8edc-48c1-a5ae-f6ed823cee67"), "Books" },
                    { new Guid("924d5522-4d62-4b6d-afdb-b8fff726d885"), "Furniture" },
                    { new Guid("edcdd703-121f-4ada-ad3a-e54a21dc5870"), "Clothing" },
                    { new Guid("fa3cd20b-a03d-49f9-a103-2cc3ce2d9b86"), "Electronics" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Cost", "Count", "Description", "ImageURL", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0421bab5-2b06-48d0-a776-2a13d3abc7b9"), new Guid("3d051043-8edc-48c1-a5ae-f6ed823cee67"), 30m, 80, "Master ASP.NET Core development", null, "ASP.NET Core Development", 50m },
                    { new Guid("4cfe0d79-30f8-4072-85dc-25f2f16ac254"), new Guid("edcdd703-121f-4ada-ad3a-e54a21dc5870"), 30m, 150, "Denim jeans with a slim fit", null, "Jeans", 50m },
                    { new Guid("5947c8d3-0960-4451-916e-a32b5a3c92ba"), new Guid("fa3cd20b-a03d-49f9-a103-2cc3ce2d9b86"), 500m, 100, "Latest model smartphone", null, "Smartphone", 700m },
                    { new Guid("5e414601-1c81-4a23-bec0-8972cd4332e5"), new Guid("edcdd703-121f-4ada-ad3a-e54a21dc5870"), 10m, 200, "Comfortable cotton t-shirt", null, "T-Shirt", 20m },
                    { new Guid("5fee89c3-e084-4823-9dce-79a289fa6487"), new Guid("3d051043-8edc-48c1-a5ae-f6ed823cee67"), 20m, 110, "Learn EF Core with practical examples", null, "Entity Framework Core", 35m },
                    { new Guid("838f47db-ab27-4406-937e-ab56d7eeab60"), new Guid("fa3cd20b-a03d-49f9-a103-2cc3ce2d9b86"), 150m, 150, "Noise-cancelling wireless headphones", null, "Headphones", 200m },
                    { new Guid("87945a8c-48a2-417a-9eb9-cbfbdea851ac"), new Guid("924d5522-4d62-4b6d-afdb-b8fff726d885"), 400m, 20, "Comfortable 3-seater sofa", null, "Sofa", 600m },
                    { new Guid("aa968641-35c8-4aef-acdd-65fca40aa6da"), new Guid("edcdd703-121f-4ada-ad3a-e54a21dc5870"), 70m, 60, "Warm winter jacket", null, "Jacket", 100m },
                    { new Guid("b765edd0-2e57-49a8-8c40-92692597262d"), new Guid("924d5522-4d62-4b6d-afdb-b8fff726d885"), 200m, 30, "Wooden dining table with a modern design", null, "Dining Table", 300m },
                    { new Guid("c4fe4736-b885-4c9c-ad7a-1649be89cad5"), new Guid("fa3cd20b-a03d-49f9-a103-2cc3ce2d9b86"), 120m, 80, "A smartwatch with fitness tracking", null, "Smartwatch", 180m },
                    { new Guid("d4489612-fe42-4f92-bbbf-a1c9dbfd4d44"), new Guid("3d051043-8edc-48c1-a5ae-f6ed823cee67"), 25m, 120, "An in-depth guide to C# programming", null, "C# Programming", 40m },
                    { new Guid("ebe93dd4-debc-4af7-9ba1-d6312bcb65d8"), new Guid("fa3cd20b-a03d-49f9-a103-2cc3ce2d9b86"), 800m, 50, "A high-performance laptop", null, "Laptop", 1000m },
                    { new Guid("f5ca3c48-a90a-42c7-950e-566c849fbce6"), new Guid("924d5522-4d62-4b6d-afdb-b8fff726d885"), 100m, 70, "Ergonomic office chair with adjustable height", null, "Office Chair", 150m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
