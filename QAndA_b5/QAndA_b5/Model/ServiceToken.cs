using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace QAndA_b5.Model
{
    public class ServiceToken
    {
        private readonly IConfiguration _configuration;

        public ServiceToken(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public static string GenerateServiceToken()
        {
            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("6f91f332-c191-4f29-9626-c0e74f271824"));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var listClaims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, "Nafiur"),
                //new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                //new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString()),
                new Claim(ClaimTypes.NameIdentifier,  "Nafiur"),
                new Claim(ClaimTypes.Name, "Nafiur" ),
                new Claim(ClaimTypes.Email, "Nafiur" ),
            };


            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = "NafiurRahmanIT",
                Audience = "NafiurRahmanIT",
                SigningCredentials = credentials,
                Subject = new ClaimsIdentity(listClaims),
                //NotBefore = dateCreate,
                Expires = DateTime.Now.AddDays(50),
            };
            var handler = new Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler();
            var securityToken = handler.CreateToken(tokenDescriptor);
            var token = securityToken;

            return token.ToString();
        }
    }
}
