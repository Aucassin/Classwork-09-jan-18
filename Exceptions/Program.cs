using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void GetException()
        {
            Console.WriteLine("Recursion");
            GetException();
        }

        static void Main(string[] args)
        {
            int x = 5, y = 0;
            //Console.WriteLine(x/y);

            try
            {
                int[] array = new int[1000000000];
                //GetException();
                //Console.WriteLine(x/y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finita");
            }
        }
    }
}
