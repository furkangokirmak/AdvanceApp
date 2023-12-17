using AdvanceAPI.Logging.Abstract;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.Logging.Concrete.NLog
{
    public class NLogLogger : ILog
    {
        private readonly Logger logger;

        public NLogLogger()
        {
            logger = LogManager.GetCurrentClassLogger();
        }

        public void Log(string message)
        {
            logger.Info(message);
        }
    }
}
