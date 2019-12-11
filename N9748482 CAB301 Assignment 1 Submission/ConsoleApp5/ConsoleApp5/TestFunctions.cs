using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace CAB301Assignment
{
    class TestFunctions
    {
        // Empirical Analysis - Manual Testing
        static Algorithm test = new Algorithm();   // Algorithm Object
        static int numOfTests = 20;
        static int numOfArrays = 100;               // Number of testing arrays
        static Random random = new Random();              // Random Object

        // Generating Random Arrays of sizes 1000, 2000, 3000, ..., 20 000
        // containing random values to Int32.MaxValue and calculating the 
        // average number of times the basic operation is performed for each
        // permutation.
        public static void countBruteForceMedian()
        {
            for (int size = 0; size < 20000 + 1; size += 1000)
            {
                long c_total = 0;
                double c_average = 0;
                for (int i = 0; i < numOfArrays; i++)
                {
                    int[] A = test.GenerateRandomArray(size);
                    int count = test.CountBruteForceMedian(A); // Need to get the count of my algorithm.
                    c_total = c_total + count;

                }
                c_average = c_total / numOfArrays;
                Console.WriteLine("Size: " + size + " " + "Average Operation Count: " + c_average);
            }

            Console.ReadKey();
        }

        // Generating Random Arrays of sizes 1000, 2000, 3000, ..., 20 000
        // containing random values to Int32.MaxValue and calculating the 
        // average exectution time of the algorithm for each permutation.
        public static void execTimeBruteForceMedian()
        {
            Stopwatch timer = new Stopwatch();
                        
            for (int size = 0; size < 20000 + 1; size += 1000)
            {
                long t_total = 0;
                double t_average = 0;
                for (int i = 0; i < numOfArrays; i++)
                {
                    int[] A = test.GenerateRandomArray(size);
                    timer.Start();
                    test.BruteForceMedian(A);
                    timer.Stop();
                    long t_elapsed = timer.ElapsedMilliseconds;   // Timer in milliseconds

                    t_total = t_total + t_elapsed;
                }
                t_average = t_total / numOfArrays;
                Console.WriteLine("Size: " + size + " " + "Average Exec. Time: " + t_average);
            }
            Console.ReadKey();
        }

        public static void functionalBruteForceMedian()
        {
            // Empty Array
            int[] emptyArray = { };

            // Single Element Array
            int[] singleElementArray = { 1 };

            // Sorted Array
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Unsorted Array
            int[] unsortedArray = { 4, 2, 6, 3, 8, 1, 7, 10, 5, 9 };

            // Reversed Array
            int[] reversedArray = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            // Equal Array
            int[] equalArray = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            // Mostly Equal Array
            int[] mostlyEqualArray = { 1, 1, 1, 1, 1, 1, 2, 3, 3, 3 };

            // Even Number of Elements Array
            int[] evenArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Odd Number of Elements Array
            int[] oddArray = { 1, 2, 3, 5, 6, 7, 8, 9 };

            // TESTING
            Console.WriteLine("Testing BruteForceMedian() Algorithm...");
            Console.WriteLine();

            // Printing Arrays
            // EMPTY
            Console.WriteLine("Empty Array: ");
            Console.Write("{  ");
            for (int i = 0; i < emptyArray.Length; i++)
            {
                Console.Write(emptyArray[i] + "  ");
            }
            Console.Write("}");
            Console.WriteLine();
            Console.WriteLine("Median: " + test.BruteForceMedian(emptyArray));
            Console.WriteLine();

            // SINGLE ELEMENT
            Console.WriteLine("Single Element Array: ");
            Console.Write("{  ");
            for (int i = 0; i < singleElementArray.Length; i++)
            {
                Console.Write(singleElementArray[i] + "  ");
            }
            Console.Write("}");
            Console.WriteLine();
            Console.WriteLine("Median: " + test.BruteForceMedian(singleElementArray));
            Console.WriteLine();

            // SORTED
            Console.WriteLine("Sorted Array: ");
            Console.Write("{  ");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + "  ");
            }
            Console.Write("}");
            Console.WriteLine();
            Console.WriteLine("Median: " + test.BruteForceMedian(sortedArray));
            Console.WriteLine();

            // UNSORTED
            Console.WriteLine("Unsorted Array: ");
            Console.Write("{  ");
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.Write(unsortedArray[i] + "  ");
            }
            Console.Write("}");
            Console.WriteLine();
            Console.WriteLine("Median: " + test.BruteForceMedian(unsortedArray));
            Console.WriteLine();

            // REVERSED
            Console.WriteLine("Reversed Array: ");
            Console.Write("{  ");
            for (int i = 0; i < reversedArray.Length; i++)
            {
                Console.Write(reversedArray[i] + "  ");
            }
            Console.Write("}");
            Console.WriteLine();
            Console.WriteLine("Median: " + test.BruteForceMedian(reversedArray));
            Console.WriteLine();

            // EQUAL
            Console.WriteLine("Equal Array: ");
            Console.Write("{  ");
            for (int i = 0; i < equalArray.Length; i++)
            {
                Console.Write(equalArray[i] + "  ");
            }
            Console.Write("}");
            Console.WriteLine();
            Console.WriteLine("Median: " + test.BruteForceMedian(equalArray));
            Console.WriteLine();

            // MOSTLY EQUAL
            Console.WriteLine("Mostly Equal Array: ");
            Console.Write("{  ");
            for (int i = 0; i < mostlyEqualArray.Length; i++)
            {
                Console.Write(mostlyEqualArray[i] + "  ");
            }
            Console.Write("}");
            Console.WriteLine();
            Console.WriteLine("Median: " + test.BruteForceMedian(mostlyEqualArray));
            Console.WriteLine();

            // ODD NUMBER OF ELEMENTS
            Console.WriteLine("Odd Number of Elements Array: ");
            Console.Write("{  ");
            for (int i = 0; i < oddArray.Length; i++)
            {
                Console.Write(oddArray[i] + "  ");
            }
            Console.Write("}");
            Console.WriteLine();
            Console.WriteLine("Median: " + test.BruteForceMedian(oddArray));
            Console.WriteLine();

            // EVEN NUMBER OF ELEMENTS
            Console.WriteLine("Even Number of Elements Array: ");
            Console.Write("{  ");
            for (int i = 0; i < evenArray.Length; i++)
            {
                Console.Write(evenArray[i] + "  ");
            }
            Console.Write("}");
            Console.WriteLine();
            Console.WriteLine("Median: " + test.BruteForceMedian(evenArray));
            Console.WriteLine();
            
            Console.ReadKey();
        }
        
    }
}
