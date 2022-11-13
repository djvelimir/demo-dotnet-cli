using AutoFixture.Xunit2;
using DemoDotnetCli.Generator;
using DemoDotnetCli.Shuffler;
using Moq;

namespace DemoDotnetCli.Tests.Generator;

public class PasswordGeneratorTest
{
    [Theory, AutoMoqData]
    public void ShouldCallGenerateUppercaseCharacterTest([Frozen] IRandomCharacterGenerator randomCharacterGenerator, PasswordGenerator passwordGenerator)
    {
        passwordGenerator.Generate();

        Mock.Get(randomCharacterGenerator).Verify(mock => mock.GenerateUppercaseCharacter(), Times.Once);
    }

    [Theory, AutoMoqData]
    public void ShouldCallGenerateLowercaseCharacterTest([Frozen] IRandomCharacterGenerator randomCharacterGenerator, PasswordGenerator passwordGenerator)
    {
        passwordGenerator.Generate();

        Mock.Get(randomCharacterGenerator).Verify(mock => mock.GenerateLowercaseCharacter(), Times.Once);
    }

    [Theory, AutoMoqData]
    public void ShouldCallGenerateDigitCharacterTest([Frozen] IRandomCharacterGenerator randomCharacterGenerator, PasswordGenerator passwordGenerator)
    {
        passwordGenerator.Generate();

        Mock.Get(randomCharacterGenerator).Verify(mock => mock.GenerateDigitCharacter(), Times.Once);
    }

    [Theory, AutoMoqData]
    public void ShouldCallGenerateSpecialCharacterTest([Frozen] IRandomCharacterGenerator randomCharacterGenerator, PasswordGenerator passwordGenerator)
    {
        passwordGenerator.Generate();

        Mock.Get(randomCharacterGenerator).Verify(mock => mock.GenerateSpecialCharacter(), Times.Once);
    }

    [Theory, AutoMoqData]
    public void ShouldCallGenerateAllowedCharacter12TimesTest([Frozen] IRandomCharacterGenerator randomCharacterGenerator, PasswordGenerator passwordGenerator)
    {
        passwordGenerator.Generate();

        Mock.Get(randomCharacterGenerator).Verify(mock => mock.GenerateAllowedCharacter(), Times.Exactly(12));
    }

    [Theory, AutoMoqData]
    public void ShouldCallShuffleTest([Frozen] IStringShuffler stringShuffler, PasswordGenerator passwordGenerator)
    {
        passwordGenerator.Generate();

        Mock.Get(stringShuffler).Verify(mock => mock.Shuffle(It.IsAny<string>()), Times.Once);
    }
}