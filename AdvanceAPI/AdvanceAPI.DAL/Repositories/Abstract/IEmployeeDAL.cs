using AdvanceAPI.Entities.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Abstract
{
    public interface IEmployeeDAL
    {
		Task<IEnumerable<Employee>> GetAllEmployees();
        Task<IEnumerable<Employee>> GetEmployeeById(int id);
		Task<bool> SetEmployeeResetToken(Employee emp);
		Task<Employee> GetEmployeeByResetToken(string resetToken);
	}
}
