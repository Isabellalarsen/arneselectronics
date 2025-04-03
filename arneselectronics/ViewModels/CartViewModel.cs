using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using CommunityToolkit.Mvvm.Input;

namespace arneselectronics.ViewModels
{

public partial class CartViewModel : ViewModelBase
{
    private readonly MainViewModel _mainVm;
    public IRelayCommand GoToHomeCommand { get; }

    public CartViewModel(MainViewModel mainVm)
    {
        _mainVm = mainVm;
        GoToHomeCommand = new RelayCommand(() => _mainVm.GoToHome());
    }
}
}