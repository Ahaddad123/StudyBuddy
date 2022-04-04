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
            LinkedList<Tuple<double, double>> assignmentLog = new LinkedList<Tuple<double, double>>();
            assignmentLog.AddLast(new Tuple<double, double>(4.0, 90.0));
            assignmentLog.AddLast(new Tuple<double, double>(3.0, 80.0));
            assignmentLog.AddLast(new Tuple<double, double>(2.0, 70.0));

            Algorithm algorithm = new Algorithm1(assignmentLog);
            Console.WriteLine(algorithm.HoursForGrade(85.0));

            algorithm = new Algorithm2(assignmentLog);
            Console.WriteLine(algorithm.HoursForGrade(85.0));
        }
    }
}
