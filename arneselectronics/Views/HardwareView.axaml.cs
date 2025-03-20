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
        ListInitializer listInstance = ListInitializer.Instance;
        HardwareListView.ItemsSource = listInstance.HardwareList;
        listInstance.LoadProductsFromDatabase();
    }
    }
