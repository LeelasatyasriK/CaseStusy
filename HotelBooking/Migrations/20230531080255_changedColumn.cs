using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBooking.Migrations
{
    /// <inheritdoc />
    public partial class changedColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaymentMethod",
                table: "Payment",
                newName: "CreditCardDetalis");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreditCardDetalis",
                table: "Payment",
                newName: "PaymentMethod");
        }
    }
}
