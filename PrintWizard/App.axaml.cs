using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PrintWizard.ViewModels;
using PrintWizard.Views;

namespace PrintWizard;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        var collection = new ServiceCollection();

        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        collection.AddSingleton<IConfiguration>(config);
        collection.AddSingleton<SNMPViewModel>();
        collection.AddSingleton<IPPViewModel>();
        collection.AddSingleton<MainWindowsViewModel>();

        var services = collection.BuildServiceProvider();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = services.GetRequiredService<MainWindowsViewModel>()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
