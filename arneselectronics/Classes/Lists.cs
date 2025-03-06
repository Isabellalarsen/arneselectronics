using System.Collections.ObjectModel;

namespace arneselectronics;

public class Lists
{
    // Created new ObservableCollection of the type Products, added a get property to get collection content and instantiated the collection
    public ObservableCollection<Products> ProductsList { get; } = new ObservableCollection<Products>
    {
            new Products("Lenovo Tablet", "Den sejeste tablet", 1234567910110, 1, 699.420 , "avares://arneselectronics/Assets/lenovoTablet.jpg"),
            new Products("Dell XPS 15", "Powerful Windows laptop", 1234567910112, 3, 1899.99 , "avares://arneselectronics/Assets/dellXPS.jpg"),
            new Products("Samsung Galaxy S24", "Nyeste Android smartphone", 1234567910113, 4, 1199.50 , "avares://arneselectronics/Assets/Samsung Galaxy S24.jpg"),
            new Products("iPad Air", "Letvægts Apple tablet", 1234567910114, 5, 599.99 , "avares://arneselectronics/Assets/iPadAir.jpg"),
            new Products("Asus ROG Strix", "Gaming laptop med RTX 4070", 1234567910116, 7, 2199.00 , "avares://arneselectronics/Assets/asus-rog-strix.jpg"),
            new Products("Google Pixel 8", "Stock Android med fantastisk kamera", 1234567910117, 8, 899.00 , "avares://arneselectronics/Assets/googlePixel.jpg"),
            new Products("Apple Watch Series 9", "Smartwatch med sundhedstracking", 1234567910118, 9, 499.99 , "avares://arneselectronics/Assets/appleWatch.jpg"),
            new Products("HP Spectre x360", "2-i-1 premium ultrabook", 1234567910120, 11, 1599.00 , "avares://arneselectronics/Assets/hpSpectre.jpg"),
            new Products("Samsung 980 Pro SSD", "1TB NVMe SSD med høj hastighed", 1234567910123, 14, 129.99 , "avares://arneselectronics/Assets/980SDD.jpg"),
            new Products("LG C3 OLED TV", "55-tommer 4K OLED-skærm", 1234567910125, 16, 1799.99 , "avares://arneselectronics/Assets/lgC3.jpg"),
            new Products("GoPro Hero 12", "Actionkamera til ekstreme oplevelser", 1234567910126, 17, 499.00 , "avares://arneselectronics/Assets/hero12.jpg"),
            new Products("Sony Alpha A7 IV", "Professionelt spejlløst kamera", 1234567910127, 18, 2499.99 , "avares://arneselectronics/Assets/sonyAlphaA7IV.jpg"),
            new Products("Microsoft Surface Pro 9", "Hybrid mellem laptop og tablet", 1234567910129, 20, 1399.99 , "avares://arneselectronics/Assets/surfacePro9.jpg")
    };
    
    public ObservableCollection<Products> DesktopList { get; } = new ObservableCollection<Products>
    {
        new Products("Old Pc", "Gammel gamer, med masser af liv", 78612378618638, 33, 599, "avares://arneselectronics/Assets/oldPC.jpg"),
        new Products( "Andreas Desktop", "Mega sej desktop med græsk tema", 1233423435423, 21, 800, "avares://arneselectronics/Assets/PC.jpg"),
    };

    public ObservableCollection<Products> LaptopList { get; } = new ObservableCollection<Products>
    {
        new Products("Dell XPS 15", "Powerful Windows laptop", 1234567910112, 3, 1899.99 , "avares://arneselectronics/Assets/dellXPS.jpg"),
        new Products("Asus ROG Strix", "Gaming laptop med RTX 4070", 1234567910116, 7, 2199.00 , "avares://arneselectronics/Assets/asus-rog-strix.jpg"),
        new Products("HP Spectre x360", "2-i-1 premium ultrabook", 1234567910120, 11, 1599.00 , "avares://arneselectronics/Assets/hpSpectre.jpg"),

    };

    public ObservableCollection<Products> HardwareList { get; } = new ObservableCollection<Products>
    {
        new Products("Samsung 980 Pro SSD", "1TB NVMe SSD med høj hastighed", 1234567910123, 14, 129.99 , "avares://arneselectronics/Assets/980SDD.jpg"),

    };

    public ObservableCollection<Products> AccessoriesList { get; } = new ObservableCollection<Products>
    {
        new Products("Corsair K100 RGB", "Hurtigt gaming tastatur med optiske switches", 1234567910122, 13, 229.99 , "avares://arneselectronics/Assets/k100.jpg"),
        new Products("Razer BlackWidow V4", "Mekanisk gaming keyboard", 1234567910121, 12, 149.99 , "avares://arneselectronics/Assets/blackWidow.jpg"),
        new Products("Logitech MX Master 3", "Trådløs præcisionsmus", 1234567910119, 10, 99.99 , "avares://arneselectronics/Assets/mxMaster.jpg"),
        new Products("Sony WH-1000XM5", "Premium støjreducerende høretelefoner", 1234567910115, 6, 399.99 , "avares://arneselectronics/Assets/sonyXM5.jpg"),
        new Products("Apple AirPods Pro 2", "Trådløse høretelefoner med ANC", 1234567910124, 15, 249.99 , "avares://arneselectronics/Assets/airpodsPro.jpg"),

    };


}