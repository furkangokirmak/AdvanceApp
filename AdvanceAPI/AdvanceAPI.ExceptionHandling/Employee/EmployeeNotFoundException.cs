using System;
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
