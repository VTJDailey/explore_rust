using ExploreAvalonia.ViewModels;
using Microsoft.Reactive.Testing;
using Moq;
using ReactiveUI.Testing;

namespace ExploreAvalonia.Tests.ViewModels;

public class MainWindowViewModelTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        new TestScheduler().With(s =>
        {
            var mockPanel = new Mock<IDataPanelViewModel>();
            var panelFactory = new DataPanelViewModelFactory(() => mockPanel.Object);
            var vm = new MainWindowViewModel(panelFactory);

            Assert.That(vm.Time, Is.EqualTo(""));
            
            s.AdvanceByMs(1500);
            
            Assert.That(vm.Time, Is.Not.EqualTo(""));

            
        });
    }
    
}