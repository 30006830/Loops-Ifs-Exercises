using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsandIfs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Odd Number Counter: Task 1");
            int start = 76;
            int finish = 46;

            while (start >= finish)
            {
                if (start % 2 != 0)
                    Console.WriteLine(start);
                start--;
            }
            Console.WriteLine("End of Task 1...");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Character/Symbol Counter: Task 2");       

            Console.WriteLine("Please enter a character/symbol: ");
            string reply = Console.ReadLine();

            Console.WriteLine("Please enter a counter: ");
            int counter = int.Parse(Console.ReadLine());

            for(int i = 0; i <= counter; i++)
            {
                Console.Write(reply);
            }
            Console.WriteLine("\nEnd of the for loop..");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Rectangle Generator: Task 3");

            Console.WriteLine("Please enter a symbol for the use of creating a rectangle:");
            string symbol = Console.ReadLine();
            Console.WriteLine("Enter the height of the Rectangle:");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter the width of the Rectangle:");
            int width = int.Parse(Console.ReadLine());

            for(int i = 0; i < height; i++)
            {
                for(int e = 0; e < width; e++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nThat's the end of Task 3...");
            Console.ReadLine();
        }
    }
}
