using AdvanceAPI.ExceptionHandling.Base;
using System;

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
