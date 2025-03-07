using Avalonia.Controls;               
using System;                          
using System.Collections.ObjectModel;  
using System.Collections.Generic;      
using System.Linq;                     
using Avalonia.Collections;            
using Dapper;                          
using Npgsql;                          

/*namespace arneselectronics;

public class Productbob
{
    Lists listInstance = new Lists();

    string conString = "Host=localhost;Username=postgres;Password=Lillemy97;Database=arne";
        
        using (var con = new NpgsqlConnection(conString))                                             
    {                                                                                             
        var data = con.Query<Products>("SELECT * FROM products").ToList();                        
        foreach (var product in data)                                                             
        {                                                                                         
            listInstance.ProductsList.Add(product);                                               
        }                                                                                         
    } 
}*/