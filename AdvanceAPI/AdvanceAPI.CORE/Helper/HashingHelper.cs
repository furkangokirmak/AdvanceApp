using System.Security.Cryptography;
using System.Text;

namespace AdvanceAPI.CORE.Helper
{
    public class HashingHelper
    {
        public static bool CheckPassword(string password, byte[] passwordSalt, byte[] passwordHash)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var _passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < _passwordHash.Length; i++)
                {
                    if (passwordHash[i] != _passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public static void CreatePassword(string password, out byte[] passwordSalt, out byte[] passwordHash)
        {
            {
                using (var hmac = new HMACSHA512())
                {
                    passwordSalt = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                    passwordHash = hmac.Key;
                }
            }
        }
    }
}
