using Avalonia.Controls;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Collections;
using Dapper;
using Npgsql;


namespace arneselectronics;

public class ListInitializer
{
    public static ListInitializer Instance { get; } = new ListInitializer();

    public ObservableCollection<Products> ProductsList { get; } = new();
    public ObservableCollection<Products> DesktopList { get; } = new();
    public ObservableCollection<Products> LaptopList { get; } = new();
    public ObservableCollection<Products> HardwareList { get; } = new();
    public ObservableCollection<Products> AccessoriesList { get; } = new();

    private ListInitializer() { }

    public void LoadProductsFromDatabase()
    {
        string conString = "Host=localhost;Username=postgres;Password=2231Niklas;Database=arne";

        using (var con = new NpgsqlConnection(conString))
        {
            var data = con.Query<Products>("SELECT * FROM products").ToList();
            foreach (var product in data)
            {
                ProductsList.Add(product);
                if (product.Type == "desktop") DesktopList.Add(product);
                else if (product.Type == "laptop") LaptopList.Add(product);
                else if (product.Type == "hardware") HardwareList.Add(product);
                else if (product.Type == "accessories") AccessoriesList.Add(product);
            }
        }
    }
}

