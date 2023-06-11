using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Romak.Commons.Contracts;

public interface IStartup : IModule
{
    /// <summary>
    /// Adding new service to IoC
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/> The IoC of contain new service</param>
    /// <param name="configuration"><see cref="IConfiguration"/> The configuration file base of module name</param>
    void ConfigurationService(IServiceCollection services, IConfiguration configuration);
}