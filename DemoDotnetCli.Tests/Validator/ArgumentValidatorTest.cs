using DemoDotnetCli.Validator;

namespace DemoDotnetCli.Tests.Validator;

public class ArgumentValidatorTest
{
    [Theory, AutoMoqData]
    public void checkArgumentsForGeneratePassword(ArgumentValidator argumentValidator)
    {
        bool actual = argumentValidator.Validate(new string[] { "generate", "password" });

        Assert.True(actual);
    }

    [Theory, AutoMoqData]
    public void checkInvalidArguments(ArgumentValidator argumentValidator)
    {
        bool actual = argumentValidator.Validate(new string[] { });

        Assert.False(actual);
    }
}