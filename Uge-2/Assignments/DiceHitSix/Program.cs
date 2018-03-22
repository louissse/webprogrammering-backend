using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceHitSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start the dice.");
            Console.ReadLine();
            bool exit = false;
            while (!exit)
            {
                Random r = new Random();
                int i = 1;
                int dice = r.Next(1, 7);

                while (dice != 6 && i != 100)
                {
                    Console.WriteLine(string.Format("The dice is {0}.", dice));
                    dice = r.Next(1, 7);
                    i++;
                }
                Console.WriteLine(string.Format("The dice is finally {0}.", dice));
                Console.WriteLine("Press any button to try again. Write Exit to exit.");
                string continueOrExit = Console.ReadLine();

                if (continueOrExit == "Exit" || continueOrExit ==  "exit") {
                    exit = true;
                }
            }
        }
    }
}
