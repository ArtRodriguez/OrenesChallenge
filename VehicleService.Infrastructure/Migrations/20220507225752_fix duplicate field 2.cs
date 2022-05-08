using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleService.Infrastructure.Migrations
{
    public partial class fixduplicatefield2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoricalLocations_Vehicles_VehicleId1",
                table: "HistoricalLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Vehicles_VehicleId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_VehicleId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_HistoricalLocations_VehicleId1",
                table: "HistoricalLocations");

            migrationBuilder.DropColumn(
                name: "VehicleId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "VehicleId1",
                table: "HistoricalLocations");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 57, 52, 100, DateTimeKind.Local).AddTicks(7500), new DateTime(2022, 5, 8, 0, 57, 52, 103, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(8945), new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(9218), new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(9263), new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(9286), new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(9311), new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(9332), new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(9363), new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(9397), new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(9429), new DateTime(2022, 5, 8, 0, 57, 52, 104, DateTimeKind.Local).AddTicks(9432) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehicleId1",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehicleId1",
                table: "HistoricalLocations",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 49, 34, 319, DateTimeKind.Local).AddTicks(9456), new DateTime(2022, 5, 8, 0, 49, 34, 323, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(3629), new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(3935), new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(3974), new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(3995), new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4090), new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4117), new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4138), new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4158), new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4179), new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_VehicleId1",
                table: "Orders",
                column: "VehicleId1");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricalLocations_VehicleId1",
                table: "HistoricalLocations",
                column: "VehicleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricalLocations_Vehicles_VehicleId1",
                table: "HistoricalLocations",
                column: "VehicleId1",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Vehicles_VehicleId1",
                table: "Orders",
                column: "VehicleId1",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
