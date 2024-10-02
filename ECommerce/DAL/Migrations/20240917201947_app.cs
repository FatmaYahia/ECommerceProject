using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class app : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AccessLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9322), new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "AccessLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9334), new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "AccessLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9336), new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "SystemUserPermissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9724), new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "SystemUserPermissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9729), new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "SystemUserPermissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9731), new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "SystemUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Password" },
                values: new object[] { new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9554), new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9555), "hmji7617of" });

            migrationBuilder.UpdateData(
                table: "SystemViews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9524), new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "SystemViews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9530), new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "SystemViews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9532), new DateTime(2024, 9, 17, 22, 19, 46, 461, DateTimeKind.Local).AddTicks(9532) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AccessLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8003), new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "AccessLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8019), new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "AccessLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8021), new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "SystemUserPermissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8377), new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "SystemUserPermissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8382), new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "SystemUserPermissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8384), new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "SystemUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Password" },
                values: new object[] { new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8216), new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8217), "eddc1212gk" });

            migrationBuilder.UpdateData(
                table: "SystemViews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8183), new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "SystemViews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8186), new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "SystemViews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8188), new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8189) });
        }
    }
}
