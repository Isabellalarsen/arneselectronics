using System.Collections.ObjectModel;

namespace arneselectronics;

public class ListInizializer
{
    
    // Created new ObservableCollection of the type Products, added a get property to get collection content and instantiated the collection
    // Lists are empty until filled by database when program is run
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
