using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dapper;
using Npgsql;
using System.Linq;

namespace arneselectronics.Views;

public partial class TilbehørView : UserControl
{
    public TilbehørView()
    {
        InitializeComponent();
        ListInitializer listInstance = ListInitializer.Instance;
        AccessoriesListView.ItemsSource = listInstance.AccessoriesList;
        listInstance.LoadProductsFromDatabase();
    }
    }
