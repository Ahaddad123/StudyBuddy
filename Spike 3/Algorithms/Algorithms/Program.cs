using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    //-------------------------------------------------------------------------
    // This class runs the system
    // v1: Created the class - Nathan S, 3-24-22
    //-------------------------------------------------------------------------
    internal class Program
    {
        //---------------------------------------------------------------------
        // Main method to run the program
        // args: The program arguments
        // v1: Created the method - Nathan S, 3-24-22
        //---------------------------------------------------------------------
        static void Main(string[] args)
        {
            Algorithm1 algorithm = new Algorithm1();
            algorithm.AddAssignment(90.0, 4.0);
            algorithm.AddAssignment(80.0, 1.0);
            algorithm.AddAssignment(70.0, 0.0);
            Console.WriteLine(algorithm.HoursForGrade(60.0));
        }
    }
}
