using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_09_jan_18
{
    class Program
    {
        static void Print (int x)
        {
            if(x==0)
            {
                return;
            }
            else
            {
                Console.WriteLine(x);
                Print(x - 1);
            }
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            Print(3);
        }
    }
}
