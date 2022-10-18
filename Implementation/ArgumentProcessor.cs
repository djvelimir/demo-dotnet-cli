using demo_dotnet_cli.Interface;

namespace demo_dotnet_cli.Implementation
{
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

        public void Process(String[] args)
        {
            if (!argumentValidator.Validate(args))
            {
                String usage = "Usage:" + Environment.NewLine +
                        "./demo-dotnet-cli generate password";
                terminal.Show(usage);
                return;
            }

            String password = passwordGenerator.Generate();
            terminal.Show(password);
        }
    }
}