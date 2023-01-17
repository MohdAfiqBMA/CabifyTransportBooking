using Microsoft.EntityFrameworkCore.Migrations;

namespace CabifyTransportBooking.Server.Data.Migrations
{
    public partial class AddedNameToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Passengers_PassengerID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Staffs_DriverID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Staffs_StaffID",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_StaffID",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "StaffID",
                table: "Bookings");

            migrationBuilder.AlterColumn<int>(
                name: "PassengerID",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DriverID",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AdminID",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_AdminID",
                table: "Bookings",
                column: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Passengers_PassengerID",
                table: "Bookings",
                column: "PassengerID",
                principalTable: "Passengers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Staffs_AdminID",
                table: "Bookings",
                column: "AdminID",
                principalTable: "Staffs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Staffs_DriverID",
                table: "Bookings",
                column: "DriverID",
                principalTable: "Staffs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Passengers_PassengerID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Staffs_AdminID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Staffs_DriverID",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_AdminID",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "PassengerID",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DriverID",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdminID",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StaffID",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_StaffID",
                table: "Bookings",
                column: "StaffID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Passengers_PassengerID",
                table: "Bookings",
                column: "PassengerID",
                principalTable: "Passengers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Staffs_DriverID",
                table: "Bookings",
                column: "DriverID",
                principalTable: "Staffs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Staffs_StaffID",
                table: "Bookings",
                column: "StaffID",
                principalTable: "Staffs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
