using AdvanceAPI.Logging.Abstract;
using AdvanceAPI.Logging.Concrete.NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.Logging.Concrete
{
    public class LoggerFactory
    {
        public static ILoggerFactory GetLoggerFactory(string loggerType)
        {
            if (loggerType.Equals("NLog", StringComparison.OrdinalIgnoreCase))
            {
                return new NLogLoggerFactory();
            }
            else if (loggerType.Equals("Serilog", StringComparison.OrdinalIgnoreCase))
            {
                // örneğin seri log eklenmek istenirse
                //return new SerilogLoggerFactory();
            }

            throw new ArgumentException("Invalid logger type.");
        }
    }
}
