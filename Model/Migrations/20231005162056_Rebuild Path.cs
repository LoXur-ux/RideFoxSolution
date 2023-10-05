using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Libriary.Migrations
{
    /// <inheritdoc />
    public partial class RebuildPath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Path_Addresses_AddressFromId",
                table: "Path");

            migrationBuilder.DropForeignKey(
                name: "FK_Path_Addresses_AddressToId",
                table: "Path");

            migrationBuilder.RenameColumn(
                name: "AddressToId",
                table: "Path",
                newName: "ToId");

            migrationBuilder.RenameColumn(
                name: "AddressFromId",
                table: "Path",
                newName: "FromId");

            migrationBuilder.RenameIndex(
                name: "IX_Path_AddressToId",
                table: "Path",
                newName: "IX_Path_ToId");

            migrationBuilder.RenameIndex(
                name: "IX_Path_AddressFromId",
                table: "Path",
                newName: "IX_Path_FromId");

            migrationBuilder.AddColumn<int>(
                name: "PathId",
                table: "Rent",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rent_PathId",
                table: "Rent",
                column: "PathId");

            migrationBuilder.AddForeignKey(
                name: "FK_Path_Parking_FromId",
                table: "Path",
                column: "FromId",
                principalTable: "Parking",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Path_Parking_ToId",
                table: "Path",
                column: "ToId",
                principalTable: "Parking",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_Path_PathId",
                table: "Rent",
                column: "PathId",
                principalTable: "Path",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Path_Parking_FromId",
                table: "Path");

            migrationBuilder.DropForeignKey(
                name: "FK_Path_Parking_ToId",
                table: "Path");

            migrationBuilder.DropForeignKey(
                name: "FK_Rent_Path_PathId",
                table: "Rent");

            migrationBuilder.DropIndex(
                name: "IX_Rent_PathId",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "PathId",
                table: "Rent");

            migrationBuilder.RenameColumn(
                name: "ToId",
                table: "Path",
                newName: "AddressToId");

            migrationBuilder.RenameColumn(
                name: "FromId",
                table: "Path",
                newName: "AddressFromId");

            migrationBuilder.RenameIndex(
                name: "IX_Path_ToId",
                table: "Path",
                newName: "IX_Path_AddressToId");

            migrationBuilder.RenameIndex(
                name: "IX_Path_FromId",
                table: "Path",
                newName: "IX_Path_AddressFromId");

            migrationBuilder.AddForeignKey(
                name: "FK_Path_Addresses_AddressFromId",
                table: "Path",
                column: "AddressFromId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Path_Addresses_AddressToId",
                table: "Path",
                column: "AddressToId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
