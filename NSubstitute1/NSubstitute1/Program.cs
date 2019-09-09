using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;

namespace NSubstitute1
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = "1,2,trst,3";
            //var sum = strings.Split(',').Select(c => int.Parse(c)).Sum();
            //var sum = strings.Split(',').Where(c => int.TryParse(c, out int res)).Select(int.Parse).Sum();
            var sum = strings.Split(',').Select(c => int.TryParse(c, out int res) ? res : 0).Sum();
            Console.WriteLine(sum);


            Console.ReadKey();
        }
    }
}
