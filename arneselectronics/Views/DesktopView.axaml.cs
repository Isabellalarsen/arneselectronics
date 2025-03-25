using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dapper;
using Npgsql;
using System.Linq;
using arneselectronics;

namespace arneselectronics.Views;

public partial class DesktopView : UserControl
{
    public DesktopView()
    {
        InitializeComponent();
        ListInitializer listInstance = ListInitializer.Instance;
        DesktopListView.ItemsSource = listInstance.DesktopList; 
    }
}