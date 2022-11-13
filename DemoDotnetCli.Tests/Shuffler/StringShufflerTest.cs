using DemoDotnetCli.Shuffler;

namespace DemoDotnetCli.Tests.Shuffler;

public class StringShufflerTest
{
    [Theory, AutoMoqData]
    public void checkShuffleMethod(StringShuffler stringShuffler)
    {
        string sample = "1A8!(,wV5YuI[Vr^>";
        string actual = stringShuffler.Shuffle(sample);

        Assert.NotEqual(sample, actual);
        Assert.Equal(sample.Length, actual.Length);

        foreach (char item in sample)
        {
            Assert.True(actual.Contains(item));
        }
    }
}