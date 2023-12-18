using System;

namespace AdvanceAPI.ExceptionHandling.Base
{
    [Serializable]
    public abstract class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
