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
    Console.WriteLine("Type 'help' to see available commands.");

    while (true)
    {
        Console.Write("> ");
        string? input = Console.ReadLine()?.Trim().ToLower();

        if (string.IsNullOrWhiteSpace(input))
            continue;

        switch (input)
        {
            case "help":
                Helpers.PrintMenu();
                break;

            case "add":
                Helpers.AddProduct(inventory);
                break;

            case "view":
                Helpers.ViewAllProducts(inventory);
                break;

            case "edit":
                Helpers.EditProduct(inventory);
                break;

            case "delete":
                Helpers.DeleteProduct(inventory);
                break;

            case "search":
                Helpers.SearchProduct(inventory);
                break;

            case "exit":
                Console.WriteLine("Exiting...");
                return;

            default:
                Console.WriteLine("Unknown command. Type 'help' to see available commands.");
                break;
                }
            }
        }
    }
}