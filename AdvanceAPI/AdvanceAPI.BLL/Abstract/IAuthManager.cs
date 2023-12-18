using AdvanceAPI;
using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Abstract
{
    public interface IAuthManager
    {
		Task<Result<string>> ForgotPassword(EmployeeSelectDTO dto);
		Task<Result<EmployeeSelectDTO>> Login(EmployeeLoginDTO employeeLoginDTO);
        Task<Result<bool>> Register(EmployeeRegisterDTO employeeRegisterDTO);
		Task<Result<EmployeeSelectDTO>> GetEmployeeByResetToken(string resetToken);
        Task<Result<EmployeeLoginDTO>> SetPassword(EmployeeLoginDTO employeeLoginDTO);
    }
}
