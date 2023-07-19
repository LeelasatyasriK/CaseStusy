using HotelBooking.DataModels;

namespace HotelBooking.Repositories
{
    public interface IPaymentRepository
    {
        Task<List<Payment>> GetPaymentsAsync();
        Task<Payment> GetPaymentAsync(Guid paymentId);
        Task<Payment> AddPaymentAsync(Payment request);
    }
}
