using CommunityToolkit.Mvvm.ComponentModel;
using MVVMForReal.Managers;
using MVVMForReal.Models;

namespace MVVMForReal.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private readonly IDataManager _dataManger;

    public DataModel Counter { get; set; }

    public MainWindowViewModel(IDataManager dataManger)
    {
        _dataManger = dataManger;
    }
}