using demo_dotnet_cli.Interface;

namespace demo_dotnet_cli.Implementation
{
    public class Terminal : ITerminal
    {
        public void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}