using System;
using arneselectronics.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace arneselectronics.Views;

public partial class ProductDetailPageView : UserControl
{
    public Products Product { get; set; }
    
    public ProductDetailPageView()
    {
        InitializeComponent();
        DataContext = this;
        Product = ListInitializer.Instance.ProductsList[0];
        Console.WriteLine(Product.Name);
    }
}
