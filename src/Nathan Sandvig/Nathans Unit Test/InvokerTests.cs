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
    internal class InvokerTests
    {
        [TestMethod]
        public void testDo()
        {
            Invoker invoker = new Invoker();
            ICommand command = new AddGrade("course1", "assignment1", 30.5);
            
            invoker.Do(command);

            Assert.AreEqual(1, invoker.done.Count);
        }
    }
}
