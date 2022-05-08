using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleService.Infrastructure.Migrations
{
    public partial class fixduplicatefield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 7, 9, 37, 36, 993, DateTimeKind.Local).AddTicks(1916), new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9480), new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9650), new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9683), new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9707), new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9733), new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9753), new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9773), new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9793), new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9907), new DateTime(2022, 5, 7, 9, 37, 36, 996, DateTimeKind.Local).AddTicks(9911) });
        }
    }
}
