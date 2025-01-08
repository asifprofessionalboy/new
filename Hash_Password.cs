using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
namespace GFAS.PasswordHasher
{
    public class Hash_Password
    {
        public (string hashedPassword, string salt) HashPassword(string password)
        {

            byte[] saltBytes = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }


            string salt = Convert.ToBase64String(saltBytes);


            string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: saltBytes,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return (hashedPassword, salt);
        }

        public bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
        {

            byte[] saltBytes = Convert.FromBase64String(storedSalt);


            string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: enteredPassword,
                salt: saltBytes,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));


            return hashedPassword == storedHash;
        }
    }
}
