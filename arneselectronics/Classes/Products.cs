using Avalonia.Platform;
using Avalonia.Media.Imaging;
using System;
using System.IO;

namespace arneselectronics
{
    public class Products 
    {
        public string Name { get; set; }
        public string DescriptionPath { get; set; }
        public string EAN_Number { get; set; }
        public string ID { get; set; }
        public double Price { get; set; }
        public string? FilePath { get; set; }
        public string? Type { get; set; }
        public string? Manufacturer { get; set; }
        
        public Bitmap? ProductImage
        {
            get
            {
                try
                {
                    var uri = new Uri(FilePath);
                    using var stream = AssetLoader.Open(uri);
                    return new Bitmap(stream);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Kunne ikke loade billede: {FilePath} - {ex.Message}");
                    var uri = new Uri("avares://arneselectronics/Assets/fallback.jpg");
                    using var stream = AssetLoader.Open(uri);
                    return new Bitmap(stream);
                }
            } 
        }

        public Products(string id, string name, string? manufacturer, string eanNumber, double price, string? type, string? filePath, string description)
        {
            ID = id;
            Name = name;
            Manufacturer = manufacturer;
            EAN_Number = eanNumber;
            Price = price;
            Type = type;
            FilePath = filePath;
            DescriptionPath = description;
        }
        // Empty constructor for creating products from database
        public Products()
        {
            
        }

        public string Display(string display)
        {
            if (display == "FrontPage")
            {
                return $"{Name}\n {Price}";
            }
            else
            {
                return $"{Name} \t {Price} \n {DescriptionPath} \n {EAN_Number} \n {ID}";
            }
        }
    }
}