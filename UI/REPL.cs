using System;
using SIMS.Models;
using SIMS.Services;
using SIMS.Utils;

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
                Helpers.PrintMenu();
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Helpers.AddProduct(inventory);
                        break;
                    case "2":
                        Helpers.ViewAllProducts(inventory);
                        break;
                    case "3":
                        Helpers.EditProduct(inventory);
                        break;
                    case "4":
                        Helpers.DeleteProduct(inventory);
                        break;
                    case "5":
                        Helpers.SearchProduct(inventory);
                        break;
                    case "6":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}