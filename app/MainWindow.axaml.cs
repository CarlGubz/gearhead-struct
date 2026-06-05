using Avalonia.Controls;
using System.Diagnostics;

namespace PrePoMaxLauncher;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var prepomaxBtn =
            this.FindControl<Button>("LaunchPrePoMaxButton");

        var calculixBtn =
            this.FindControl<Button>("LaunchCalculixButton");

        prepomaxBtn.Click += LaunchPrePoMax;
        calculixBtn.Click += LaunchCalculix;
    }

    private void LaunchPrePoMax(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = @"C:\PrePoMax\PrePoMax.exe",
            UseShellExecute = true
        });
    }

    private void LaunchCalculix(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = @"C:\Calculix\ccx.exe",
            UseShellExecute = true
        });
    }
}