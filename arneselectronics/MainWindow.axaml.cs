using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace arneselectronics;

public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();  // Initialize the window's components (controls defined in XAML)

        // Find the UI elements (Total and Quantity) from the XAML
        Total = this.FindControl<TextBlock>("Total");
        Quantity = this.FindControl<TextBlock>("Quantity");

        // Set up an event handler to be triggered when the window is loaded
        this.Loaded += (_, _) =>
        {
            // Log to the console when the window is loaded successfully
            Console.WriteLine("Window Loaded!");

            // Initialize BasketButton and pass the UI elements
            var basketButton = new BasketButton(Total, Quantity);
            // Optionally, attach event handler if needed
            var addButton = this.FindControl<Button>("AddToBasketButton");
            addButton.Click += basketButton.HandleButtonClick;

            // Optionally, initialize and use ImageHandler to load images
            var imageHandler = new ImageHandler();
            imageHandler.LoadImage(this, "LogoImage", "avares://arneselectronics/Assets/testbillede1.jpg");
            imageHandler.LoadImage(this, "CartLogo", "avares://arneselectronics/Assets/carticon.jpg");
        };
    }
}