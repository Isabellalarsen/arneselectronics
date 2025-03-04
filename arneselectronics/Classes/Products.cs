using Avalonia.Platform;
using Avalonia.Media.Imaging;
using System;
using System.IO;

namespace arneselectronics
{
    public class Products 
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public long EAN_Number { get; set; }
        public int ID { get; set; }
        public double ProductPrice { get; set; }
        public string ImageFilePath { get; set; }

        public Bitmap ProductImage
        {
            get
            {
                try
                {
                    var uri = new Uri(ImageFilePath);
                    using var stream = AssetLoader.Open(uri);
                    return new Bitmap(stream);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Kunne ikke loade billede: {ImageFilePath} - {ex.Message}");
                    return null;
                }
            }
        }

        public Products(string productName, string productDescription, long eanNumber, int id, double productPrice, string imageFilePath)
        {
            ProductName = productName;
            ProductDescription = productDescription;
            EAN_Number = eanNumber;
            ID = id;
            ProductPrice = productPrice;
            ImageFilePath = imageFilePath;
        }

        public string Display(string display)
        {
            if (display == "FrontPage")
            {
                return $"{ProductName}\n {ProductPrice}";
            }
            else
            {
                return $"{ProductName} \t {ProductPrice} \n {ProductDescription} \n {EAN_Number} \n {ID}";
            }
        }
    }
}