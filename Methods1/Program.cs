using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    class Program
    {
        static void Main(string[] args)
        {
            double total;
            double input = 1;
            double result = LineValueForY(2,3,4);
            Console.WriteLine(result);

            total = Factorial(input);
            Console.WriteLine(total);
            Console.ReadKey();
        }

        static public double LineValueForY(double m, double x, double b)
        {
            double slope = (m * x) + b;
            return slope;
        }

        static public double Factorial(double factor)
        {
            double total = 1;

            for(double i=factor;i!=0;i--)
            {
                total = total * i;
            }
            return total;
        }
    }
}
