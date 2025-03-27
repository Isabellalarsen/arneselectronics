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
    public AccessoriesView()
    {
        InitializeComponent();
        this.DataContext = new AccessoriesViewModel(new MainViewModel());
        Console.WriteLine($"DataContext {DataContext.GetType()}");
    }
}
