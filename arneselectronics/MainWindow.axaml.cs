using Avalonia.Controls;
using System;
using Avalonia.Data;

namespace arneselectronics;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();  // Initialize the window's components (controls defined in XAML)
        
        //Objects/Instance of products
        Products product1 = new Products("Lenovo Tablet", "Den sejeste tablet", 1234567910110, 1, 699.420);
        Products product2 = new Products("MacBook Pro", "Apple Laptop", 1234567910111, 1, 1299.99);
        Product1NameTextBlock.DataContext = product1;
        Product2NameTextBlock.DataContext = product2;
       // ProductNameTextBlock.Bind(TextBlock.TextProperty, new Binding("productName"));
        

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