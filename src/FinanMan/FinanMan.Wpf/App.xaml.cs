using FinanMan.BlazorUi.Extensions;
using FinanMan.BlazorUi.State;
using FinanMan.Shared.Extensions;
using FinanMan.Shared.StateInterfaces;
using FinanMan.SharedClient.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Windows;

namespace FinanMan.Wpf;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public IServiceProvider Services { get; }

    public App()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddWpfBlazorWebView();
#if DEBUG
        serviceCollection.AddBlazorWebViewDeveloperTools();
#endif

        var baseAddress = "https://localhost:7176";

#if !DEBUG 
        // TODO: Overwrite the baseAddress with the address of the server
#endif

        serviceCollection.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) });

        serviceCollection.AddFinanManLocalization();
        serviceCollection.AddStateManagement();
        serviceCollection.AddClientServices();

        Services = serviceCollection.BuildServiceProvider();
        Resources.Add("services", Services);
    }
}
