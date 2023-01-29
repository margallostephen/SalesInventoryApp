using Konscious.Security.Cryptography;
using System.Security.Cryptography;

namespace SalesInventoryApp
{
    internal class PasswordSecurity
    {
        public static byte[] CreateHash(byte[] password, byte[] salt)
        {
            using var argon2id = new Argon2id(password);
            argon2id.Salt = salt;
            argon2id.DegreeOfParallelism = 10;
            argon2id.Iterations = 8;
            argon2id.MemorySize = 1024 * 128;
            return argon2id.GetBytes(128);
        }

        public static bool VerifyHash(byte[] password, byte[] salt, byte[] hash) =>
            CreateHash(password, salt).SequenceEqual(hash);

        public static byte[] GenerateSalt()
        {
            byte[] buffer = new byte[128];
            using RandomNumberGenerator rng = RandomNumberGenerator.Create();
            rng.GetBytes(buffer);
            return buffer;
        }
    }
}
