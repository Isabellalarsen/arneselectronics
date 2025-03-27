using System;
using System.Collections.Generic;
using arneselectronics.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using arneselectronics;

namespace arneselectronics.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string test_ = "Test";

    [ObservableProperty]
    private ViewModelBase currentPage;

    private readonly HomePageViewModel homePage = new HomePageViewModel();
    private readonly LaptopViewModel _laptopPage = new LaptopViewModel();
    private readonly AccessoriesViewModel accessoriesPage;
    private readonly DesktopViewModel desktopPage = new DesktopViewModel();
    private readonly ResourcesViewModel resourcePage = new ResourcesViewModel();
    private readonly HardwareViewModel hardwarePage = new HardwareViewModel();
    private readonly CartViewModel cartPage = new CartViewModel();
    private readonly ProductDetailPageViewModel productDetailPage = new ProductDetailPageViewModel();
    public ObservableCollection<Products> AccessoriesList => ListInitializer.Instance.AccessoriesList;
    public Products Products { get; set; }
    
    private static MainViewModel _instance;
    public static MainViewModel Instance => _instance ??= new MainViewModel();

    public MainViewModel()
    {
        currentPage = homePage;
        accessoriesPage = new AccessoriesViewModel(this);
    }
    [RelayCommand]
    private void GoToHome() =>  CurrentPage = homePage;

    [RelayCommand]
    private void GoToLaptop() =>  CurrentPage = _laptopPage;

    [RelayCommand]
    private void GoToAccessories() => CurrentPage = accessoriesPage;

    [RelayCommand]
    private void GoToDesktop() => CurrentPage = desktopPage;
 
    [RelayCommand]
    private void GoToResource() => CurrentPage = resourcePage;

    [RelayCommand]
    private void GoToHardware() => CurrentPage = hardwarePage;

    [RelayCommand]
    private void GoToCart() => CurrentPage = cartPage;

    [RelayCommand]
    public void GoToProductDetailPage(Products product)
    {
        productDetailPage.UpdateProduct(product);
        CurrentPage = productDetailPage;
    }
    

   
}