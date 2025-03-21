using Avalonia.Controls;
using Avalonia.Interactivity;

namespace arneselectronics;

public class CartButton
{
    private int total = 0;
    private int quantity = 0;

    private TextBlock Total;
    private TextBlock Quantity;

    public CartButton(TextBlock total, TextBlock quantity)
    {
        Total = total;
        Quantity = quantity;
    }

    public void HandleButtonClick(object? sender, RoutedEventArgs e)
    {
        total++;
        quantity++;

        Total.Text = $"Total: {total}";
        Quantity.Text = $"Quantity: {quantity}";
    }
    
    
}