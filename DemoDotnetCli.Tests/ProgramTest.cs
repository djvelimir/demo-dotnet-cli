using AutoFixture.Xunit2;
using DemoDotnetCli.Processor;
using Moq;

namespace DemoDotnetCli.Tests;

public class ProgramTest
{
    [Theory, AutoMoqData]
    void StartTest(string[] args, [Frozen] IArgumentProcessor argumentProcessor, Program program)
    {
        program.Start(args);

        Mock.Get(argumentProcessor).Verify(mock => mock.Process(It.Is<string[]>(x => x.Equals(args))), Times.Once);
    }
}