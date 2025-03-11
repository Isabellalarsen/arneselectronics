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
        ListInizializer listInstance = new ListInizializer();
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
       
        string conString = "Host=localhost;Username=postgres;Password=Nomoregangs_090103;Database=arne";
        
        using (var con = new NpgsqlConnection(conString))                                             
        {                                                                                             
            var data = con.Query<Products>("SELECT * FROM products").ToList();                        
            foreach (var product in data)                                                             
            {                                                                                         
                listInstance.ProductsList.Add(product);
                if (product.Type == "desktop")
                {
                    listInstance.DesktopList.Add(product);
                }
                else if (product.Type == "laptop")
                {
                    listInstance.LaptopList.Add(product);
                }
                else if (product.Type == "hardware")        
                {                                         
                    listInstance.HardwareList.Add(product); 
                }
                else if (product.Type == "accessories")        
                {                                         
                    listInstance.AccessoriesList.Add(product); 
                }                                         
            }
        } 
    }
}
    
