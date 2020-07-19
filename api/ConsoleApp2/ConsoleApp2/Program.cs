using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using var x = new Some();

            await foreach (var y in AsyncStuff())
            {
                
            }
            
            Console.WriteLine("Hello World!");
        }

        static async List<Task<string>> AsyncStuff()
        {
            
        }
    }

    public class Some : IDisposable
    {
        public void Dispose()
        {
        }
    }
}