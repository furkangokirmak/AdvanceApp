﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
