using Demo.Models;

namespace Demo.Controllers.Repository.IRepository
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
    }
}
