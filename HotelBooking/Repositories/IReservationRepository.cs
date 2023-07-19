using HotelBooking.DataModels;

namespace HotelBooking.Repositories
{
    public interface IReservationRepository
    {
        Task<List<Reservation>> GetReservationsAsync();
        Task<Reservation> GetReservationAsync(Guid reservationId);
        Task<bool> Exists(Guid reservationId);
        Task<Reservation> UpdateReservationAsync(Guid reservationId, Reservation request);
        Task<Reservation> DeleteReservationAsync(Guid reservationId);
        Task<Reservation> CreateReservationAsync(Reservation request);
    }
}
