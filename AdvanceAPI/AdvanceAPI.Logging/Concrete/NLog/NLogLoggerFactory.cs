using AdvanceAPI.Logging.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.Logging.Concrete.NLog
{
    public class NLogLoggerFactory : ILoggerFactory
    {
        public ILog CreateLogger()
        {
            return new NLogLogger();
        }
    }
}
