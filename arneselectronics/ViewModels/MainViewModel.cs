using arneselectronics;
using arneselectronics.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using arneselectronics.Views;
using arneselectronics.ViewModels;

namespace arneselectronics.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string test_ = "Test";
    
    [ObservableProperty]
    private ViewModelBase currentPage;
    
    private readonly HomePageViewModel homePage = new HomePageViewModel();
    private readonly BærbareViewModel bærbarePage = new BærbareViewModel();
    private readonly TilbehørViewModel tilbehørPage= new TilbehørViewModel();
    private readonly StationærViewModel stationærPage = new StationærViewModel();
    private readonly VidenViewModel videnPage = new VidenViewModel();
    private readonly HardwareViewModel hardwarePage = new HardwareViewModel();
    private readonly ProductDetailPageViewModel productDetailPage = new ProductDetailPageViewModel();
    
    public MainViewModel()
    {
        CurrentPage = homePage;
    }
    [RelayCommand]
    private void GoToHome() =>  CurrentPage = homePage;
    
    [RelayCommand]
    private void GoToBærbare() =>  CurrentPage = bærbarePage;
   
    [RelayCommand]
    private void GoToTilbehør() => CurrentPage = tilbehørPage;
   
    [RelayCommand]
    private void GoToStationær() => CurrentPage = stationærPage;
 
    [RelayCommand]
    private void GoToViden() => CurrentPage = videnPage;
  
    [RelayCommand]
    private void GoToHardware() => CurrentPage = hardwarePage;
    
    [RelayCommand]
    public void GoToProductDetailPage() => CurrentPage = productDetailPage;
   
}