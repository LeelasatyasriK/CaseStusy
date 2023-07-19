using HotelBooking.DataModels;

namespace HotelBooking.Repositories
{
    public interface IBillRepository
    {
        Task<Bill> GetBillAsync(Guid billId);
        Task<Bill> AddBillDetails(Bill request);
    }
}
