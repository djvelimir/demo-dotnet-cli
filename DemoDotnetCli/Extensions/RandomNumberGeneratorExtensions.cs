using System.Security.Cryptography;

namespace DemoDotnetCli.Extensions;

public static class RandomNumberGeneratorExtensions
{
    extension(RandomNumberGenerator random)
    {
        public int Next(int maxValue)
        {
            byte[] bytes = new byte[4];
            random.GetBytes(bytes);
            int value = BitConverter.ToInt32(bytes, 0) & int.MaxValue;
            return value % maxValue;
        }
    }
}