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
                if (value.Length <= 30)
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
    }
}
