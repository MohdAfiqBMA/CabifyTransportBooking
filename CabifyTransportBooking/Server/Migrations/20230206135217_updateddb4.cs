using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CabifyTransportBooking.Server.Migrations
{
    public partial class updateddb4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Staffs_StaffId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleCategorys_VehicleCategoryId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_StaffId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "DriverID",
                table: "Vehicles",
                newName: "VehicleOwnerId");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleCategoryId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 21, 52, 16, 894, DateTimeKind.Local).AddTicks(9301), new DateTime(2023, 2, 6, 21, 52, 16, 895, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "StaffRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 21, 52, 16, 897, DateTimeKind.Local).AddTicks(2922), new DateTime(2023, 2, 6, 21, 52, 16, 897, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "StaffRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 21, 52, 16, 897, DateTimeKind.Local).AddTicks(2938), new DateTime(2023, 2, 6, 21, 52, 16, 897, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 21, 52, 16, 898, DateTimeKind.Local).AddTicks(2996), new DateTime(2023, 2, 6, 21, 52, 16, 898, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "VehicleCategorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 6, 21, 52, 16, 897, DateTimeKind.Local).AddTicks(6716), new DateTime(2023, 2, 6, 21, 52, 16, 897, DateTimeKind.Local).AddTicks(6722) });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleOwnerId",
                table: "Vehicles",
                column: "VehicleOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Staffs_VehicleOwnerId",
                table: "Vehicles",
                column: "VehicleOwnerId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleCategorys_VehicleCategoryId",
                table: "Vehicles",
                column: "VehicleCategoryId",
                principalTable: "VehicleCategorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Staffs_VehicleOwnerId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleCategorys_VehicleCategoryId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_VehicleOwnerId",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "VehicleOwnerId",
                table: "Vehicles",
                newName: "DriverID");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleCategoryId",
                table: "Vehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 2, 53, 983, DateTimeKind.Local).AddTicks(3066), new DateTime(2023, 1, 31, 0, 2, 53, 984, DateTimeKind.Local).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "StaffRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 2, 53, 985, DateTimeKind.Local).AddTicks(9304), new DateTime(2023, 1, 31, 0, 2, 53, 985, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "StaffRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 2, 53, 985, DateTimeKind.Local).AddTicks(9323), new DateTime(2023, 1, 31, 0, 2, 53, 985, DateTimeKind.Local).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 2, 53, 987, DateTimeKind.Local).AddTicks(3997), new DateTime(2023, 1, 31, 0, 2, 53, 987, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "VehicleCategorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 2, 53, 986, DateTimeKind.Local).AddTicks(5862), new DateTime(2023, 1, 31, 0, 2, 53, 986, DateTimeKind.Local).AddTicks(5872) });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_StaffId",
                table: "Vehicles",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Staffs_StaffId",
                table: "Vehicles",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleCategorys_VehicleCategoryId",
                table: "Vehicles",
                column: "VehicleCategoryId",
                principalTable: "VehicleCategorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
