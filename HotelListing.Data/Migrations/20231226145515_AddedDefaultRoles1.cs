using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Data.Migrations
{
    public partial class AddedDefaultRoles1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6072434d-01b1-4ff9-9883-994deee4ab9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ac0d07f-9e4e-4e62-8da5-1c8ee88842f1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f25ca915-3b3b-46c7-8720-557ba6455c70", "22656464-4c84-4e97-919e-f4925b4d9e10", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f87062c4-b23b-4d3e-8b24-e49395204f57", "f990dd7e-9967-41a0-9471-016fc77af62e", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f25ca915-3b3b-46c7-8720-557ba6455c70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f87062c4-b23b-4d3e-8b24-e49395204f57");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6072434d-01b1-4ff9-9883-994deee4ab9b", "3c842801-2e96-4d93-b2a7-f843647382e2", "User", "NAME" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7ac0d07f-9e4e-4e62-8da5-1c8ee88842f1", "06decb85-973b-4021-aaf3-486c27cdbb66", "Administrator", "ADMINISTRATOR" });
        }
    }
}
