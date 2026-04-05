using System.Security.Cryptography;
using DemoDotnetCli.Extensions;

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
            int k = random.Next(n + 1);
            string value = list[k];
            list[k] = list[n];
            list[n] = value;
        }

        return string.Join("", list);
    }
}