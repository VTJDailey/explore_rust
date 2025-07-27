using Microsoft.Extensions.DependencyInjection;

namespace ExploreAvalonia.ViewModels;

public static class Registration
{
    public static void Register(IServiceCollection services)
    {
        services.AddSingleton<IMainWindowViewModel>(s => new MainWindowViewModel(
            s.GetRequiredService<DataPanelViewModelFactory>(
                )));
        services.AddTransient<DataPanelViewModelFactory>(s => new DataPanelViewModelFactory(
            () => new DataPanelViewModel(
                )));
    }
}