using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVMForReal.Managers;

public class NavigationManager : INavigationManager
{
    public ObservableObject CurrentViewModel { get; set; }
    public event Action? CurrentViewModelChanged;

    public void OnCurrentViewModelChanged()
    {
        CurrentViewModelChanged?.Invoke();
    }
}