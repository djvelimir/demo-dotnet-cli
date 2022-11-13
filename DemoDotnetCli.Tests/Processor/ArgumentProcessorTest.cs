using AutoFixture.Xunit2;
using DemoDotnetCli.Display;
using DemoDotnetCli.Generator;
using DemoDotnetCli.Processor;
using DemoDotnetCli.Validator;
using Moq;

namespace DemoDotnetCli.Tests.Processor;

public class ArgumentProcessorTest
{
    [Theory, AutoMoqData]
    public void ProcessMethodForGeneratePasswordTest(
         [Frozen] IArgumentValidator argumentValidator,
         [Frozen] IPasswordGenerator passwordGenerator,
         [Frozen] ITerminal terminal,
         ArgumentProcessor argumentProcessor)
    {
        string[] args = new string[] { "generate", "password" };
        Mock.Get(argumentValidator).Setup(x => x.Validate(It.Is<string[]>(x => x.Equals(args)))).Returns(true);

        string sample = "A8!(,wV5YuI[Vr^>";
        Mock.Get(passwordGenerator).Setup(x => x.Generate()).Returns(sample);

        argumentProcessor.Process(args);

        Mock.Get(passwordGenerator).Verify(mock => mock.Generate(), Times.Once);
        Mock.Get(terminal).Verify(mock => mock.Show(It.Is<string>(x => x.Equals(sample))), Times.Once);
    }

    [Theory, AutoMoqData]
    public void ProcessMethodForInvalidArgumentsTest(
        string[] args,
        [Frozen] IArgumentValidator argumentValidator,
        [Frozen] ITerminal terminal,
        ArgumentProcessor argumentProcessor)
    {
        string usage = "Usage:" + Environment.NewLine +
                    "./demo-dotnet-cli generate password";

        Mock.Get(argumentValidator).Setup(x => x.Validate(It.Is<string[]>(x => x.Equals(args)))).Returns(false);

        argumentProcessor.Process(args);

        Mock.Get(terminal).Verify(mock => mock.Show(It.Is<string>(x => x.Equals(usage))), Times.Once);
    }
}