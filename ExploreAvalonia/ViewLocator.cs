using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using ExploreAvalonia.ViewModels;
using ExploreAvalonia.Views;
using ReactiveUI;

namespace ExploreAvalonia;

public class ViewLocator : IDataTemplate
{

    public Control? Build(object? param)
    {
        if (param is null)
            return null;
        
        if (param is MainWindowViewModel) return new MainWindow();
        if (param is DataPanelViewModel) return new DataPanelView();
        
        var name = param.GetType().FullName!;
        return new TextBlock { Text = $"Not Found: {name}"};
    }

    public bool Match(object? data)
    {
        return data is ReactiveObject;
    }
}
