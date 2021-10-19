using Microsoft.EntityFrameworkCore.Migrations;

namespace ordering.products.api.Migrations
{
    public partial class newTablesWithIntID : Migration
    {
         protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
       name: "Orders",
       columns: table => new
       {
           Id = table.Column<string>(type: "int", nullable: false),
           UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
           Total = table.Column<double>(type: "float", nullable: false)
       });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<string>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                });

        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
