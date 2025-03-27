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

public partial class AccessoriesView : UserControl
{
    public AccessoriesViewModel ViewModel => this.DataContext as AccessoriesViewModel;

    public AccessoriesView()
    {
        InitializeComponent();
        this.DataContext = new AccessoriesViewModel(new MainViewModel());
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
