using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.Write("please input your name:");
            //string name = Console.ReadLine();
            //Console.Write("please input your password:");
            //string password = Console.ReadLine();
            //Console.WriteLine("hi {0} welcome", name);
            //Console.WriteLine("^____________^");

            //float floatPI = 3.141592653589793238f;
            //double doublePI = 3.141592653589793238;
            //Console.WriteLine("Float PI is: {0}", floatPI);
            //Console.WriteLine("Double PI is: {0}", doublePI);
            //Console.WriteLine("^____________^");

            Console.WriteLine(0.1f + 0.2f == 0.3f);
            Console.WriteLine(1 / 2);
            Console.WriteLine((1 / 2) * 10);
            Console.WriteLine(0.1f + 0.2f == 0.3f);
            Console.WriteLine(1.0f + 0.33f == 1.33f);
            Console.WriteLine(1.0 / 2.0 * 10.0);

            //double a = 1.0ff;
            //double b = 0.33f;
            //double sum = 1.33f;
            //bool equal = (a + b == sum);
            //Console.WriteLine("a+b={0}  sum={1}  equal={2}",
            //    a + b, sum, equal);
        }
    }
}