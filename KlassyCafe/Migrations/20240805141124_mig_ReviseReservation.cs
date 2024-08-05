using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KlassyCafe.Migrations
{
    public partial class mig_ReviseReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Reservations",
                newName: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Reservations",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Reservations",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
