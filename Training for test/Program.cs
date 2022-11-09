using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_for_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Running = true;
            while (Running)
            {
                Console.WriteLine("Contine");
                Console.Write("(N)");
                string enter = Console.ReadLine();
                int number = 0;
                if (enter == "N")
                {
                    break;
                }
                Console.WriteLine("Select a number");
                number = int.Parse(Console.ReadLine());

                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine("Number" + (i + 1));
                }
            }
        }
    }
}
