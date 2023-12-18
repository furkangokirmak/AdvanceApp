using AdvanceAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Abstract
{
    public interface IAuthDAL
    {
        Task<Employee> Login(string email);
        Task<bool> Register(Employee employee);
        Task<Employee> GetEmployeeByEmail(string email);
        Task<bool> SetPassword(Employee employee);
    }
}
