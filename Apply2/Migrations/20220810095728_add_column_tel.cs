using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apply2.Migrations
{
    public partial class add_column_tel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tel",
                table: "T_Applys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tel",
                table: "T_Applys");
        }
    }
}
