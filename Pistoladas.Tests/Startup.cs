using Microsoft.Extensions.DependencyInjection;
using Pistoladas.Configuration;

namespace Pistoladas.Tests
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            EnvironmentVariables.Load();
            services.RegisterDependencies();
        }
    }
}