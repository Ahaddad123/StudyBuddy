using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.DataAccess
{
    internal class assigmentList
    {
        internal Assignment head;
    }
    internal class Assignment
    {
        internal int points;
        internal string name;
        internal string priority;
        internal Assignment next;

        public Assignment(int p, string n, string pri)
        {
            points = p;
            name = n;
            priority = pri;
            next = null;
        }

        internal void addAssignment(int newp, string newn, string newpri)
        {
            Assignment newAssignment = new Assignment(newp, newn, newpri);

            //if(assigmentList.head == null)
            //{

            //}
        }
    }
}

