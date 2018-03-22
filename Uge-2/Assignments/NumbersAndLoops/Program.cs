using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start program.");
            Console.ReadLine();
            //Opgave 2.5
            for (int i = 1; i <= 10; i++)
            {
                int[] numberArray = new int[10];
                for (int j = 1; j <= 10; j++)
                {
                    numberArray[j-1] = i * j;
                }
                foreach(int number in numberArray)
                {
                    Console.Write(string.Format("{0}, ", number));
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Press enter to see the next part.");
            Console.ReadLine();

            //Opgave 2.5
            int[] twentyNumbers = new int[20];
            for (int i = 1; i <= 20; i++)
            {
                twentyNumbers[i - 1] = i;
            }
            foreach (int number in twentyNumbers)
            {
                string evenOrOdd = "even";
                if (number % 2 != 0)
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine(string.Format("{0}, {1}", number, evenOrOdd));
            }
            Console.ReadLine();

        }
    }
}
