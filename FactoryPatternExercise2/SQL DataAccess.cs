using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class SQL_DataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("Loading data from SQL database:");
            return Product.products;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to SQL database.");

        }
    }
}
