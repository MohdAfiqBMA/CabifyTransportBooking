using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CabifyTransportBooking.Server.Migrations
{
    public partial class createdstaffseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "PassengerAddress", "PassengerEmail", "PassengerGender", "PassengerName", "PassengerPassword", "PassengerPhone", "PassengerRating", "UpdatedBy" },
                values: new object[] { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pasir Ris 51", "benyeo@gmail.com", "Male", "Ben Yeo", "Password", "98712345", 3, null });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "RoleID", "StaffEmail", "StaffGender", "StaffName", "StaffPassword", "StaffPhoneNumber", "StaffRating", "StaffRoleId", "UpdatedBy" },
                values: new object[] { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "john123@gmail.com", "Male", "John", "password", "98765432", 4, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
