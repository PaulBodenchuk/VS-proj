using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        public static async Task Calculate()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Calculate");
        }
    }
}
