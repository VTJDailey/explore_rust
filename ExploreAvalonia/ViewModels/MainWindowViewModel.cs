using System;
using System.Diagnostics;
using System.Reactive.Linq;
using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace ExploreAvalonia.ViewModels;

public interface IMainWindowViewModel : IReactiveObject
{
    
}

public partial class MainWindowViewModel : ReactiveObject, IMainWindowViewModel
{
    public string Greeting { get; } = "Welcome to Avalonia!";

    public IDataPanelViewModel ChildPanel { get; }
    public int Num { get; } = 234;
    
    [ObservableAsProperty]
    private string _time = "";
    
    public MainWindowViewModel(DataPanelViewModelFactory panelFactory)
    {
        Debug.WriteLine("Test Startup");
        ChildPanel = panelFactory();
        _timeHelper =
            Observable.Timer(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1),
                    RxApp.TaskpoolScheduler)
                .Select(_ => DateTime.Now.ToLongTimeString())
                .ObserveOn(RxApp.MainThreadScheduler)
                .ToProperty(this, vm => vm.Time);
    }
}
