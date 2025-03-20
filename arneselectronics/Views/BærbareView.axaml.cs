using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dapper;
using Npgsql;
using System.Linq;

namespace arneselectronics.Views;

public partial class BærbareView : UserControl
{
    public BærbareView()
    {
        InitializeComponent();
        ListInitializer listInstance = ListInitializer.Instance;
        LaptopListView.ItemsSource = listInstance.LaptopList;
    }
    }
