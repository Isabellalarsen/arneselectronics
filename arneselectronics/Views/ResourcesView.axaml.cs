using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace arneselectronics.Views;

public partial class ResourcesView : UserControl
{
    public ResourcesView()
    {
        InitializeComponent();
        ListInitializer listInstance = ListInitializer.Instance;
    } 
    }
