using Avalonia.Controls;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Collections;
using Dapper;
using Npgsql;
using arneselectronics.ViewModels;


namespace arneselectronics;

public partial class MainView : Window
{
    public MainView()
    {
        InitializeComponent();
        ListInitializer listInitializer = ListInitializer.Instance;
    }
    
}
