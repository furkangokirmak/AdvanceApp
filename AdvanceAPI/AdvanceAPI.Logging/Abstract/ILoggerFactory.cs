using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.Logging.Abstract
{
    public interface ILoggerFactory
    {
        ILog CreateLogger();
    }
}
