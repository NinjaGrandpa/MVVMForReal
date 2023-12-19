namespace MVVMForReal.Factories;

public interface IViewModelFactory<out TViewModel> where TViewModel : class
{
    TViewModel Create();
}
