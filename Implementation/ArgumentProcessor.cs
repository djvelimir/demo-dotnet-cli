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

            switch (args[0])
            {
                default:
                case "generate":
                    switch (args[1])
                    {
                        default:
                        case "password":
                            String password = passwordGenerator.Generate();
                            terminal.Show(password);
                            break;
                    }
                    break;
            }
        }
    }
}