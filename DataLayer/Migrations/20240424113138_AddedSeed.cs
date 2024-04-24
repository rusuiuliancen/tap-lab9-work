using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4e57b9ca-9a18-4255-8f17-7591f63d1917"), "ADMIN" },
                    { new Guid("9443f48b-8a86-4818-b5e9-514d4cd0512b"), "USER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "TypeId" },
                values: new object[,]
                {
                    { new Guid("11c14a98-066a-4851-aff1-20e149d9fcd8"), "pop.ion2@gmail.com", "Popa Ion2", "pass1", new Guid("9443f48b-8a86-4818-b5e9-514d4cd0512b") },
                    { new Guid("164305dc-2f2e-4309-9d65-e5a65261ec72"), "sef.ion2@gmail.com", "Sef Ion2", "pass1", new Guid("4e57b9ca-9a18-4255-8f17-7591f63d1917") },
                    { new Guid("201349a7-45e0-463a-9604-55445842b02d"), "pop.ion@gmail.com", "Popa Ion", "pass1", new Guid("9443f48b-8a86-4818-b5e9-514d4cd0512b") },
                    { new Guid("a5e573f1-4d6a-46a1-8fe6-419d49558816"), "sef.ion2@gmail.com", "Sef Ion", "pass1", new Guid("4e57b9ca-9a18-4255-8f17-7591f63d1917") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11c14a98-066a-4851-aff1-20e149d9fcd8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("164305dc-2f2e-4309-9d65-e5a65261ec72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("201349a7-45e0-463a-9604-55445842b02d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5e573f1-4d6a-46a1-8fe6-419d49558816"));

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: new Guid("4e57b9ca-9a18-4255-8f17-7591f63d1917"));

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: new Guid("9443f48b-8a86-4818-b5e9-514d4cd0512b"));
        }
    }
}
