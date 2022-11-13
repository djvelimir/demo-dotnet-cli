using DemoDotnetCli.Validator;

namespace DemoDotnetCli.Tests.Validator;

public class ArgumentValidatorTest
{
    [Theory, AutoMoqData]
    public void checkArgumentsForGeneratePassword(ArgumentValidator argumentValidator)
    {
        bool actual = argumentValidator.Validate(new String[] { "generate", "password" });

        Assert.True(actual);
    }

    [Theory, AutoMoqData]
    public void checkInvalidArguments(ArgumentValidator argumentValidator)
    {
        bool actual = argumentValidator.Validate(new String[] { });

        Assert.False(actual);
    }
}