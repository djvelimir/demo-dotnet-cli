using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using DemoDotnetCli.Processor;
using DemoDotnetCli.Validator;
using DemoDotnetCli.Generator;
using DemoDotnetCli.Display;

namespace DemoDotnetCli
{
    class Program : IProgram
    {
        static void Main(string[] args)
        {
            Host.CreateDefaultBuilder()
                .ConfigureServices(ConfigureServices)
                .ConfigureServices(services => services.AddSingleton<Program>())
                .Build()
                .Services
                .GetService<Program>()
                ?.Start(args);
        }

        private static void ConfigureServices(HostBuilderContext hostContext, IServiceCollection services)
        {
            services.AddSingleton<IArgumentProcessor, ArgumentProcessor>();
            services.AddSingleton<IArgumentValidator, ArgumentValidator>();
            services.AddSingleton<IPasswordGenerator, PasswordGenerator>();
            services.AddSingleton<ITerminal, Terminal>();
        }

        private IArgumentProcessor argumentProcessor;

        public Program(IArgumentProcessor argumentProcessor)
        {
            this.argumentProcessor = argumentProcessor;
        }

        public void Start(string[] args)
        {
            this.argumentProcessor.Process(args);
        }
    }
}