using AdvanceAPI.Logging.Abstract;

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
