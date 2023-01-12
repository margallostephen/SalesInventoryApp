using System.Security.Cryptography;
using Konscious.Security.Cryptography;

namespace SalesInventoryApp
{
    internal class PasswordSecurity
    {
        public static byte[] CreateHash(byte[] password, byte[] salt)
        {
            using var argon2id = new Argon2id(password);
            argon2id.Salt = salt;
            argon2id.DegreeOfParallelism = 8;
            argon2id.Iterations = 4;
            argon2id.MemorySize = 1024 * 128;
            return argon2id.GetBytes(32);
        }

        public static bool VerifyHash(byte[] password, byte[] salt, byte[] hash) =>
            CreateHash(password, salt).SequenceEqual(hash);

        public static byte[] GenerateSalt()
        {
            var buffer = new byte[32];
            using var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(buffer);
            return buffer;
        }
    }
}
