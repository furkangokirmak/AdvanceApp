using AdvanceAPI.ExceptionHandling.Base;
using System;

namespace AdvanceAPI.ExceptionHandling.Employee
{
    [Serializable]
    public class DuplicateEmployeeException : NotFoundException
    {
        public DuplicateEmployeeException(string message) : base(message)
        {

        }
    }
}
