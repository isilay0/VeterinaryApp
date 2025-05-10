using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Core
{
    public static class ApplicationHelper
    {
        public static string HashPassword(string password)
        {
            // Rastgele bir salt oluştur
            byte[] salt = RandomNumberGenerator.GetBytes(16);

            // PBKDF2 ile hash oluştur
            var hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                iterations: 100_000,
                hashAlgorithm: HashAlgorithmName.SHA256,
                outputLength: 32
            );

            // Salt + hash'i birleştirip base64 olarak sakla
            var result = new byte[1 + salt.Length + hash.Length];
            result[0] = 0; // versiyon
            Buffer.BlockCopy(salt, 0, result, 1, salt.Length);
            Buffer.BlockCopy(hash, 0, result, 1 + salt.Length, hash.Length);

            return Convert.ToBase64String(result);
        }
        public static bool VerifyPassword(string password, string base64Hash)
        {
            byte[] decoded = Convert.FromBase64String(base64Hash);

            if (decoded[0] != 0)
                throw new FormatException("Hash formatı bilinmiyor.");

            byte[] salt = decoded.Skip(1).Take(16).ToArray();
            byte[] storedHash = decoded.Skip(17).Take(32).ToArray();

            var computedHash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                iterations: 100_000,
                hashAlgorithm: HashAlgorithmName.SHA256,
                outputLength: 32
            );

            return CryptographicOperations.FixedTimeEquals(storedHash, computedHash);
        }
        public static string GenerateToken(Doctor doctor)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("XdfL7i0W1thfs6My4NeWi2WEOn6TjwvS"));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Rsa, doctor.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName, doctor.Email!),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, "User") // örnek roller
            };

            var token = new JwtSecurityToken(
                issuer: "VetApp",
                audience: "Doctor",
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public static ClaimsPrincipal? ParseToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes("XdfL7i0W1thfs6My4NeWi2WEOn6TjwvS");

            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = "VetApp",
                ValidateAudience = true,
                ValidAudience = "Doctor",
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ClockSkew = TimeSpan.Zero // süresi dolmuş token'larda tolerans tanıma
            };

            try
            {
                var principal = tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);
                return principal;
            }
            catch
            {
                return null; // doğrulama başarısız
            }
        }
    }
}
