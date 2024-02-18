using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Repositories
{
    public interface IProductRepository
    {
        // Add new product
        void AddProduct(Product product);
        // Remove product
        void RemoveProduct(int productId);
        // Get product by ID
        Product GetProductById(int productId);
        // Get all Products
        List<Product> GetAllProducts();
    }
}
