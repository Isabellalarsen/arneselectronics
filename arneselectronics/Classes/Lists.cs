using System.Collections.ObjectModel;

namespace arneselectronics;

public class Lists
{
    // Created new ObservableCollection of the type Products, added a get property to get collection content and instantiated the collection
    public ObservableCollection<Products> ProductsList { get; } = new ObservableCollection<Products>
    {
    };
    
    public ObservableCollection<Products> DesktopList { get; } = new ObservableCollection<Products> 
    {
    };

    public ObservableCollection<Products> LaptopList { get; } = new ObservableCollection<Products>
    {
    };

    public ObservableCollection<Products> HardwareList { get; } = new ObservableCollection<Products>
    {
    };

    public ObservableCollection<Products> AccessoriesList { get; } = new ObservableCollection<Products>
    {
    };
    
    
    
}
