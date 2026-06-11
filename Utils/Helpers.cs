using SIMS.Models;
using SIMS.Services;

namespace SIMS.Utils
{
    public static class Helpers
    {
        public static void PrintMenu()
        {
            Console.WriteLine("--- Inventory Management System ---");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Edit a Product");
            Console.WriteLine("4. Delete a Product");
            Console.WriteLine("5. Search for a Product");
            Console.WriteLine("6. Exit");
            Console.WriteLine("-----------------------------------");
            Console.Write("Select an option: ");
        }

        public static void AddProduct(Inventory inventory)
        {
            Console.Write("Enter product name: ");
            string? name = Console.ReadLine();
                if (name == null)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    return;
                }
                Console.Write("Enter price: ");
                string? priceInput = Console.ReadLine();

                if (!decimal.TryParse(priceInput, out decimal price))
                {
                    Console.WriteLine("Invalid price. Please try again.");
                    return;
                }

                Console.Write("Enter quantity: ");
                string? quantityInput = Console.ReadLine();

                if (!int.TryParse(quantityInput, out int quantity))
                {
                    Console.WriteLine("Invalid quantity. Please try again.");
                    return;
                }
            Product product = new Product(name, price, quantity);
            inventory.AddProduct(product);
            Console.WriteLine("Product added successfully!");
        }

        public static void ViewAllProducts(Inventory inventory)
        {
            var products = inventory.GetProducts();
            if (products.Count == 0)
            {
                Console.WriteLine("No products in inventory.");
                return;
            }
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
        }
    public static void EditProduct(Inventory inventory)
        {
            Console.Write("Enter product name to edit: ");
            string? name = Console.ReadLine();
            if (name == null)
            {
                Console.WriteLine("Invalid input. Please try again.");
                return;
            }
            var products = inventory.GetProducts();
            var product = products.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }
            Console.Write("Would you like to update the price? (y/n): ");
            string? updatePrice = Console.ReadLine();
            decimal price = product.Price;
            if (updatePrice?.ToLower() == "y")
            {
                Console.Write("Enter new price: ");
                string? priceInput = Console.ReadLine();

                if (!decimal.TryParse(priceInput, out price))
            {
                Console.WriteLine("Invalid price. Please try again.");
                return;
            }
            }

            Console.Write("Would you like to update the quantity? (y/n): ");
            string? updateQuantity = Console.ReadLine();
            int quantity = product.Quantity;
            if (updateQuantity?.ToLower() == "y")
            {
                Console.Write("Enter new quantity: ");
                string? quantityInput = Console.ReadLine();

                if (!int.TryParse(quantityInput, out quantity))
            {
                Console.WriteLine("Invalid quantity. Please try again.");
                return;
            }
            }
            product.UpdatePrice(price);
            product.UpdateQuantity(quantity);
            Console.WriteLine("Product updated successfully!");
        }
        
    }
}