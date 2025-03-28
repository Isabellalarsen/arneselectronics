using CommunityToolkit.Mvvm.ComponentModel;


namespace arneselectronics.ViewModels;

public partial class ProductDetailPageViewModel : ViewModelBase
{
    [ObservableProperty]
    private Products _currentProduct;

    public ProductDetailPageViewModel()
    {
    }

    public void UpdateProduct(Products product)
    {
        _currentProduct = product;
    }
}
