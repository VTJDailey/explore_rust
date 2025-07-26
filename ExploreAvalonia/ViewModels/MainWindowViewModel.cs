using System;
using System.Diagnostics;
using System.Reactive.Linq;
using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace ExploreAvalonia.ViewModels;

public partial class MainWindowViewModel : ReactiveObject
{
    public string Greeting { get; } = "Welcome to Avalonia!";

    public DataPanelViewModel ChildPanel { get; } = new DataPanelViewModel();
    public int Num { get; } = 234;
    
    [ObservableAsProperty]
    private string _time = "";
    
    public MainWindowViewModel()
    {
        Debug.WriteLine("Test Startup");
        _timeHelper =
            Observable.Timer(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1),
                    RxApp.TaskpoolScheduler)
                .Select(_ => DateTime.Now.ToLongTimeString())
                .ObserveOn(RxApp.MainThreadScheduler)
                .ToProperty(this, vm => vm.Time);
    }
}
