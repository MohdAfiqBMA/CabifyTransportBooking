using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CabifyTransportBooking.Server.Migrations
{
    public partial class createdController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2023, 1, 26, 18, 14, 2, 631, DateTimeKind.Local).AddTicks(8996), new DateTime(2023, 1, 26, 18, 14, 2, 632, DateTimeKind.Local).AddTicks(6271), "System" });

            migrationBuilder.InsertData(
                table: "StaffRoles",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "RoleDescription", "RoleName", "RoleType", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 26, 18, 14, 2, 634, DateTimeKind.Local).AddTicks(5021), new DateTime(2023, 1, 26, 18, 14, 2, 634, DateTimeKind.Local).AddTicks(5026), "Support employees by assigning tasks", "Admin", "Admin", "System" },
                    { 2, "System", new DateTime(2023, 1, 26, 18, 14, 2, 634, DateTimeKind.Local).AddTicks(5029), new DateTime(2023, 1, 26, 18, 14, 2, 634, DateTimeKind.Local).AddTicks(5030), "Drive passengers to the intended destination", "Driver", "Driver", "System" }
                });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "RoleID", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2023, 1, 26, 18, 14, 2, 634, DateTimeKind.Local).AddTicks(1460), new DateTime(2023, 1, 26, 18, 14, 2, 634, DateTimeKind.Local).AddTicks(1608), 2, "System" });

            migrationBuilder.InsertData(
                table: "VehicleCategorys",
                columns: new[] { "Id", "Capacity", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Price", "UpdatedBy" },
                values: new object[] { 1, 4, "System", new DateTime(2023, 1, 26, 18, 14, 2, 635, DateTimeKind.Local).AddTicks(1223), new DateTime(2023, 1, 26, 18, 14, 2, 635, DateTimeKind.Local).AddTicks(1228), "Cabify Standard", 12f, "System" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CategoryID", "CreatedBy", "DateCreated", "DateUpdated", "DriverID", "LicensePlateNumber", "StaffId", "UpdatedBy", "VehicleCategoryId", "VehicleMake", "VehicleModel" },
                values: new object[] { 1, 1, "System", new DateTime(2023, 1, 26, 18, 14, 2, 634, DateTimeKind.Local).AddTicks(8137), new DateTime(2023, 1, 26, 18, 14, 2, 634, DateTimeKind.Local).AddTicks(8142), 1, "SMU142N", null, "System", null, "BMW", "X1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StaffRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StaffRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleCategorys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "RoleID", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null });
        }
    }
}
