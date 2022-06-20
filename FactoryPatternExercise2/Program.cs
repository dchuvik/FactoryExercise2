using System;

namespace FactoryPatternExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use?");
            Console.WriteLine("List, SQL, MongoDB?");
            var response = Console.ReadLine();

            var da = DataAccessFactory.GetDataAccess(response);

            da.SaveData();

            var products = da.LoadData();
            Console.WriteLine("Here are your items: \n");

            foreach (var item in products)
            {
                Console.WriteLine($"Product Name: {item.Name}");
                Console.WriteLine($"Product Price: ${item.Price}\n");
            }
        }
    }
}
