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

public partial class LaptopView : UserControl
{
    public LaptopViewModel ViewModel => this.DataContext as LaptopViewModel;

    public LaptopView()
    {
        InitializeComponent();
        this.DataContext = new LaptopViewModel(new MainViewModel());
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        if (ViewModel != null)
        {
            // Sørg for at produktet er korrekt bundet og tilgængeligt
            var product = (sender as Button)?.DataContext as Products;
            if (product != null)
            {
                ViewModel.GoToProductDetailPageCommand.Execute(product);  // Kald kommandoen med produktet
            }
        }
        else
        {
            // Fejlmeddelelse, hvis ViewModel er null
            Console.WriteLine("ViewModel is null");
        }
    }


}