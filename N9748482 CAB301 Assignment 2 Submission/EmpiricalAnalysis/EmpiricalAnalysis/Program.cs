using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricalAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Object
            Test test = new Test();
            Algorithm Algorithm = new Algorithm();

            /* Comment out any functions which will not be tested. */

            // Testing Algorithms Functionality
            test.TestFunction();

            // Testing by Counter
                // MinDistance
            //Console.WriteLine("Testing MinDistance by Counter...");
            //test.TestCounter(Algorithm.MinDistanceCounter);
                // MinDistance2
            //Console.WriteLine("Testing MinDistance2 by Counter...");
            //test.TestCounter(Algorithm.MinDistance2Counter);

            // Testing by Execution Time
                // MinDistance
            //Console.WriteLine("Testing MinDistance by Exec. Time...");
            //test.TestExecTime(Algorithm.MinDistance);
                // MinDistance2
            //Console.WriteLine("Testing MinDistance2 by Exec. Time...");
            //test.TestExecTime(Algorithm.MinDistance2);

            Console.ReadLine();
        }
    }
}
