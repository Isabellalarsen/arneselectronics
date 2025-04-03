using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using CommunityToolkit.Mvvm.Input;

namespace arneselectronics.ViewModels
{

public partial class CartViewModel : ViewModelBase
{
    private readonly MainViewModel _mainVm;
    [ObservableProperty] private double? totalPrice;
    public ObservableCollection<Products> HardwareList => ListInitializer.Instance.HardwareList;
    
    public ObservableCollection<Products> CartList => ListInitializer.Instance.CartList;
    public IRelayCommand GoToHomeCommand { get; }

    public CartViewModel(MainViewModel mainVm)
    {
        _mainVm = mainVm;
        totalPrice = _mainVm.Total;
        GoToHomeCommand = new RelayCommand(() => _mainVm.GoToHome());
    }

 
}
}