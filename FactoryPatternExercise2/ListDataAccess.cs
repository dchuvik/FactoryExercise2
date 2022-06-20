using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
        {

        }

        public List<Product> LoadData()
        {
            Console.WriteLine("Reading data from your list: ");
            return Product.products;
        }

        public void SaveData()
        {
            Console.WriteLine("data has been saved.");
        }
    }
}
