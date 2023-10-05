using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Libriary.Migrations
{
    /// <inheritdoc />
    public partial class AddParkingPathServvicetoAppContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Client_ClientId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Scooter_ScooterId",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Staff_StaffId",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Payment_ClientId",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Service",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Payment");

            migrationBuilder.RenameTable(
                name: "Service",
                newName: "Services");

            migrationBuilder.RenameIndex(
                name: "IX_Service_StaffId",
                table: "Services",
                newName: "IX_Services_StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_Service_ScooterId",
                table: "Services",
                newName: "IX_Services_ScooterId");

            migrationBuilder.AddColumn<int>(
                name: "ParkingId",
                table: "Scooter",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Services",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Town = table.Column<string>(type: "text", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: false),
                    Build = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AddressId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parking_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Path",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AddressFromId = table.Column<int>(type: "integer", nullable: false),
                    AddressToId = table.Column<int>(type: "integer", nullable: false),
                    PathLenght = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Path", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Path_Addresses_AddressFromId",
                        column: x => x.AddressFromId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Path_Addresses_AddressToId",
                        column: x => x.AddressToId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Scooter_ParkingId",
                table: "Scooter",
                column: "ParkingId");

            migrationBuilder.CreateIndex(
                name: "IX_Parking_AddressId",
                table: "Parking",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Path_AddressFromId",
                table: "Path",
                column: "AddressFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Path_AddressToId",
                table: "Path",
                column: "AddressToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Scooter_Parking_ParkingId",
                table: "Scooter",
                column: "ParkingId",
                principalTable: "Parking",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Scooter_ScooterId",
                table: "Services",
                column: "ScooterId",
                principalTable: "Scooter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Staff_StaffId",
                table: "Services",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scooter_Parking_ParkingId",
                table: "Scooter");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Scooter_ScooterId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Staff_StaffId",
                table: "Services");

            migrationBuilder.DropTable(
                name: "Parking");

            migrationBuilder.DropTable(
                name: "Path");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Scooter_ParkingId",
                table: "Scooter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ParkingId",
                table: "Scooter");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "Service");

            migrationBuilder.RenameIndex(
                name: "IX_Services_StaffId",
                table: "Service",
                newName: "IX_Service_StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_ScooterId",
                table: "Service",
                newName: "IX_Service_ScooterId");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Payment",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Service",
                table: "Service",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ClientId",
                table: "Payment",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Client_ClientId",
                table: "Payment",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Scooter_ScooterId",
                table: "Service",
                column: "ScooterId",
                principalTable: "Scooter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Staff_StaffId",
                table: "Service",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
