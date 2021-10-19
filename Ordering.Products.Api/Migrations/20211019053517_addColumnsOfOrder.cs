using Microsoft.EntityFrameworkCore.Migrations;

namespace ordering.products.api.Migrations
{
    public partial class addColumnsOfOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
            name: "ProductId",
            table: "Orders",
            type: "int",
            nullable: true);

            migrationBuilder.AddColumn<string>(
              name: "Status",
              table: "Orders",
              type: "nvarchar(12)",
              nullable: true);

            migrationBuilder.AddColumn<string>(
             name: "DateCreated",
             table: "Orders",
             type: "datetime",
             nullable: true);

            migrationBuilder.AddColumn<string>(
            name: "Active",
            table: "Orders",
            type: "bit",
            nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          
        }
    }
}
