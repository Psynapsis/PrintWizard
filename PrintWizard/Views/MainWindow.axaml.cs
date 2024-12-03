using Avalonia.Controls;
using PrintWizard.ViewModels;

namespace PrintWizard.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Binding(object? sender, FluentAvalonia.UI.Controls.NavigationViewSelectionChangedEventArgs e)
    {
    }
}
