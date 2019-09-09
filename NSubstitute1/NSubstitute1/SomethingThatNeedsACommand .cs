using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSubstitute1
{
    class SomethingThatNeedsACommand
    {
        ICommand command;
        public SomethingThatNeedsACommand(ICommand command)
        {
            this.command = command;
        }
        public void DoSomething() { command.Execute(); }
        public void DontDoAnything() { }
    }
}
