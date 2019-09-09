using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSubstitute1
{
    public interface ICalculator
    {
        int Add(int a, int b, int c);
        string Mode { get; set; }
        event EventHandler PoweringUp;
        void TestMethod(out int input);


        int Subtract(int a, int b);
        bool LoadMemory(int p0, ref int any);
    }
}
