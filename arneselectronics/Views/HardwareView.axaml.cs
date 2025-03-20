using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dapper;
using Npgsql;
using System.Linq;

namespace arneselectronics.Views;

public partial class HardwareView : UserControl
{
    public HardwareView()
    {
        InitializeComponent();
        ListInizializer listInstance = new ListInizializer();
        HardwareListView.ItemsSource = listInstance.HardwareList;
        string conString = "Host=localhost;Username=postgres;Password=Aebea2602$;Database=arneselectronics";
        
        using (var con = new NpgsqlConnection(conString))                                             
        {                                                                                             
            var data = con.Query<Products>("SELECT * FROM products").ToList();                        
            foreach (var product in data)                                                             
            {                                                                                         
                listInstance.ProductsList.Add(product);
                if (product.Type == "desktop")
                {
                    listInstance.DesktopList.Add(product);
                }
                else if (product.Type == "laptop")
                {
                    listInstance.LaptopList.Add(product);
                }
                else if (product.Type == "hardware")        
                {                                         
                    listInstance.HardwareList.Add(product); 
                }
                else if (product.Type == "accessories")        
                {                                         
                    listInstance.AccessoriesList.Add(product); 
                }                                         
            }
        } 
    }
    }
