using HotelBooking.DataModels;

namespace HotelBooking.Repositories
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetDepartmentsAsync();
        Task<Department> GetDepartmentAsync(int departmentId);
        Task<bool> Exists(int departmentId);
        Task<Department> UpdateDepartmentAsync(int departmentId,Department request);
        Task<Department> DeleteDepartmentAsync(int departmentId);
        Task<Department> AddDepartmentAsync(Department request);
    }
}
