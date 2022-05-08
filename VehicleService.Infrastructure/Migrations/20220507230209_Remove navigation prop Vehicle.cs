using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleService.Infrastructure.Migrations
{
    public partial class RemovenavigationpropVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 1, 2, 9, 408, DateTimeKind.Local).AddTicks(3142), new DateTime(2022, 5, 8, 1, 2, 9, 410, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5356), new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5526), new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5560), new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5605), new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5667), new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5709), new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5729), new DateTime(2022, 5, 8, 1, 2, 9, 411, DateTimeKind.Local).AddTicks(5732) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
