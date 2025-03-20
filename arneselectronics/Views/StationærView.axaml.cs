using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dapper;
using Npgsql;
using System.Linq;

namespace arneselectronics.Views;

public partial class StationærView : UserControl
{
    public StationærView()
    {
        InitializeComponent();
        ListInitializer listInstance = ListInitializer.Instance;
        DesktopListView.ItemsSource = listInstance.DesktopList;
    }
}