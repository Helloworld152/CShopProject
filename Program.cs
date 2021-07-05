using System;
using System.Threading;

namespace CShopProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = { "Sword", "Gun" };
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";
            Console.WriteLine("This is {0}", th.Name);
            Console.WriteLine("Hello World!");
        }
    }
}