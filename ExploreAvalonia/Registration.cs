using Microsoft.Extensions.DependencyInjection;

namespace ExploreAvalonia;

public static class Registration
{
    public static void Register(IServiceCollection services)
    {
        ViewModels.Registration.Register(services);
    }
}