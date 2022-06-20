using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class Product
    {
        public Product()
        {
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public static List<Product> products = new List<Product>()
        {
            new Product(){ Name = "Pogo Stick", Price = 25.00 },
            new Product(){ Name = "Skateboard", Price = 35.00 },
            new Product() { Name = "BasketBall", Price = 15.00},
            new Product(){ Name = "Slinky", Price = 5.00 },
        };

    }
}
