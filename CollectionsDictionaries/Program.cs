using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> fruits = new Dictionary<string, double>;
            fruits.Add("apples", .99);
            fruits.Add("oranges", .5);
            fruits.Add("bananas", .5);
            fruits.Add("grapes", 2.99);
            fruits.Add("blueberries", 1.99);
            string fruit;
            Console.WriteLine("Please enter the fruit you wish to buy: ");
            fruit = Console.ReadLine();
            Console.WriteLine(fruits[fruit]);
            Console.ReadKey();
        }
    }
}
