using CommunityToolkit.Mvvm.ComponentModel;
using MVVMForReal.Managers;
using MVVMForReal.Models;

namespace MVVMForReal.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private readonly IDataManager _dataManger;

    private readonly DataModel _dataModel;

    // MVVM-property
    private int _counter;

    public int Counter
    {
        get => _dataModel.Counter;
        set => SetProperty(
            _dataModel.Counter,
            value, _dataModel,
            (model, value) => model.Counter = value
            );
    }

    public MainWindowViewModel(IDataManager dataManger)
    {
        _dataManger = dataManger;
        _dataModel = _dataManger.DataModel;
    }
}