using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System;

namespace arneselectronics;

public class ImageHandler : Window
{
    private string controlName;
    private string imageUri;
    
    public void LoadImage(string controlName, string imageUri)
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