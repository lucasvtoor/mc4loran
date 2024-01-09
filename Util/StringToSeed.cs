using System.Security.Cryptography;
using System.Text;

namespace Util;

public static class StringToSeed
{
    public static int ToSeed(this string str)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(str));

            // Convert the first 4 bytes to an integer
            int seed = BitConverter.ToInt32(bytes.Take(4).ToArray(), 0);

            return seed;
        }    
    }
}