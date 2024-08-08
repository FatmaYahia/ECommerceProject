using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Offer = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cover = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemViews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemViews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemUserPermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fk_systemUser = table.Column<int>(type: "int", nullable: false),
                    Fk_accessLevel = table.Column<int>(type: "int", nullable: false),
                    Fk_systemView = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemUserPermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemUserPermissions_AccessLevels_Fk_accessLevel",
                        column: x => x.Fk_accessLevel,
                        principalTable: "AccessLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SystemUserPermissions_SystemUsers_Fk_systemUser",
                        column: x => x.Fk_systemUser,
                        principalTable: "SystemUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SystemUserPermissions_SystemViews_Fk_systemView",
                        column: x => x.Fk_systemView,
                        principalTable: "SystemViews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fk_user = table.Column<int>(type: "int", nullable: false),
                    Fk_Product = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Products_Fk_Product",
                        column: x => x.Fk_Product,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_Fk_user",
                        column: x => x.Fk_user,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fk_user = table.Column<int>(type: "int", nullable: false),
                    Fk_Product = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductRatings_Products_Fk_Product",
                        column: x => x.Fk_Product,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductRatings_Users_Fk_user",
                        column: x => x.Fk_user,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccessLevels",
                columns: new[] { "Id", "CreatedAt", "LastModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8003), new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8016), "FullAccess" },
                    { 2, new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8019), new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8020), "ControlAccess" },
                    { 3, new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8021), new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8022), "ViewAccess" }
                });

            migrationBuilder.InsertData(
                table: "SystemUsers",
                columns: new[] { "Id", "CreatedAt", "Email", "FullName", "IsActive", "JobTitle", "LastModifiedAt", "Password" },
                values: new object[] { 1, new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8216), "Admin@App.com", "Admin", true, "Admin", new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8217), "eddc1212gk" });

            migrationBuilder.InsertData(
                table: "SystemViews",
                columns: new[] { "Id", "CreatedAt", "LastModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8183), new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8184), "Home" },
                    { 2, new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8186), new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8187), "SystemView" },
                    { 3, new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8188), new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8189), "SystemUser" }
                });

            migrationBuilder.InsertData(
                table: "SystemUserPermissions",
                columns: new[] { "Id", "CreatedAt", "Fk_accessLevel", "Fk_systemUser", "Fk_systemView", "LastModifiedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8377), 1, 1, 1, new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8379) },
                    { 2, new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8382), 1, 1, 2, new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8382) },
                    { 3, new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8384), 1, 1, 3, new DateTime(2024, 8, 8, 6, 19, 36, 274, DateTimeKind.Local).AddTicks(8384) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Fk_Product",
                table: "Orders",
                column: "Fk_Product");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Fk_user",
                table: "Orders",
                column: "Fk_user");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRatings_Fk_Product",
                table: "ProductRatings",
                column: "Fk_Product");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRatings_Fk_user",
                table: "ProductRatings",
                column: "Fk_user");

            migrationBuilder.CreateIndex(
                name: "IX_SystemUserPermissions_Fk_accessLevel",
                table: "SystemUserPermissions",
                column: "Fk_accessLevel");

            migrationBuilder.CreateIndex(
                name: "IX_SystemUserPermissions_Fk_systemUser",
                table: "SystemUserPermissions",
                column: "Fk_systemUser");

            migrationBuilder.CreateIndex(
                name: "IX_SystemUserPermissions_Fk_systemView",
                table: "SystemUserPermissions",
                column: "Fk_systemView");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductRatings");

            migrationBuilder.DropTable(
                name: "SystemUserPermissions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AccessLevels");

            migrationBuilder.DropTable(
                name: "SystemUsers");

            migrationBuilder.DropTable(
                name: "SystemViews");
        }
    }
}
