using AdvanceAPI.ExceptionHandling.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.ExceptionHandling.Employee
{
    [Serializable]
    public class PasswordsNotMatchException : NotFoundException
    {
        public PasswordsNotMatchException(string message) : base(message)
        {
        }
    }
}
