using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace arneselectronics
{
    public partial class MainWindow : Window
    {
        private TextBlock? _total;
        private TextBlock? _quantity;
        private Button? _addToBasketButton;

        public MainWindow()
        {
            InitializeComponent();  

            this.Loaded += OnWindowLoaded;
        }

        private void OnWindowLoaded(object? sender, EventArgs e)
        {
            Console.WriteLine("Window Loaded!");

            // Ensure UI elements exist before using them
            _total = this.FindControl<TextBlock>("Total");
            _quantity = this.FindControl<TextBlock>("Quantity");
            _addToBasketButton = this.FindControl<Button>("AddToBasketButton");

            if (_addToBasketButton != null)
            {
                var basketButton = new BasketButton(_total, _quantity);
                _addToBasketButton.Click += basketButton.HandleButtonClick;
            }

            // Load images
            var imageHandler = new ImageHandler();
            imageHandler.LoadImage(this, "LogoImage", "avares://arneselectronics/Assets/testbillede1.jpg");
            imageHandler.LoadImage(this, "CartLogo", "avares://arneselectronics/Assets/carticon.jpg");
        }
    }
}