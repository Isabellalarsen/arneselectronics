using Avalonia.Controls;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Collections;
using Dapper;
using Npgsql;

namespace arneselectronics;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
        
        //Instantiate lists to access from desktop from instance 
        Lists listInstance = new Lists();
        //Links listInstance with ItemSource
        ProductsListView.ItemsSource = listInstance.ProductsList;
        DesktopListView.ItemsSource = listInstance.DesktopList;
        LaptopListView.ItemsSource = listInstance.LaptopList;
        HardwareListView.ItemsSource = listInstance.HardwareList;
        AccessoriesListView.ItemsSource = listInstance.AccessoriesList;
        
        // Directly load the logos when the window is initialized
        this.Loaded += (_, _) =>
        {
            // Remember to add Resources to Avalonia 
            var ImageHandler = new ImageHandler();
            Console.WriteLine("Window Loaded!");

            //Insert methods here instead to update cart counter and total Counter
            Total.Text += " 1";
            Quantity.Text += " 1";
            ImageHandler.LoadImage(this, "LogoImage", "avares://arneselectronics/Assets/testbillede1.jpg");
            ImageHandler.LoadImage(this, "CartLogo", "avares://arneselectronics/Assets/carticon.jpg");
        };
    }
}
    
