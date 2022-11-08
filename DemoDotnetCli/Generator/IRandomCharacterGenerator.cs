namespace DemoDotnetCli.Generator;

public interface IRandomCharacterGenerator
{
    char GenerateUppercaseCharacter();

    char GenerateLowercaseCharacter();

    char GenerateDigitCharacter();

    char GenerateSpecialCharacter();

    char GenerateAllowedCharacter();
}