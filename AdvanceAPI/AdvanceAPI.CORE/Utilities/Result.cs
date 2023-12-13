using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AdvanceAPI.CORE.Utilities
{
    public class Result<T>
    {
        public T Data { get; set; }
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public static Result<T> Fail(string errorMessage)
        {
            return new Result<T> { Succeeded = false, Message = errorMessage };
        }
        public static Result<T> Success(T data)
        {
            return new Result<T> { Succeeded = true, Data = data };
        }
    }
}
