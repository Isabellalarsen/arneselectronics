using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Avalonia.Data;

namespace arneselectronics;

public partial class MainWindow : Window
{
    public ObservableCollection<Products> ProductsList { get; set; }
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
        
        //Objects/Instance of products
         ProductsList = new ObservableCollection<Products>
        {
            new Products("Lenovo Tablet", "Den sejeste tablet", 1234567910110, 1, 699.420),
            new Products("MacBook Pro", "Apple Laptop", 1234567910111, 2, 1299.99),
            new Products("Dell XPS 15", "Powerful Windows laptop", 1234567910112, 3, 1899.99),
            new Products("Samsung Galaxy S24", "Nyeste Android smartphone", 1234567910113, 4, 1199.50),
            new Products("iPad Air", "Letvægts Apple tablet", 1234567910114, 5, 599.99),
            new Products("Sony WH-1000XM5", "Premium støjreducerende høretelefoner", 1234567910115, 6, 399.99),
            new Products("Asus ROG Strix", "Gaming laptop med RTX 4070", 1234567910116, 7, 2199.00),
            new Products("Google Pixel 8", "Stock Android med fantastisk kamera", 1234567910117, 8, 899.00),
            new Products("Apple Watch Series 9", "Smartwatch med sundhedstracking", 1234567910118, 9, 499.99),
            new Products("Logitech MX Master 3", "Trådløs præcisionsmus", 1234567910119, 10, 99.99),
            new Products("HP Spectre x360", "2-i-1 premium ultrabook", 1234567910120, 11, 1599.00),
            new Products("Razer BlackWidow V4", "Mekanisk gaming keyboard", 1234567910121, 12, 149.99),
            new Products("Corsair K100 RGB", "Hurtigt gaming tastatur med optiske switches", 1234567910122, 13, 229.99),
            new Products("Samsung 980 Pro SSD", "1TB NVMe SSD med høj hastighed", 1234567910123, 14, 129.99),
            new Products("Apple AirPods Pro 2", "Trådløse høretelefoner med ANC", 1234567910124, 15, 249.99),
            new Products("LG C3 OLED TV", "55-tommer 4K OLED-skærm", 1234567910125, 16, 1799.99),
            new Products("GoPro Hero 12", "Actionkamera til ekstreme oplevelser", 1234567910126, 17, 499.00),
            new Products("Sony Alpha A7 IV", "Professionelt spejlløst kamera", 1234567910127, 18, 2499.99),
            new Products("Bose QuietComfort Ultra", "Komfortable støjreducerende høretelefoner", 1234567910128, 19, 349.99),
            new Products("Microsoft Surface Pro 9", "Hybrid mellem laptop og tablet", 1234567910129, 20, 1399.99),
            new Products("Samsung Galaxy Watch 6", "Smartwatch med avanceret sundhedstracking", 1234567910130, 21, 299.99),
            new Products("Elgato Stream Deck", "Kontrolpanel til streamere", 1234567910131, 22, 149.99),
            new Products("NZXT Kraken Z73", "AIO vandkøling med LCD-display", 1234567910132, 23, 249.99),
            new Products("Nvidia RTX 4090", "Kraftfuldt grafikkort til gaming og AI", 1234567910133, 24, 1599.00)
        };
        foreach (Products product in ProductsList)
        {
            product.Display("FrontPage");
        }
        
        Console.WriteLine($"Antal produkter: {ProductsList.Count}");
       
        

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