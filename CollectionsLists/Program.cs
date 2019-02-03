using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLists
{
    class Program
    {
        static void Main(string[] args)
        {
            double examScores=0;
            double average=0;
            string answer;
            double sum=0;
            List<double> examGrades = new List<double>();

            do
            {
                Console.WriteLine("Please enter your exam score: ");
                examScores = Convert.ToDouble(Console.ReadLine());
                examGrades.Add(examScores);
                Console.WriteLine("Do you have another grade to enter? ");
                answer = Convert.ToString(Console.ReadLine().ToLower());
            } while (answer == "yes");

            foreach(double score in examGrades)
            {
                sum = sum + score;
            }

            average = sum / examGrades.Count;
            Console.WriteLine($"The average exam score is {average}.");
            Console.ReadKey();
        }


    }
}
