using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System;

namespace arneselectronics;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        // Directly load the logos when the window is initialized
        this.Loaded += (_, _) =>
        {
            Console.WriteLine("Window Loaded!");
            LoadLogo();
            CartLogo1();
            Total.Text += " 1";
            AntalVarer.Text += " 1";

        };
    }

    private void LoadLogo()
    {
        try
        {
            // Find the Image control named "LogoImage"
            var logo = this.FindControl<Image>("LogoImage");

            // Load the image from the resource using the URI
            var uri = new Uri("avares://arneselectronics/Assets/testbillede1.jpg");
            var stream = AssetLoader.Open(uri);

            // Set the image source
            logo.Source = new Bitmap(stream);
        }
        catch (Exception ex)
        {
            // Log any errors
            Console.WriteLine($"Error loading image: {ex.Message}");
        }
    }

    private void CartLogo1()
    {
        try
        {
            // Find the Image control named "CartLogo"
            var logo = this.FindControl<Image>("CartLogo");

            // Load the image from the resource using the URI
            var uri2 = new Uri("avares://arneselectronics/Assets/carticon.jpg");
            var stream = AssetLoader.Open(uri2);

            // Set the image source
            logo.Source = new Bitmap(stream);
        }
        catch (Exception ex)
        {
            // Log any errors
            Console.WriteLine($"Error loading cart image: {ex.Message}");
        }
    }
}