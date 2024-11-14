using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCleanCode.entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool IsAvailable { get; set; }

}
public static class DummyData
{
    public static IEnumerable<Product> GetDummyProducts()
    {
        return new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Product 1",
                Price = 9.99,
                Description = "Description for Product 1",
                IsAvailable = true
            },
            new Product
            {
                Id = 2,
                Name = "Product 2",
                Price = 19.99,
                Description = "Description for Product 2",
                IsAvailable = true
            },
            new Product
            {
                Id = 3,
                Name = "Product 3",
                Price = 29.99,
                Description = "Description for Product 3",
                IsAvailable = false
            },
            new Product
            {
                Id = 4,
                Name = "Product 4",
                Price = 39.99,
                Description = "Description for Product 4",
                IsAvailable = true
            },
            new Product
            {
                Id = 5,
                Name = "Product 5",
                Price = 49.99,
                Description = "Description for Product 5",
                IsAvailable = false
            }
        };
    }
}
