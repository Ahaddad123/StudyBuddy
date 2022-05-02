using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.BusinessLogic
{
    internal class Invoker
    {
        private Stack<ICommand> done = new Stack<ICommand>();
        private Stack<ICommand> undone = new Stack<ICommand>();

        public Invoker()
        {

        }

        public void Do(ICommand command)
        {
            command.execute();
            done.Push(command);
        }

        public void Undo()
        {
            if (done.Count > 0)
            {
                ICommand command = done.Pop();
                command.unexecute();
                undone.Push(command);
            }

        }
        public void Redo()
        {
            if (undone.Count > 0)
            {
                ICommand command = undone.Pop();
                command.execute();
                done.Push(command);
            }
        }
    }
}
