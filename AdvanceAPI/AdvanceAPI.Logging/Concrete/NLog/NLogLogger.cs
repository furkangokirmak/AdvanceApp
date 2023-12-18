using AdvanceAPI.Logging.Abstract;
using NLog;

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
