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
        public ProductDetailPageViewModel()
        {
            GoToHomeCommand = new RelayCommand(() => _mainViewModel.GoToHome());
        }

        public ProductDetailPageViewModel(MainViewModel mainViewModel)
        {
            // Ensure that the MainViewModel is passed correctly
            _mainViewModel = mainViewModel ??
                             throw new ArgumentNullException(nameof(mainViewModel), "MainViewModel cannot be null");
            
            GoToHomeCommand = new RelayCommand(() => _mainViewModel.GoToHome());
        }

        public void UpdateProduct(Products product)
        {
            CurrentProduct = product;
        }

        public void AddToCart() 
        {
            Cartlist.Add(CurrentProduct);
            Console.WriteLine(Cartlist.Count); 
        }
        
    }
}