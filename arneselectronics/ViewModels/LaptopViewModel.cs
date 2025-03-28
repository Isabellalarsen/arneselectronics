using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using CommunityToolkit.Mvvm.Input;

namespace arneselectronics.ViewModels
{
    public partial class LaptopViewModel : ViewModelBase
    {
        private readonly MainViewModel _mainVm;
        
        public ObservableCollection<Products> LaptopList => ListInitializer.Instance.LaptopList;
        
        public IRelayCommand<Products> GoToProductDetailPageCommand { get; }

        public LaptopViewModel(MainViewModel mainVm)
        {
            _mainVm = mainVm;
            GoToProductDetailPageCommand = new RelayCommand<Products>(product =>
            {
                if (product != null)
                {
                    _mainVm.GoToProductDetailPage(product); // Gå til produktdetaljesiden med produktet
                }
            });
        }
    }
}