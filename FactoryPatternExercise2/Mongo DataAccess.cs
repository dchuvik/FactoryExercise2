using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class Mongo_DataAccess : IDataAccess 
    {
        public Mongo_DataAccess()
        {

        }

        public List<Product> LoadData()
        {
            Console.WriteLine("Loading data from Mongo database:");
            return Product.products;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to Mongo database.");

        }
    }
}
