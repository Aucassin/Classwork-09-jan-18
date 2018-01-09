using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likes
{
    class Program
    {
        static void Likes(string[] x)
        {
            switch (x.Length)
            {
                case 0:
                    Console.WriteLine($"No one likes this");
                    break;
                case 1:
                    Console.WriteLine($"{x[0]} likes this");
                    break;
                case 2:
                    Console.WriteLine($"{x[0]} and {x[1]} like this");
                    break;
                case 3:
                    Console.WriteLine($"{x[0]}, {x[1]} and {x[2]} like this");
                    break;
                default:
                    Console.WriteLine($"{x[0]}, {x[1]} and {x.Length-2} others like this");
                    break;

            }
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string[] wholiked = { "Alex", "Jacob", "Mark", "Max", "Jenny", "Andy"};
            Likes(wholiked);
        }
    }
}
