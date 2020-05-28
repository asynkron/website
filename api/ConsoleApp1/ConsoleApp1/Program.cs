using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var isAdmin = true;
            x(isAdmin?(Func<int>)doSomething:null);
        }

        static int pass()
        {
            return 0;
        }

        static void x(Func<int> f)
        {
            f();
        }

        static int doSomething()
        {
            return 1;
        }
    }
}