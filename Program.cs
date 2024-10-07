using System.Net;
using MoneyTracking;

// A Console App That Helps Users Manage Their Expenses and Incomes
Coloring.SetColor(ConsoleColor.Green);
try
{
    // Define the text to display
string text1 = "Enter The Category, Product Name and Price";
string text2 = "To Get the Final List or Exit hit \"Q\"";

// Display centered text
Coloring.DisplayCenteredText(text1, text2);

// Reset color to default (white), assuming the terminal background is Black
Console.ForegroundColor = ConsoleColor.White;
List<GetInfo> Products = new List<GetInfo>();
decimal totalPrice = 0;
while (true) // Main loop for adding products
{
    
    Console.WriteLine("Product's Category: ");
    string proCatg = Console.ReadLine();
    if (proCatg.ToLower() == "q") break; // Exit if user types "Q" or "q"

    Console.WriteLine("Product's Name: ");
    string proNs = Console.ReadLine();

    // Loop until a valid product Price is entered, should be an integer number
    int proPrice;
    while (true)
    {
        Console.WriteLine("Product's Price: ");
        bool result = int.TryParse(Console.ReadLine(), out proPrice);
        if (result) break; // Exit the loop if the input is valid
        Console.WriteLine("The input is not a valid Price. Please enter a valid Price."); // wait for valid Price
    }

    // Add the product information to the defined list
    Products.Add(new GetInfo(proCatg, proNs, proPrice));
    totalPrice += proPrice;
    Console.WriteLine("Product was added successfully.\n");

    // Ask if the user wants to add more items, here the answer should be Yes or No, q does not work, q only works
    // when we are at the first loop and user provides information about the product
    while (true)
    {
        Console.WriteLine("Do you have any more items to include in this list? Yes/No");
        string userResponse = Console.ReadLine();

        if (userResponse.ToLower() == "no")
        {
            Console.WriteLine("Thanks for today!");
            goto PrintProducts; // Go to the section to print products
        }
        else if (userResponse.ToLower() == "yes")
        {
            break; // Break out of the inner loop to add another product
        }
        else
        {
            Console.WriteLine("Invalid response. Please enter 'Yes' or 'No'.");
        }
    }
}

PrintProducts: // Label to jump to print products, combined with goto command
var sortedProducts = Products.OrderBy(p => p.productPrice);

foreach (var Productt in sortedProducts)
{
    Console.WriteLine(String.Format("{0}, {1}, {2}", 
        Productt.productCategory, 
        Productt.productName, 
        Productt.productPrice));
}
Console.WriteLine("\nTotal Price: " + totalPrice);
// Ask user for a search term, if he want to search at the end
Console.WriteLine("Do you want to search for a specific item? (Yes/No)");
string searchResponse = Console.ReadLine();
if (searchResponse.ToLower() == "yes")
{
Console.WriteLine("please inset the search term you want to look up");
string searchTerm= Console.ReadLine();

    SortandSearch Sorting=new SortandSearch(Products);
    Sorting.SearchFunction(searchTerm);
}
}
catch (Exception ex) // General catch for unexpected errors
{
    Console.WriteLine($"An unexpected error occurred, maybe you provided an empty space or the program crashed, start over, " +
    $": {ex.Message}");
}
