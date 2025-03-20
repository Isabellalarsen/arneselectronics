using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Dapper;
using Npgsql;
using System.Linq;

namespace arneselectronics.Views;

public partial class HomePageView : UserControl
{
    public HomePageView()
    {
        InitializeComponent();
        ListInitializer listInstance = ListInitializer.Instance;
        ProductsListView.ItemsSource = listInstance.ProductsList;
        listInstance.LoadProductsFromDatabase();
    }
    }
