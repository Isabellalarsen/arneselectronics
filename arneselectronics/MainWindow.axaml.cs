using Avalonia.Controls;
using Avalonia.Media.Imaging;
using System;

namespace arneselectronics
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            try
            {
                var logo = this.FindControl<Image>("logo");
                logo.Source = new Bitmap("arneselectronics/pictures/testbillede1.jpg");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fejl ved indlæsning af billede: {ex.Message}");
            }
        }
    }
}