using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Libriary.Migrations
{
    /// <inheritdoc />
    public partial class AddFKPaymenttoRent : Migration
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

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Rent",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rent_PaymentId",
                table: "Rent",
                column: "PaymentId");

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

            migrationBuilder.DropIndex(
                name: "IX_Rent_PaymentId",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Rent");

            migrationBuilder.AddColumn<int>(
                name: "RentId",
                table: "Payment",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_RentId",
                table: "Payment",
                column: "RentId",
                unique: true);

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
