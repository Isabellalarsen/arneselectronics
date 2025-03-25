using Avalonia.Controls;
using arneselectronics;


namespace arneselectronics.ViewModels;

public class ProductDetailPageViewModel : ViewModelBase
{
    public Products Product { get; set; }
     

    public ProductDetailPageViewModel()
    {
        Product = new Products(
            "12345", "SuperSmartphone X1", "SuperTech", "9876543210987", 799.99, "Smartphone", "avares://arneselectronics/Assets/980SDD.jpg", "En topmoderne smartphone med fantastisk kamera og høj ydeevne."
        );
    }
}
