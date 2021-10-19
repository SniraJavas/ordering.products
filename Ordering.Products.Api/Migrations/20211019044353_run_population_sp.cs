using Microsoft.EntityFrameworkCore.Migrations;

namespace ordering.products.api.Migrations
{
    public partial class run_population_sp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var StoredProcedure = @"
 
ALTER TABLE [dbo].[Products] DROP COLUMN [Id];
ALTER TABLE [dbo].[Products] ADD [Id] INT IDENTITY(1,12)
ALTER TABLE [dbo].[Products] ADD Quantity int;
ALTER TABLE [dbo].[Products] DROP COLUMN [OrderId];
ALTER TABLE [dbo].[Orders] DROP COLUMN Id;
ALTER TABLE [dbo].[Orders] ADD Id INT IDENTITY(1,12)

EXEC [dbo].[Execute_Populate_Products]";

            migrationBuilder.Sql(StoredProcedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
