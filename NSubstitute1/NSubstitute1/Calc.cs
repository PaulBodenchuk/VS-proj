using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSubstitute1
{
    class Calc : ICalculator
    {
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public string Mode { get; set; }
        public event EventHandler PoweringUp;
        public void TestMethod(out int input)
        {
            input = 5;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public bool LoadMemory(int p0, ref int any)
        {
            any = 5;
            return  true;
        }
    }
}
