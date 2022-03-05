using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Buddy.DataAccess
{
    internal class Assignment
    {
        internal int points;
        internal string name;
        internal int priority;

        public Assignment(int newPoints, string newName, int newPriority)
        {
            points = newPoints;
            name = newName;
            priority = newPriority;
        }
        
    }
}

