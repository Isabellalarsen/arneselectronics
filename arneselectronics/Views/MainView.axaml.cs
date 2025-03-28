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
        // Test comment
        // Test comment 2
        InitializeComponent();
        DataContext = this;
        ListInitializer listInitializer = ListInitializer.Instance;
    }  
}
