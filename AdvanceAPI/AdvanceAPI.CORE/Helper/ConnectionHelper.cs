using Microsoft.Extensions.Configuration;

namespace AdvanceAPI.CORE.Helper
{
    public class ConnectionHelper
    {
        private static IConfiguration _configuration = null!;

        public static void SetConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static IConfiguration GetConfiguration()
        {
            return _configuration;
        }

        public static string GetConnectionString()
        {
            return GetConfiguration().GetSection("ConnectionStrings:dapperConn").Value;
        }
    }
}
