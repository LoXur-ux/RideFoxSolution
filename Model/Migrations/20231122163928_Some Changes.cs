using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Libriary.Migrations
{
    /// <inheritdoc />
    public partial class SomeChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parking_Addresses_AddressId",
                table: "Parking");

            migrationBuilder.DropForeignKey(
                name: "FK_Penalty_Addresses_AddressId",
                table: "Penalty");

            migrationBuilder.DropForeignKey(
                name: "FK_Penalty_Addresses_MVDAddressId",
                table: "Penalty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "PathLenght",
                table: "Path",
                newName: "PathLength");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parking_Address_AddressId",
                table: "Parking",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Penalty_Address_AddressId",
                table: "Penalty",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Penalty_Address_MVDAddressId",
                table: "Penalty",
                column: "MVDAddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parking_Address_AddressId",
                table: "Parking");

            migrationBuilder.DropForeignKey(
                name: "FK_Penalty_Address_AddressId",
                table: "Penalty");

            migrationBuilder.DropForeignKey(
                name: "FK_Penalty_Address_MVDAddressId",
                table: "Penalty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameColumn(
                name: "PathLength",
                table: "Path",
                newName: "PathLenght");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parking_Addresses_AddressId",
                table: "Parking",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Penalty_Addresses_AddressId",
                table: "Penalty",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Penalty_Addresses_MVDAddressId",
                table: "Penalty",
                column: "MVDAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
