using AdvanceAPI.ExceptionHandling.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
