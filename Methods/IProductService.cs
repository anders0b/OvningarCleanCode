using OvningarCleanCode.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCleanCode.Methods
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
    public class ProductService : IProductService
    {
        private readonly IProductService _productService;
        public ProductService(IProductService productService)
        {
            _productService = productService;
        }
        public void AddProduct(Product product)
        {
            _productService.AddProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productService.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _productService.GetProductById(id);
        }

        public void UpdateProduct(Product product)
        {
            _productService.UpdateProduct(product);
        }
    }
}
