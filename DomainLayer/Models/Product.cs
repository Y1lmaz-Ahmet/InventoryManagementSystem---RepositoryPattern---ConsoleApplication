using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Product
    {
        private int _id;
        private string _name;
        private string _description;
        private double _price;
        private int _stock;

        public Product(int id, string name, string description, double price, int stock)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
        }

        public int Id
        {
            get { return _id; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Id cannot be 0.");
                }
                _id = value;
            }
        }
        public string Name
        {
            get { return _name; }
            private set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                _name = value;
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Product description cannot be empty.");
                }
                if (value.Length <= 10)
                {
                    throw new ArgumentException("Product description atleast needs 30 characters.");
                }
                _description = value;
            }
        }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Product Price cannot be less or equal to 0.");
                }
                _price = value;
            }
        }
        public int Stock
        {
            get { return _stock; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Product stock cannot be negative.");
                }
                _stock = value;
            }
        }

        public void UpdateProduct(Product updatedProduct)
        {
            if (updatedProduct == null)
            {
                throw new ArgumentNullException(nameof(updatedProduct), "Updated product cannot be null.");
            }

            // Controleer of de ID's overeenkomen
            if (this.Id != updatedProduct.Id)
            {
                throw new ArgumentException("Cannot update product with different ID.");
            }

            // Werk de eigenschappen van het product bij met de gegevens van het bijgewerkte product
            this.Name = updatedProduct.Name;
            this.Description = updatedProduct.Description;
            this.Price = updatedProduct.Price;
            this.Stock = updatedProduct.Stock;
        }
        public override string ToString()
        {
            string idString = $"ID: {Id}";
            string nameString = $"Name: {Name}";
            string descriptionString = $"Description: {Description}";
            string priceString = $"Price: ${Price}"; // Gebruik C-indeling voor valuta
            string stockString = $"Stock: {Stock}";

            // Voeg alle geformatteerde strings samen
            string productInfo = $"\n{idString}\n{nameString}\n{descriptionString}\n{priceString}\n{stockString}\n";

            return productInfo;
        }
    }
}
