namespace arneselectronics;

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
    
    
    
    
}