using System;
using arneselectronics;  // Importer Products-klassen
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace arneselectronics.Views
{
    public partial class ProductDetailPageView : UserControl
    {
        public Products Product { get; set; }

        public ProductDetailPageView(Products product)
        {
            InitializeComponent();
            Product = product;
            TextBlockName.Text = Product.Name;
            TextBlockPrice.Text = Product.Price.ToString();
            Image.Source = Product.ProductImage;
            DataContext = Product; 

            Console.WriteLine(Product.Name);
        }


    }
}