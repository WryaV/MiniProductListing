using System;

namespace MoneyTracking;

public class SortandSearch
{
    public string searchTerm;
    List<GetInfo> Products = new();
    public SortandSearch(List<GetInfo> products)
        {
            Products = products;
        }
         public void SearchFunction(string searchTerm)
    {
        Console.WriteLine("List of Products with Search Highlight:");
    foreach (var Productt in Products)
    {
        // Check if the product name contains the search term
        if (Productt.productName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Highlight color, we choose yellow!
        }

        // Print the product details
        Console.WriteLine(String.Format("{0}, {1}, {2}",
            Productt.productCategory,
            Productt.productName,
            Productt.productPrice));

        Console.ResetColor(); // Reset color to default
    }
    }
    
   
}
