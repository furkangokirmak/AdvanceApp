using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvanceAPI.ExceptionHandling.Base;

namespace AdvanceAPI.ExceptionHandling.Employee
{
    [Serializable]
    public class EmployeeNotFoundException : NotFoundException
    {
        public EmployeeNotFoundException(string message) : base(message)
        {
        }
    }
}
