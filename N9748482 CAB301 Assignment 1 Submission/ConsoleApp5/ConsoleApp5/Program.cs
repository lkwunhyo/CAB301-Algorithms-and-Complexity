using System;
using System.Diagnostics;

namespace CAB301Assignment
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /* To run each of the tests, it is required to uncomment the single test that 
             * is required to run and to comment out any other tests that are uncommented.
             * NOTE: Some tests may take a while to run. The tests generate 100 arrays for
             * each n from n = 0 to 20 000 where n increments by 1000. 
             */
            // Empirical Analysis - Manual Testing
            TestFunctions test = new TestFunctions();   // TestFunctions Object

            // Functional BruteForceMedian Testing
            TestFunctions.functionalBruteForceMedian();

            // Counter BruteForceMedian Testing
            //TestFunctions.countBruteForceMedian();
            
            // Execution Time BruteForceMedian Testing
            //TestFunctions.execTimeBruteForceMedian();
            
        }
    }
}
