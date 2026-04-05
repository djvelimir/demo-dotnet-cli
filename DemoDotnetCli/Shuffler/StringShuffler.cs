using System.Security.Cryptography;

namespace DemoDotnetCli.Shuffler;

public class StringShuffler : IStringShuffler
{
    private readonly RandomNumberGenerator random;

    public StringShuffler()
    {
        random = RandomNumberGenerator.Create();
    }

    public string Shuffle(string characters)
    {
        IList<string> list = characters.Select(x => x.ToString()).ToList();
        int n = list.Count;

        while (n > 1)
        {
            n--;
            int k = RandomNext(n + 1);
            string value = list[k];
            list[k] = list[n];
            list[n] = value;
        }

        return string.Join("", list);
    }

    private int RandomNext(int maxValue)
    {
        byte[] bytes = new byte[4];
        random.GetBytes(bytes);
        int value = BitConverter.ToInt32(bytes, 0) & int.MaxValue;
        return value % maxValue;
    }
}