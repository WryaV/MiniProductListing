# Product Listing and Search Console App

This C# console application helps users manage a list of products by adding, listing, and searching for them. Users can enter product details such as category, name, and price, and later retrieve or search through the list.

## Features

- **Add Products**: Input product category, name, and price.
- **View Sorted List**: Displays the products sorted by price.
- **Search Functionality**: Search for a specific product after listing.

## How to Use

1. Clone the repository and open it in **Visual Studio Code**.
2. Run the project using:
    ```bash
    dotnet run
    ```
3. Follow the prompts to:
   - Add products.
   - View the sorted product list.
   - Optionally, search for a specific product.

## Example

```bash
Product's Category: Electronics
Product's Name: Headphones
Product's Price: 50

Product's Category: Groceries
Product's Name: Apple
Product's Price: 2

Do you want to search for a specific item? Yes/No: Yes
Search Term: Apple

Results:
Groceries, Apple, 2
