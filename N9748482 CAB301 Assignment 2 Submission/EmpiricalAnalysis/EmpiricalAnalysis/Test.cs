using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace EmpiricalAnalysis
{
    class Test
    {
        // Empirical Analysis - Manual Testing
        static Algorithm test = new Algorithm();    // Algorithm Object
        static int numOfTests = 20;                 // Number of Tests
        static int numOfArrays = 100;               // Number of testing arrays

        public int[] GenerateRandomArray(int size)
        {
            // Generates a random array of a given input size, of random elements 
            // ranging to Int32.MaxValue.
            int[] arr = new int[size];
            int seed = (int)DateTime.Now.Ticks;
            Random random = new Random(seed);

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(Int32.MaxValue);
            }
            return arr;
        }

        public void TestFunction()
        {
            int[] EmptyArray = { };
            int[] SingleElementArray = { 1 };
            int[] SinglePairArray = { 1, 2 };
            int[] SortedArray = { 1, 3, 7, 8, 17, 22, 24, 30, 42, 77 };
            int[] UnsortedArray = { 7, 1, 24, 30, 22, 17, 8, 3, 42, 77 };
            int[] NegativeIntegersArray = { -1, -3, -7, -8, -17, -22, -24 };
            int[] NegativeAndPositiveIntegersArray = { 1, 3, -7, 9, 17, 22, -24 };

            // Testing Empty Array
            Console.WriteLine("Testing Empty Array...");
            Console.WriteLine("MinDistance: " + test.MinDistance(EmptyArray));
            Console.WriteLine("MinDistance2: " + test.MinDistance2(EmptyArray));
            Console.WriteLine();

            // Testing Single Element Array
            Console.WriteLine("Testing Single Element Array...");
            Console.WriteLine("MinDistance: " + test.MinDistance(SingleElementArray));
            Console.WriteLine("MinDistance2: " + test.MinDistance2(SingleElementArray));
            Console.WriteLine();

            // Testing Single Pair Array
            Console.WriteLine("Testing Single Pair Array...");
            Console.WriteLine("MinDistance: " + test.MinDistance(SinglePairArray));
            Console.WriteLine("MinDistance2: " + test.MinDistance2(SinglePairArray));
            Console.WriteLine();

            // Testing Sorted Array
            Console.WriteLine("Testing Sorted Array...");
            Console.WriteLine("MinDistance: " + test.MinDistance(SortedArray));
            Console.WriteLine("MinDistance2: " + test.MinDistance2(SortedArray));
            Console.WriteLine();

            // Testing Unsorted Array
            Console.WriteLine("Testing Unsorted Array...");
            Console.WriteLine("MinDistance: " + test.MinDistance(UnsortedArray));
            Console.WriteLine("MinDistance2: " + test.MinDistance2(UnsortedArray));
            Console.WriteLine();

            // Testing Negative Integers Array
            Console.WriteLine("Testing Negative Integers Array...");
            Console.WriteLine("MinDistance: " + test.MinDistance(NegativeIntegersArray));
            Console.WriteLine("MinDistance2: " + test.MinDistance2(NegativeIntegersArray));
            Console.WriteLine();

            // Testing Negative and Positive Integers Array
            Console.WriteLine("Testing Negative and Positive Integers Array...");
            Console.WriteLine("MinDistance: " + test.MinDistance(NegativeAndPositiveIntegersArray));
            Console.WriteLine("MinDistance2: " + test.MinDistance2(NegativeAndPositiveIntegersArray));
            Console.WriteLine();
        }

        // Tests the average basic operation count of the given function
        public void TestCounter(Func<int[], int> MinDistance)
        {
            for (int size = 0; size < 20000 + 1; size += 1000)
            {
                long c_total = 0;
                double c_average = 0;
                for (int i = 0; i < numOfArrays; i++)
                {
                    int[] A = GenerateRandomArray(size);
                    int count = MinDistance(A);
                    c_total = c_total + count;

                }
                c_average = c_total / numOfArrays;
                Console.WriteLine("Size: " + size + " " + "Average Operation Count: " + c_average);
            }
        }

        // Tests the average execution time of the given function
        public void TestExecTime(Func<int[], int> MinDistance)
        {
            Stopwatch timer = new Stopwatch();

            for (int size = 0; size < 20000 + 1; size += 1000)
            {
                long t_total = 0;
                double t_average = 0;

                for (int i = 0; i < numOfArrays; i++)
                {
                    // MinDistance Algorithm
                    int[] A = GenerateRandomArray(size);
                    timer.Start();
                    MinDistance(A);
                    timer.Stop();
                    long t_elapsed = timer.ElapsedMilliseconds;

                    t_total = t_total + t_elapsed;
                }
                t_average = t_total / numOfArrays;
                Console.WriteLine("Size: " + size + " " + "Average Exec. Time: " + t_average);
            }
        }
        
    }
}
