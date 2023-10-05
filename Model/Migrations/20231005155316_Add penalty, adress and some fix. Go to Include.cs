using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Libriary.Migrations
{
    /// <inheritdoc />
    public partial class AddpenaltyadressandsomefixGotoInclude : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Rent_RentId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_RentId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "RentId",
                table: "Payment");

            migrationBuilder.AlterColumn<DateTime>(
                name: "End",
                table: "Rent",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Rent",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Penalty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<int>(type: "integer", nullable: false),
                    Link = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    AddressId = table.Column<int>(type: "integer", nullable: false),
                    MVDAddressId = table.Column<int>(type: "integer", nullable: false),
                    InspectorFIO = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penalty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Penalty_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Penalty_Addresses_MVDAddressId",
                        column: x => x.MVDAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Penalty_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rent_PaymentId",
                table: "Rent",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Penalty_AddressId",
                table: "Penalty",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Penalty_ClientId",
                table: "Penalty",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Penalty_MVDAddressId",
                table: "Penalty",
                column: "MVDAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_Payment_PaymentId",
                table: "Rent",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rent_Payment_PaymentId",
                table: "Rent");

            migrationBuilder.DropTable(
                name: "Penalty");

            migrationBuilder.DropIndex(
                name: "IX_Rent_PaymentId",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Rent");

            migrationBuilder.AlterColumn<DateTime>(
                name: "End",
                table: "Rent",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RentId",
                table: "Payment",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_RentId",
                table: "Payment",
                column: "RentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Rent_RentId",
                table: "Payment",
                column: "RentId",
                principalTable: "Rent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
