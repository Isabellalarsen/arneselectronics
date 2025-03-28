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

    private readonly HomePageViewModel homePage;
    private readonly LaptopViewModel laptopPage;
    private readonly AccessoriesViewModel accessoriesPage;
    private readonly DesktopViewModel desktopPage;
    private readonly ResourcesViewModel resourcePage;
    private readonly HardwareViewModel hardwarePage;
    private readonly CartViewModel cartPage = new CartViewModel();
    private readonly ProductDetailPageViewModel productDetailPage = new ProductDetailPageViewModel();

    
    private static MainViewModel _instance;
    public static MainViewModel Instance => _instance ??= new MainViewModel();

   
   
 private readonly LogInViewModel logInPage = new LogInViewModel();
 private readonly HelpViewModel helpPage = new HelpViewModel();


    public MainViewModel()
    {
        homePage = new HomePageViewModel(this);
        currentPage = homePage;
        accessoriesPage = new AccessoriesViewModel(this);
        desktopPage = new DesktopViewModel(this);
        hardwarePage = new HardwareViewModel(this);
        laptopPage = new LaptopViewModel(this);
    }
    [RelayCommand]
    private void GoToHome() =>  CurrentPage = homePage;

    [RelayCommand]
    private void GoToLaptop() =>  CurrentPage = laptopPage;

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
    

    [RelayCommand]
    private void GoToLogIn() => CurrentPage = logInPage;
    
    [RelayCommand]
    private void GoToHelp() => CurrentPage = helpPage;

   
}