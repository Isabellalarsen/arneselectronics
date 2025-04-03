using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dapper;
using Npgsql;
using System.Linq;
using arneselectronics;
using arneselectronics.ViewModels;
using Avalonia.Interactivity;
using System;

namespace arneselectronics.Views;

public partial class HomePageView : UserControl
{
    public HomePageViewModel ViewModel => this.DataContext as HomePageViewModel;

    public HomePageView()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        
        var product = (sender as Button)?.DataContext as Products;
        if (product != null)
        {
            ViewModel.GoToProductDetailPageCommand.Execute(product);
        }
        else
        {
            Console.Write("Product not found");
        }

    }


}