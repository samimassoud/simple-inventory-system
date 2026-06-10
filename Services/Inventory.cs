
namespace SIMS.Services;
using SIMS.Models;
using System.Collections.Generic;

class Inventory
{
    List<Product> products;
    public Inventory()
    {
        products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public List<Product> GetProducts()
    {
        return products;
    }
}