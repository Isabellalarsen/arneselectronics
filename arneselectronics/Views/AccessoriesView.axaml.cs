using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dapper;
using Npgsql;
using System.Linq;

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
