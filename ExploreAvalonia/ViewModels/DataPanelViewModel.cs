using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace ExploreAvalonia.ViewModels;

public partial class DataPanelViewModel : ReactiveObject
{
    [Reactive] private string _entry = "";
    
    public DataPanelViewModel()
    {
    }
}