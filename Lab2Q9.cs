using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabitaLabwork
{
    class Product
    {
        // Auto-Implemented Property
        public string Name { get; set; }

        // Read-Only Property
        private double _price;
        public double Price
        {
            get { return _price; }
        }

        // Write-Only Property
        private double _discount;
        public double Discount
        {
            set { _discount = value; }
        }

        // Computed Property (Getter only)
        public double FinalPrice
        {
            get { return _price - _discount; }
        }

        // Constructor to initialize the read-only property
        public Product(string name, double price)
        {
            Name = name;
            _price = price;
        }
    }

    class Lab2Q9
    {
        /*static void Main()
        {
            // Create a product object
            Product product = new Product("Laptop", 1000);

            // Auto-Implemented Property usage
            Console.WriteLine("Product Name: " + product.Name);

            // Read-Only Property usage
            Console.WriteLine("Product Price: $" + product.Price);

            // Write-Only Property usage (setting discount)
            product.Discount = 100;

            // Computed Property usage (Final price after discount)
            Console.WriteLine("Final Price after Discount: $" + product.FinalPrice);
        }*/
    }

}
