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

            Total.Text += " 1";
            AntalVarer.Text += " 1";


            LoadImage("LogoImage", "avares://arneselectronics/Assets/testbillede1.jpg");
            LoadImage("CartLogo", "avares://arneselectronics/Assets/carticon.jpg");
            
        };
    }

    private void LoadImage(string controlName, string imageUri)
    {
        try
        {
            // Find the Image control by name
            var imageControl = this.FindControl<Image>(controlName);

            // Load the image from the resource using the URI
            var uri = new Uri(imageUri);
            var stream = AssetLoader.Open(uri);

            // Set the image source
            imageControl.Source = new Bitmap(stream);
        }
        catch (Exception ex)
        {
            // Log any errors
            Console.WriteLine($"Error loading image for {controlName}: {ex.Message}");
        }
    }
}