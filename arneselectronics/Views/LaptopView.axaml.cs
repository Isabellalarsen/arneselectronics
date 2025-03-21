using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dapper;
using Npgsql;
using System.Linq;

namespace arneselectronics.Views;

public partial class LaptopView : UserControl
{
    public LaptopView()
    {
        InitializeComponent();
        ListInitializer listInstance = ListInitializer.Instance;
        LaptopListView.ItemsSource = listInstance.LaptopList;
    }
    }
