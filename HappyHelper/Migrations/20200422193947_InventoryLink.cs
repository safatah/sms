using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHelper.Migrations
{
    public partial class InventoryLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "InventoryTracker",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InventoryTracker_UserId",
                table: "InventoryTracker",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryTracker_AspNetUsers_UserId",
                table: "InventoryTracker",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryTracker_AspNetUsers_UserId",
                table: "InventoryTracker");

            migrationBuilder.DropIndex(
                name: "IX_InventoryTracker_UserId",
                table: "InventoryTracker");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "InventoryTracker");
        }
    }
}
