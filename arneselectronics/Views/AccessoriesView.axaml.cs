using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dapper;
using Npgsql;
using System.Linq;
using arneselectronics;

namespace arneselectronics.Views;

public partial class AccessoriesView : UserControl
{
    public AccessoriesView()
    {
        InitializeComponent();
        ListInitializer listInstance = ListInitializer.Instance;
        AccessoriesListView.ItemsSource = listInstance.AccessoriesList;
    }
    }
