using DemoDotnetCli.Generator;

namespace DemoDotnetCli.Tests.Generator;

public class RandomCharacterGeneratorTest
{
    private readonly String uppercaseCharacters;
    private readonly String lowercaseCharacters;
    private readonly String digitCharacters;
    private readonly String specialCharacters;
    private readonly String allowedCharacters;

    public RandomCharacterGeneratorTest()
    {
        uppercaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        lowercaseCharacters = "abcdefghijklmnopqrstuvwxyz";
        digitCharacters = "0123456789";
        specialCharacters = "~`!@#$%^&*()-_=+[{]}\\|;:\'\",<.>/?";
        allowedCharacters = uppercaseCharacters
            + lowercaseCharacters
            + digitCharacters
            + specialCharacters;
    }

    [Theory, AutoMoqData]
    public void GenerateUppercaseCharacterTest(RandomCharacterGenerator randomCharacterGenerator)
    {
        char actual = randomCharacterGenerator.GenerateUppercaseCharacter();

        Assert.True(uppercaseCharacters.Contains(actual));
    }

    [Theory, AutoMoqData]
    public void GenerateLowercaseCharacterTest(RandomCharacterGenerator randomCharacterGenerator)
    {
        char actual = randomCharacterGenerator.GenerateLowercaseCharacter();

        Assert.True(lowercaseCharacters.Contains(actual));
    }

    [Theory, AutoMoqData]
    public void GenerateDigitCharacterTest(RandomCharacterGenerator randomCharacterGenerator)
    {
        char actual = randomCharacterGenerator.GenerateDigitCharacter();

        Assert.True(digitCharacters.Contains(actual));
    }

    [Theory, AutoMoqData]
    public void GenerateSpecialCharacterTest(RandomCharacterGenerator randomCharacterGenerator)
    {
        char actual = randomCharacterGenerator.GenerateSpecialCharacter();

        Assert.True(specialCharacters.Contains(actual));
    }

    [Theory, AutoMoqData]
    public void GenerateAllowedCharacterTest(RandomCharacterGenerator randomCharacterGenerator)
    {
        char actual = randomCharacterGenerator.GenerateAllowedCharacter();

        Assert.True(allowedCharacters.Contains(actual));
    }
}