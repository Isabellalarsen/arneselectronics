using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dapper;
using Npgsql;
using System.Linq;
using Avalonia.Interactivity;
using System;
using System.Collections.Generic;
using arneselectronics.ViewModels;
using Avalonia.Input;
using arneselectronics;

namespace arneselectronics.Views;

public partial class HomePageView : UserControl
{
    MainViewModel ViewModel;

    public HomePageView()
    {
        InitializeComponent();
        ListInitializer listInstance = ListInitializer.Instance;
        ProductsListView.ItemsSource = listInstance.ProductsList;
    }

    private void Button_OnClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        // Hent produktet fra CommandParameter
        var button = sender as Button;
        var product = button?.CommandParameter as Products;

        if (product != null)
        {
            // Du kan nu bruge produktet, f.eks. ved at oprette PDP
            Console.WriteLine($"Produktnavn: {product.Name}");
            
        }
    }
}
