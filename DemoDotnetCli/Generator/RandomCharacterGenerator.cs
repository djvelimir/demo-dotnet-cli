using System.Security.Cryptography;

namespace DemoDotnetCli.Generator;

public class RandomCharacterGenerator : IRandomCharacterGenerator
{
    private readonly string uppercaseCharacters;
    private readonly string lowercaseCharacters;
    private readonly string digitCharacters;
    private readonly string specialCharacters;
    private readonly string allowedCharacters;
    private readonly RandomNumberGenerator random;

    public RandomCharacterGenerator()
    {
        uppercaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        lowercaseCharacters = "abcdefghijklmnopqrstuvwxyz";
        digitCharacters = "0123456789";
        specialCharacters = "~`!@#$%^&*()-_=+[{]}\\|;:\'\",<.>/?";
        allowedCharacters = uppercaseCharacters
            + lowercaseCharacters
            + digitCharacters
            + specialCharacters;
        random = RandomNumberGenerator.Create();
    }

    public char GenerateAllowedCharacter()
    {
        return allowedCharacters.ElementAt(RandomNext(allowedCharacters.Length));
    }

    public char GenerateDigitCharacter()
    {
        return digitCharacters.ElementAt(RandomNext(digitCharacters.Length));
    }

    public char GenerateLowercaseCharacter()
    {
        return lowercaseCharacters.ElementAt(RandomNext(lowercaseCharacters.Length));
    }

    public char GenerateSpecialCharacter()
    {
        return specialCharacters.ElementAt(RandomNext(specialCharacters.Length));
    }

    public char GenerateUppercaseCharacter()
    {
        return uppercaseCharacters.ElementAt(RandomNext(uppercaseCharacters.Length));
    }

    private int RandomNext(int maxValue)
    {
        byte[] bytes = new byte[4];
        random.GetBytes(bytes);
        int value = BitConverter.ToInt32(bytes, 0) & int.MaxValue;
        return value % maxValue;
    }
}