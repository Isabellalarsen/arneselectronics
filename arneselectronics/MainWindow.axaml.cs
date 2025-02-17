using Avalonia.Controls;
using System;

namespace arneselectronics;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();  // Initialize the window's components (controls defined in XAML)

        // Create an instance of the ImageHandler class to handle loading images
        var imageHandler = new ImageHandler();

        // Set up an event handler to be triggered when the window is loaded
        this.Loaded += (_, _) =>
        {
            // Log to the console when the window is loaded successfully
            Console.WriteLine("Window Loaded!");
            
            // Update the Total and Quantity labels to show the default values (1)
            Total.Text = "Total: 1";  // Set the 'Total' label to show "Total: 1"
            Quantity.Text = "Quantity: 1";  // Set the 'Quantity' label to show "Quantity: 1"

            // Use the ImageHandler to load images into the Image controls
            // Load the logo image for the "LogoImage" control
            imageHandler.LoadImage(this, "LogoImage", "avares://arneselectronics/Assets/testbillede1.jpg");

            // Load the cart icon for the "CartLogo" control
            imageHandler.LoadImage(this, "CartLogo", "avares://arneselectronics/Assets/carticon.jpg");
        };
    }
}