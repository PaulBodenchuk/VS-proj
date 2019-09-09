using System;
using NSubstitute;
using NSubstitute.Core;
using NSubstitute.Core.Arguments;
using NSubstitute.ReceivedExtensions;
using NUnit.Framework;

namespace NSubstitute1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            var major = new MajorClass();
            major.Calc = Substitute.For<ICalculator>();
            major.Calc.Add(1, 2, 3).Returns(3);
            var calculator = major.Calc;

            var command = Substitute.For<ICommand>();

            calculator
                .LoadMemory(1, ref Arg.Any<int>())
                .Returns(x => {
                    x[1] = 42;
                    return true;
                });
            int value = 54;
            //var hasEntry = calculator.LoadMemory(1, out var memoryValue);
            Assert.AreEqual(true, calculator.LoadMemory(1, ref value));
            Assert.AreEqual(42, value);
        }

        [Test]
        public void TestMethod1()
        {
            var major = new MajorClass();
            major.Calc = Substitute.For<ICalculator>();
            major.Calc.Add(1, 2, 3).Returns(3);
            var calculator = major.Calc;

            calculator
                .Add(Arg.Any<int>(), Arg.Any<int>(), Arg.Any<int>())
                //.Returns(args => (int)args[0] + (int)args[1] + (int)args[2]);
                .Returns(args => 1 + 10 + (int)args[2]);
            Assert.That(calculator.Add(1, 10, 100), Is.EqualTo(111));
        }

    }
    public class OnceOffCommandRunner
    {
        ICommand command;
        public OnceOffCommandRunner(ICommand command)
        {
            this.command = command;
        }
        public void Run()
        {
            if (command == null) return;
            command.Execute();
            command = null;
        }
    }
}