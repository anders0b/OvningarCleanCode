using OvningarCleanCode.entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCleanCode.Methods;

public class InventoryManager
{
    private List<Product> ProductList = new List<Product>
    {
            new Product { Name = "Gaming Laptop Pro", Price = 1500, Description = "High-performance laptop for gaming.", IsAvailable = true },
            new Product { Name = "Workstation PC", Price = 2500, Description = "Powerful desktop for professional work.", IsAvailable = true },
            new Product { Name = "Budget Laptop", Price = 400, Description = "Affordable laptop for everyday tasks.", IsAvailable = true },
            new Product { Name = "Ultrabook X", Price = 1100, Description = "Lightweight ultrabook with long battery life.", IsAvailable = true },
            new Product { Name = "Gaming Desktop Elite", Price = 2000, Description = "Desktop with top specs for intense gaming.", IsAvailable = false },
            new Product { Name = "All-in-One PC", Price = 800, Description = "All-in-One desktop with touchscreen.", IsAvailable = true },
            new Product { Name = "Convertible Laptop", Price = 950, Description = "2-in-1 laptop and tablet.", IsAvailable = true },
            new Product { Name = "High-End Laptop", Price = 1800, Description = "Premium laptop for professionals.", IsAvailable = false },
            new Product { Name = "Mini Desktop", Price = 700, Description = "Compact desktop for small spaces.", IsAvailable = true },
            new Product { Name = "Chromebook", Price = 300, Description = "Affordable Chromebook for web-based tasks.", IsAvailable = true }
        };
    public void AddToInventory(Product product)
    {
        if(product != null)
        {
            ProductList.Add(product);
        }
    }
    public void UpdateProduct(Product product)
    {
        if(product != null)
        {
            var originalProduct = ProductList.FirstOrDefault(p => p.Name == product.Name);
            if (originalProduct != null)
            {
                originalProduct.Price = product.Price;
                originalProduct.Description = product.Description;
                originalProduct.IsAvailable = product.IsAvailable;
            }
        }
        else
        {
            throw new Exception("Please insert valid product");
        }
    }
    public void DeleteProduct(Product product)
    {
        if (product != null)
        {
            var productToDelete = ProductList.FirstOrDefault(p => p.Name == product.Name);
            if (productToDelete != null)
            {
                ProductList.Remove(productToDelete);
            }
        }
        else
        {
            throw new Exception("Please insert valid product");
        }
    }
    public List<Product> GetProducts()
    {
        return ProductList;
    }
}
