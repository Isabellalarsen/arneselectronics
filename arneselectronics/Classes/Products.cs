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
                    if (!string.IsNullOrEmpty(FilePath))
                    {
                        var uri = new Uri(FilePath);
                        using var stream = AssetLoader.Open(uri);
                        return new Bitmap(stream);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Could not load image: {FilePath} - {ex.Message}");
                }

                // Fallback-billede, hvis der opstår en fejl
                var fallbackUri = new Uri("avares://arneselectronics/Assets/fallback.jpg");
                using var fallbackStream = AssetLoader.Open(fallbackUri);
                return new Bitmap(fallbackStream);
            }
        }

        public Products(string id, string name, string? manufacturer, string eanNumber, 
                        double price, string? type, string? filePath, string description)
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

        // Tom constructor til database-oprettelse af produkter
        public Products() { }

        public string Display(string displayMode)
        {
            return displayMode == "FrontPage"
                ? $"{Name}\n{Price:C}"
                : $"{Name}\t{Price:C}\n{DescriptionPath}\nEAN: {EAN_Number}\nID: {ID}";
        }
    }
}
