using AdvanceAPI.Entities.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.CORE.Helper
{
    public class TokenHelper
    {
        private readonly IConfiguration _conf;

        public TokenHelper(IConfiguration conf)
        {
            _conf = conf;
        }

        public string CreateToken(Employee employee)
        {
            var tokenDesc = new SecurityTokenDescriptor()
            {

                Expires = DateTime.Now.AddMinutes(20),
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name,employee.Email)
                }),
                Issuer = _conf["JwtIssuer"],
                Audience = _conf["JwtAudience"],
                NotBefore = DateTime.Now,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_conf["JwtSecurityKey"])), SecurityAlgorithms.HmacSha256)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDesc);
            var token = tokenHandler.WriteToken(securityToken);

            return token;
        }
    }
}
