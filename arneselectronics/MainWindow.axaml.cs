using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System;
using Avalonia.Data;

namespace arneselectronics;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        //Objects/Instance of products
        Products product1 = new Products("Lenovo Tablet", "Den sejeste tablet", 1234567910110, 1, 699.420);
        Products product2 = new Products("MacBook Pro", "Apple Laptop", 1234567910111, 1, 1299.99);
        Product1NameTextBlock.Text = product1.Display("FrontPage1");
        
        Product2NameTextBlock.DataContext = product2;
       // ProductNameTextBlock.Bind(TextBlock.TextProperty, new Binding("productName"));
        

        // Directly load the logos when the window is initialized
        this.Loaded += (_, _) =>
        {
            Console.WriteLine("Window Loaded!");
            //Insert methods here instead to update cart counter and total Counter
            Total.Text += " 1";
            Quantity.Text += " 1";
            var ImageHandler = new ImageHandler();
            ImageHandler.LoadImage( this,"LogoImage", "avares://arneselectronics/Assets/testbillede1.jpg");
            ImageHandler.LoadImage( this, "CartLogo", "avares://arneselectronics/Assets/carticon.jpg");
            
        };
    }

}