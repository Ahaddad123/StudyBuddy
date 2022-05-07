using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_Buddy.BusinessLogic;

namespace Nathans_Unit_Test
{
    [TestClass]
    public class InvokerTests
    {
        [TestMethod]
        public void TestDo()
        {
            Invoker invoker = new Invoker();
            ICommand command = new AddGrade("course1", "assignment1", 30.5);
            
            invoker.Do(command);

            Assert.AreEqual(1, invoker.done.Count);
        }

        [TestMethod]
        public void TestUndo()
        {
            Invoker invoker = new Invoker();
            ICommand command = new AddStudyHours("course1", DateTime.Today, 3);
            invoker.Do(command);

            invoker.Undo();

            Assert.AreEqual(0, invoker.done.Count);
            Assert.AreEqual(1, invoker.undone.Count);
        }

        [TestMethod]
        public void TestRedo()
        {
            Invoker invoker = new Invoker();
            ICommand command = new AddGrade("course1", "assignment1", 100);
            invoker.Do(command);
            invoker.Undo();

            invoker.Redo();

            Assert.AreEqual(0, invoker.undone.Count);
            Assert.AreEqual(1, invoker.done.Count);
        }
    }
}
