using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorCatch_Classwork
{
    class MyException : Exception
    {
        public override string Message { get;}
        public MyException(string s)
        {
            Message = s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MyException("This is my exception");
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finale");
            }
        }
    }
}
