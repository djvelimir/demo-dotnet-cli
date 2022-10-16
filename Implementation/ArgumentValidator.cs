using demo_dotnet_cli.Interface;

namespace demo_dotnet_cli.Implementation
{
    public class ArgumentValidator : IArgumentValidator
    {
        public bool Validate(string[] args)
        {
            return args.Length != 0 && args.Length == 2 && args[0] == "generate" && args[1] == "password";
        }
    }
}