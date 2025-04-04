using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using arneselectronics;
using arneselectronics.ViewModels;

namespace arneselectronics.Views
{

    public partial class ProductDetailPageView : UserControl
    {
        public ProductDetailPageViewModel viewModel => this.DataContext as ProductDetailPageViewModel;

        public ProductDetailPageView()
        {
            InitializeComponent();
        }
        
        private void AddToCartButton(object? sender, RoutedEventArgs e)
        {
            viewModel.AddToCart();
        }
    }
}