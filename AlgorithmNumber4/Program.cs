using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace AlgorithmNumber4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter number");

            var input = Console.ReadLine(); 
            char dotCheck = '.';
            bool digitCheck = input.Contains(dotCheck);

            if (digitCheck == true) 
            {
                Console.WriteLine(input.Length -1);
            }
            else
            {
                Console.WriteLine(input.Length);
            }


        }

    }
    
 }

