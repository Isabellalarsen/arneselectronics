using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using System;
using Avalonia.Controls;
using Avalonia.Platform;

namespace arneselectronics;

public partial class App : Application
{

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
        this.Loaded += (_, _) =>
        {
            Console.WriteLine("Window Loaded!");
            LoadLogo();
        };
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow();
        }

        base.OnFrameworkInitializationCompleted();
    }
    private void LoadLogo()
    {
        var logoImage = this.GetControl<Image>("LogoImage");

        var uri = new Uri("avares://arneselectronics/Assets/testbillede.jpg");
        Console.WriteLine($"URI: {uri}");
    
        var bitmap = new Bitmap(AssetLoader.Open(uri));
        logoImage.Source = bitmap;
    }
}