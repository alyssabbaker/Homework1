using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            double examscores = 0;
            double sum = 0;

            string answer;

            double average=0;
            int test = 1;

            Console.WriteLine("Please enter your exam score: ");
            examscores = Convert.ToDouble(Console.ReadLine());

            do
            {
                
                Console.WriteLine("Do you have another score to enter?");
                answer = Convert.ToString(Console.ReadLine()).ToLower();
                if(answer=="yes")
                {
                    Console.WriteLine("Please enter your exam score: ");
                    examscores = examscores + Convert.ToDouble(Console.ReadLine());
                    sum += examscores;
                    test = test + 1;
                }
                else if (answer=="no")
                { 
                    
                }
            }while(answer!="no");
            average = examscores / test;
            Console.WriteLine($"Your average exam score is {average.ToString("n2")}%.");

            Console.ReadKey();
        }
    }
}
