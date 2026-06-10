using System;
using SIMS.Models;
using SIMS.Services;

namespace SIMS.UI
{
    public class ConsoleApp
    {
        private Inventory inventory;

        public ConsoleApp()
        {
            inventory = new Inventory();
        }

        public void Run()
        {
            while (true)
            {
                Console.Write("Enter product name: ");
                string? name = Console.ReadLine();
                if (name == null)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
                Console.Write("Enter price: ");
                string? priceInput = Console.ReadLine();

                if (!decimal.TryParse(priceInput, out decimal price))
                {
                    Console.WriteLine("Invalid price. Please try again.");
                    continue;
                }

                Console.Write("Enter quantity: ");
                string? quantityInput = Console.ReadLine();

                if (!int.TryParse(quantityInput, out int quantity))
                {
                    Console.WriteLine("Invalid quantity. Please try again.");
                    continue;
                }
                Product product = new Product(name, price, quantity);
                inventory.AddProduct(product);

                Console.WriteLine("Product added!\n");
            }
        }
    }
}