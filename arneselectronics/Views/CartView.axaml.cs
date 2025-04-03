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

public partial class CartView : UserControl
{
    public CartViewModel ViewModel => this.DataContext as CartViewModel;
    public CartView()
    {
        InitializeComponent();
    }
}