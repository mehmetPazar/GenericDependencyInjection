using System.Reflection;

namespace RestApi.Extensions;

public static class ServiceModuleExtention
{
    public static void AddServices(this IServiceCollection services, ConfigurationManager configuration, Assembly assembly)
    {
        var interfaces = assembly.GetExportedTypes().Where(x => x.IsInterface);
        var implementationsList = assembly.GetExportedTypes().Where(x => !x.IsInterface && !x.IsAbstract);

        foreach (var @interface in interfaces)
        {
            var implementations = implementationsList.Where(x => @interface.IsAssignableFrom(x)).ToList();

            if (implementations != null)
            {
                foreach (var implementation in implementations)
                {
                    services.AddTransient(@interface, implementation);
                }
            }
        }
    }
}