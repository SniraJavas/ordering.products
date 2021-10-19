using Microsoft.EntityFrameworkCore.Migrations;

namespace ordering.products.api.Migrations
{
    public partial class Execute_PopulateProduct_SP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var StoredProcedure = @"EXEC PopulateProducts";

            migrationBuilder.Sql(StoredProcedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
