using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBooking.Migrations
{
    /// <inheritdoc />
    public partial class ChangedColumnname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreditCardDetalis",
                table: "Payment",
                newName: "CreditCardDetails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreditCardDetails",
                table: "Payment",
                newName: "CreditCardDetalis");
        }
    }
}
