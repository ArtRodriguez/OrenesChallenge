using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleService.Infrastructure.Migrations
{
    public partial class Uniqueconstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CreatedAt", "Latitude", "LicensePlate", "Longitude", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 7, 9, 37, 36, 993, DateTimeKind.Local).AddTicks(1916), 0.0, "0001", 0.0, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(224) },
                    { 2, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9480), 0.0, "0002", 0.0, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9496) },
                    { 3, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9650), 0.0, "0003", 0.0, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9654) },
                    { 4, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9683), 0.0, "0004", 0.0, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9686) },
                    { 5, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9707), 0.0, "0005", 0.0, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9709) },
                    { 6, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9733), 0.0, "0006", 0.0, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9736) },
                    { 7, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9753), 0.0, "0007", 0.0, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9756) },
                    { 8, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9773), 0.0, "0008", 0.0, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9775) },
                    { 9, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9793), 0.0, "0009", 0.0, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9795) },
                    { 10, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9907), 0.0, "0010", 0.0, new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9911) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_LicensePlate",
                table: "Vehicles",
                column: "LicensePlate",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TrackingCode",
                table: "Orders",
                column: "TrackingCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Vehicles_LicensePlate",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TrackingCode",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
