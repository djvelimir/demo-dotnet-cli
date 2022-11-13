using DemoDotnetCli.Validator;
using DemoDotnetCli.Generator;
using DemoDotnetCli.Display;

namespace DemoDotnetCli.Processor;

public class ArgumentProcessor : IArgumentProcessor
{
    private IArgumentValidator argumentValidator;
    private IPasswordGenerator passwordGenerator;
    private ITerminal terminal;

    public ArgumentProcessor(IArgumentValidator argumentValidator, IPasswordGenerator passwordGenerator, ITerminal terminal)
    {
        this.argumentValidator = argumentValidator;
        this.passwordGenerator = passwordGenerator;
        this.terminal = terminal;
    }

    public void Process(string[] args)
    {
        if (!argumentValidator.Validate(args))
        {
            string usage = "Usage:" + Environment.NewLine +
                    "./demo-dotnet-cli generate password";
            terminal.Show(usage);
            return;
        }

        string password = passwordGenerator.Generate();
        terminal.Show(password);
    }
}