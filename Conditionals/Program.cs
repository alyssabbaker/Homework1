using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int cogs=0,gears=0;
            double cogPrice = 79.99;
            double gearPrice = 250.00;

            Console.WriteLine("Enter the number of cogs you wish to buy: ");
            cogs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of gears you wish to buy: ");
            gears = Convert.ToInt32(Console.ReadLine());

            double total = (cogs * cogPrice) + (gears * gearPrice);
            double markup = .15 + ((total) * .15);
            double salesTax = .089 + ((total+markup) * .089);

            double totalPrice = total+markup+salesTax;

            if(cogs>10 || gears>10 || cogs+gears==16)
            {
                double qtyMarkup = .125+(total*.125);
                double newTotal = qtyMarkup + total + salesTax;
                totalPrice = totalPrice + (newTotal* qtyMarkup);
                Console.WriteLine($"Amount before markup: {total:C}");
                Console.WriteLine($"Markup amount: {qtyMarkup:C}.");
                Console.WriteLine($"Salestax: {salesTax:C}.");
                Console.WriteLine($"The total of {cogs} cogs and {gears} gears is {newTotal:C}.");
            }
            else
            {
                Console.WriteLine($"Amount before markup: {total:C}.");
                Console.WriteLine($"Markup amount: {markup:C}");
                Console.WriteLine($"Salestax: {salesTax}.");
                Console.WriteLine($"The total of {cogs} cogs and {gears} gears is {totalPrice:C}.");
            }
          
            Console.ReadKey();

        }
    }
}
