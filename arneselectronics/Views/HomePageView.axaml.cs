using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dapper;
using Npgsql;
using System.Linq;
using Avalonia.Interactivity;
using System;
using arneselectronics.ViewModels;

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
                
            // Opret PDP-siden og send produktet som parameter (hvis du har en PDPView)
            var pdpView = new ProductDetailPageView(product); // Passere produktet til ViewModel
            
        }
    }
}
