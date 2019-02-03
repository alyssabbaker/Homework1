using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = { "apples", "oranges", "bananas", "grapes", "blueberries" };
            double[] fruitPrice = { .99, .5, .5, 2.99, 1.99 };
            string choice;
            double price;
            bool isValidItem = false;

            Console.WriteLine("Please enter which fruit you'd like to buy...apples, oranges, bananas, grapes, or blueberries:  ");
            choice = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < fruit.Length; i++)
            {
                if(choice==fruit[i])
                {
                    price = fruitPrice[i];
                    Console.WriteLine($"The price of {fruit[i]} is {fruitPrice[i]}");
                    isValidItem = true;
                }

            }

            if (isValidItem == false)
            {
                Console.WriteLine("Invalid entry, please enter again: ");
            }

            Console.ReadKey();

        }
    }
}
