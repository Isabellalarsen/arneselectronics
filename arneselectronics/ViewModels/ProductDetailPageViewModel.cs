using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;

namespace arneselectronics.ViewModels
{
    public partial class ProductDetailPageViewModel : ViewModelBase
    {
        private readonly MainViewModel _mainViewModel; // Reference to MainViewModel

        [ObservableProperty] private Products? _currentProduct;
        public ObservableCollection<Products> Cartlist => ListInitializer.Instance.CartList;
        public IRelayCommand GoToHomeCommand { get; }
        public ProductDetailPageViewModel(MainViewModel mainViewModel)
        {
            GoToHomeCommand = new RelayCommand(() => _mainViewModel.GoToHome());
            _mainViewModel = mainViewModel;

        }

        public void UpdateProduct(Products product)
        {
            CurrentProduct = product;
        }

        public void AddToCart() 
        {
            Cartlist.Add(CurrentProduct);
            _mainViewModel.Total += CurrentProduct.Price;
            _mainViewModel.ProductCounter++;
        }
        
    }
}