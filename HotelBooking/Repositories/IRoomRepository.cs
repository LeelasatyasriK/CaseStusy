using HotelBooking.DataModels;

namespace HotelBooking.Repositories
{
    public interface IRoomRepository
    {
        Task<List<Room>> GetRoomsAsync();
        Task<Room> GetRoomAsync(int Roomnumber);
        Task<bool> Exists(int Roomnumber);
        Task<Room> UpdateRoom(int Roomnumber, Room request);
        Task<Room> DeleteRoom(int Roomnumber);
        Task<Room> AddRoom(Room request);
        Task<List<Room>> SearchRoom(string status);
    }
}
