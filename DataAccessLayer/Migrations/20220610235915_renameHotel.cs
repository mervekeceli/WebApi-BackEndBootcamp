using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class renameHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Hotels",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Hotels",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Hotels",
                newName: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Hotels",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Hotels",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Hotels",
                newName: "Id");
        }
    }
}
