using System.Reactive.Linq;
using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace ExploreAvalonia.ViewModels;

public delegate IDataPanelViewModel DataPanelViewModelFactory();
public interface IDataPanelViewModel : IReactiveObject
{
    
}

public partial class DataPanelViewModel : ReactiveObject, IDataPanelViewModel
{
    
    [Reactive] private string _entry = "";
    [ObservableAsProperty] private string _output = "";
    public DataPanelViewModel()
    {
        _outputHelper =
            this.WhenAnyValue(vm => vm.Entry)
                .Select(s => $".... {(s.Length <= 10 ? s : s[0..10])}")
                .ToProperty(this, vm => vm.Output)
            ;
    }
}