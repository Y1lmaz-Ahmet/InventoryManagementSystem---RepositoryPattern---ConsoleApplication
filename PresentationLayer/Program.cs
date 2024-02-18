using DomainLayer.Models;
using DomainLayer.Repositories;
using System;

namespace PresentationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize a Productrepository.
            ProductRepository productRepository = new ProductRepository();

            // Check if list of product has anything.
            Console.WriteLine("Current list of products:");
            productRepository.GetAllProducts();

            // Create a product & Add a new product to the list.
            Console.WriteLine("\nAdding a new product: [AddProduct]");
            Product chocolateCookies = new Product(1, "ChocolateCookies", "Indulge in the heavenly combination of rich chocolate.", 2, 500);
            productRepository.AddProduct(chocolateCookies);

            // Check if the addMethod actually worked.
            Console.WriteLine("\nCurrent list of products after adding one product:");
            productRepository.GetAllProducts(); // Expected : 1 product

            // Remove the product
            Console.WriteLine("\nRemoving a product: [RemoveProduct]");
            productRepository.RemoveProduct(1);

            // Check if the product is removed.
            Console.WriteLine("\nCurrent list of products after removing one product:");
            productRepository.GetAllProducts();

            // Initialize 5 product & Add them to the list.
            Console.WriteLine("\nAdding 5 new products: [AddProduct]");
            Product[] productsToAdd = new Product[]
            {
                new Product(1, "Chocolate Cookies", "Indulge in the heavenly combination of rich chocolate.", 2.0, 500),
                new Product(2, "Vanilla Cupcakes", "Delight in the classic flavor of vanilla with our fluffy cupcakes.", 2.5, 300),
                new Product(3, "Strawberry Cake", "Savor the sweetness of ripe strawberries in our moist and delicious cake.", 3.0, 200),
                new Product(4, "Lemon Bars", "Experience the tangy taste of lemon in our zesty bars.", 2.25, 400),
                new Product(5, "Oatmeal Raisin Cookies", "Enjoy the wholesome goodness of oats and raisins in our chewy cookies.", 1.75, 600)
            };

            foreach (Product product in productsToAdd)
            {
                productRepository.AddProduct(product);
            }

            // Check if the 5 products were added.
            Console.WriteLine("\nCurrent list of products after adding 5 products:");
            productRepository.GetAllProducts();

            // Update Chosen product.
            Console.WriteLine("\nUpdating a product: [UpdateProduct]");
            Product existingProduct = productRepository.GetProductById(1);
            if (existingProduct != null)
            {
                Product updatedProduct = new Product(1, "Chocolate Cookies", "Updated product description.", 2.0, 500);
                existingProduct.UpdateProduct(updatedProduct);
            }
            Console.WriteLine("\nUpdated product information:");
            Console.WriteLine(productRepository.GetProductById(1));
        }
    }
}
