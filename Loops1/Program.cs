using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            double examScores=0;
            double average = 0;
            double sum=0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter your exam score: ");
                sum =sum+examScores;
            }

            average = sum / 3;
            Console.WriteLine($"Your average exam score is: {average:P}");
            Console.Read();
            
        }
    }
}
