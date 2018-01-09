using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        static async void GetButton()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    ConsoleKeyInfo? key = Console.ReadKey();
                    if (key != null)
                    {
                        Console.WriteLine(key?.Key);
                    }
                    key = null;
                }
            });
        }
        static void Main(string[] args)
        {
            GetButton();
            Console.WriteLine("dsgsdgs");
            //int x = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    x += i;
            //}
            //Console.WriteLine(x);
            //while (true)
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("This is a main thread");
            //}
        }
    }
}
