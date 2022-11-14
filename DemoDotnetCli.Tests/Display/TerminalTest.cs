using DemoDotnetCli.Display;

namespace DemoDotnetCli.Tests.Display;

public class TerminalTest
{
    [Theory, AutoMoqData]
    public void ShowTest(string message, Terminal terminal)
    {
        string expected = message + Environment.NewLine;

        StringWriter stringWriter = new StringWriter();
        TextWriter consoleOut = Console.Out;

        Console.SetOut(stringWriter);
        terminal.Show(message);
        Console.SetOut(consoleOut);

        string actual = stringWriter.ToString();

        Assert.Equal(expected, actual);
    }
}