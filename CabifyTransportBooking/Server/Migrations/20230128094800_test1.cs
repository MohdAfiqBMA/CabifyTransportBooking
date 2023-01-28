using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CabifyTransportBooking.Server.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 28, 17, 48, 0, 168, DateTimeKind.Local).AddTicks(1822), new DateTime(2023, 1, 28, 17, 48, 0, 169, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "StaffRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 28, 17, 48, 0, 170, DateTimeKind.Local).AddTicks(6343), new DateTime(2023, 1, 28, 17, 48, 0, 170, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "StaffRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 28, 17, 48, 0, 170, DateTimeKind.Local).AddTicks(6356), new DateTime(2023, 1, 28, 17, 48, 0, 170, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 28, 17, 48, 0, 171, DateTimeKind.Local).AddTicks(3078), new DateTime(2023, 1, 28, 17, 48, 0, 171, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "VehicleCategorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 28, 17, 48, 0, 170, DateTimeKind.Local).AddTicks(9321), new DateTime(2023, 1, 28, 17, 48, 0, 170, DateTimeKind.Local).AddTicks(9327) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 26, 23, 44, 25, 94, DateTimeKind.Local).AddTicks(6129), new DateTime(2023, 1, 26, 23, 44, 25, 95, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "StaffRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 26, 23, 44, 25, 96, DateTimeKind.Local).AddTicks(7380), new DateTime(2023, 1, 26, 23, 44, 25, 96, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "StaffRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 26, 23, 44, 25, 96, DateTimeKind.Local).AddTicks(7392), new DateTime(2023, 1, 26, 23, 44, 25, 96, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 26, 23, 44, 25, 97, DateTimeKind.Local).AddTicks(5128), new DateTime(2023, 1, 26, 23, 44, 25, 97, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "VehicleCategorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 26, 23, 44, 25, 97, DateTimeKind.Local).AddTicks(797), new DateTime(2023, 1, 26, 23, 44, 25, 97, DateTimeKind.Local).AddTicks(802) });
        }
    }
}
