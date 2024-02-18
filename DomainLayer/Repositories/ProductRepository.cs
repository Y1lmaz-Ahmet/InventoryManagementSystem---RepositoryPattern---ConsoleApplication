using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;
        public ProductRepository() 
        {
        _products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            
            
                if (_products.Count == 0)
                {
                    Console.WriteLine("List of products is empty.");
                    return _products;
                }
                
                foreach ( Product product in _products )
                {
                    Console.WriteLine(product);
                }

            
            return _products;
        }

        public Product GetProductById(int productId)
        {
            foreach (Product product in _products)
            {
                if (product.Id == productId)
                {
                    return product;
                }
            }
            return null;
        }

        public void RemoveProduct(int productId)
        {
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Id == productId)
                {
                    _products.RemoveAt(i);
                    Console.WriteLine("Product has been removed.");
                    break;
                }
            }
            
        }

        
    }
}
