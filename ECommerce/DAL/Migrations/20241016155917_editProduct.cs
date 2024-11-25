using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class editProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AccessLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(7933), new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "AccessLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(7947), new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "AccessLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(7948), new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "SystemUserPermissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(8368), new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "SystemUserPermissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(8372), new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "SystemUserPermissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(8374), new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "SystemUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Password" },
                values: new object[] { new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(8203), new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(8204), "ucou3404rb" });

            migrationBuilder.UpdateData(
                table: "SystemViews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(8170), new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "SystemViews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(8174), new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "SystemViews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(8176), new DateTime(2024, 10, 16, 17, 59, 16, 711, DateTimeKind.Local).AddTicks(8176) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Products");

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
    }
}
