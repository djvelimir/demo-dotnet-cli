namespace DemoDotnetCli.Generator;

public class RandomCharacterGenerator : IRandomCharacterGenerator
{
    private readonly string uppercaseCharacters;
    private readonly string lowercaseCharacters;
    private readonly string digitCharacters;
    private readonly string specialCharacters;
    private readonly string allowedCharacters;
    private readonly Random random = new Random();

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
    }

    public char GenerateAllowedCharacter()
    {
        return allowedCharacters.ElementAt(random.Next(allowedCharacters.Length));
    }

    public char GenerateDigitCharacter()
    {
        return digitCharacters.ElementAt(random.Next(digitCharacters.Length));
    }

    public char GenerateLowercaseCharacter()
    {
        return lowercaseCharacters.ElementAt(random.Next(lowercaseCharacters.Length));
    }

    public char GenerateSpecialCharacter()
    {
        return specialCharacters.ElementAt(random.Next(specialCharacters.Length));
    }

    public char GenerateUppercaseCharacter()
    {
        return uppercaseCharacters.ElementAt(random.Next(uppercaseCharacters.Length));
    }
}