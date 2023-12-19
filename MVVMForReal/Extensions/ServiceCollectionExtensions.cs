using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;

namespace MVVMForReal.Extensions;

public static class ServiceCollectionExtensions 
{
    // Generisk typ måste vara en ViewModel (ärva ObservableObject)
    public static void AddViewModelFactory<TViewModel>(this IServiceCollection services)
        where TViewModel : ObservableObject
    {

    }
}
