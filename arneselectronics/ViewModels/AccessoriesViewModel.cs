using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using CommunityToolkit.Mvvm.Input;

namespace arneselectronics.ViewModels
{
    public partial class AccessoriesViewModel : ViewModelBase
    {
        private readonly MainViewModel _mainVm;
        
        public ObservableCollection<Products> AccessoriesList => ListInitializer.Instance.AccessoriesList;
        
        public IRelayCommand GoToProductDetailPageCommand { get; }

        public IRelayCommand TestCommand { get; }

        public AccessoriesViewModel(MainViewModel mainVm)
        {
            _mainVm = mainVm;
            TestCommand = new RelayCommand(() =>
            {
                Console.WriteLine("Test button clicked!");
            });
        }


    }
}