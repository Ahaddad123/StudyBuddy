using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.BusinessLogic
{
    //---------------------------------------------------------------------
    // Invoker of the Command pattern used for adding grades and study hours.
    //---------------------------------------------------------------------
    internal class Invoker
    {
        //---------------------------------------------------------------------
        // Stack of the commands done or redone.
        //---------------------------------------------------------------------
        private Stack<ICommand> done = new Stack<ICommand>();

        //---------------------------------------------------------------------
        // Stack of the commands undone.
        //---------------------------------------------------------------------
        private Stack<ICommand> undone = new Stack<ICommand>();

        //---------------------------------------------------------------------
        // Invoker Constructor.
        //---------------------------------------------------------------------
        public Invoker()
        {

        }

        //---------------------------------------------------------------------
        // Adds the first command to the done stack.
        //---------------------------------------------------------------------
        public void Do(ICommand command)
        {
            command.execute();
            done.Push(command);
        }

        //---------------------------------------------------------------------
        // Undoes the first command in the done stack.
        //---------------------------------------------------------------------
        public void Undo()
        {
            if (done.Count > 0)
            {
                ICommand command = done.Pop();
                command.unexecute();
                undone.Push(command);
            }

        }
        //---------------------------------------------------------------------
        // Redos the first command in the undone stack.
        //---------------------------------------------------------------------
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
