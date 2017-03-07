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
            Console.Write("please input your name:");
            string name = Console.ReadLine();
            Console.Write("please input your password:");
            string password = Console.ReadLine();
            Console.WriteLine("hi {0} welcome", name);
            Console.WriteLine("!!!!!");

            //Console.WriteLine("使用者名稱:");
            //string userName = Console.ReadLine();
            //Console.WriteLine(); ("請輸入密碼");
            //string userPassword = Console.ReadLine();
            //Console.WriteLine("{0} 您好，登入成功", userName);
        }
    }
}