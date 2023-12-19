using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using MVVMForReal.Factories;

namespace MVVMForReal.Extensions;

public static class ServiceCollectionExtensions 
{
    // Generisk typ måste vara en ViewModel (ärva ObservableObject)
    // Transient skapar en ny instans varje gång den kallas

    public static void AddViewModelFactory<TViewModel>(this IServiceCollection services)
        where TViewModel : ObservableObject
    {
        services.AddTransient<TViewModel>();
        services.AddTransient<Func<TViewModel>>
        (
            sp => 
                sp.GetRequiredService<TViewModel>

            // sp => () => sp.GetService<TViewModel>
        );

        services.AddSingleton<IViewModelFactory<TViewModel>, ViewModelFactory<TViewModel>>();
    }
}
