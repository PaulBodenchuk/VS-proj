using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSubstitute1
{
    class MajorClass
    {
        public ICalculator Calc { get; set; }

        public int GetResult(int a, int b, int c)
        {
            return Calc.Add(a, b, c) * 2;
        }
    }
}
