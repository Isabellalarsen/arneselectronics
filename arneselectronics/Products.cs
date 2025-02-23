using System.Collections.ObjectModel;

namespace arneselectronics;
using System;
using System.Collections.Generic;

public class Products 
{
    //Atributes 
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public long EAN_Number { get; set; }
    public int ID { get; set; }
    public double ProductPrice { get; set; }
    
    // Constructor 
    public Products(string productName, string productDescription, long eanNumber, int id, double productPrice)
    {
        this.ProductName = productName;
        this.ProductDescription = productDescription;
        this.EAN_Number = eanNumber;
        this.ID = id;
        this.ProductPrice = productPrice;
    }
    public string Display(string display)
    {
        if (display == "FrontPage")
        {
            return $"{ProductName}\n {ProductPrice.ToString()}";
        }
        else
        {
            return $"{ProductName} \t {ProductPrice.ToString()} \n {ProductDescription} \n {EAN_Number.ToString()} \n {ID.ToString()} ";
        }
    }
}