using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DTOs.Employee;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Abstract
{
	public interface IEmployeeManager
	{
		Task<Result<IEnumerable<EmployeeSelectDTO>>> GetAllEmployees();
		Task<Result<EmployeeSelectDTO>> GetEmployeeByEmail(string email);
	}
}
