using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lowerCaseLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] upperCaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            string let1 = upperCaseLetters[0].ToString();
            string let2 = lowerCaseLetters[11].ToString();
            string let3 = lowerCaseLetters[24].ToString();
            string let4 = lowerCaseLetters[18].ToString();
            string let5 = lowerCaseLetters[18].ToString();
            string let6 = lowerCaseLetters[0].ToString();
            Console.WriteLine($"{ let1}{ let2}{ let3}{ let4}{ let5}{ let6}");
            Console.ReadKey();


        }
    }
}
