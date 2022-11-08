namespace DemoDotnetCli.Display;

public class Terminal : ITerminal
{
    public void Show(string message)
    {
        Console.WriteLine(message);
    }
}