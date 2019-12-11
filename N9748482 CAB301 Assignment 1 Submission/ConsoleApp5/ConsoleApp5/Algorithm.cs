using System;
using System.Collections.Generic;
using System.Text;

namespace CAB301Assignment
{
    class Algorithm
    {
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

        // Returns the median value in a given array A of n numbers. This is
        // the kth element, where k = |n/2|, if the array was sorted.
        public int CountBruteForceMedian(int[] A)
        {
            int count = 0;
            double k = Math.Ceiling((double)A.Length / 2);

            for (int i = 0; i <= A.Length - 1; i++)
            {
                int numsmaller = 0;     // How many elements are smaller than A[i]
                int numequal = 0;       // How many elements are equal to A[i]
                
                for (int j = 0; j <= A.Length - 1; j++) {
                    count++;
                    if (A[j] < A[i])
                    {
                        numsmaller = numsmaller + 1;
                    } else
                    {
                        if (A[j] == A[i])
                        {
                            numequal = numequal + 1;
                        }
                    }
                }
                if ((numsmaller < k) && (k <= (numsmaller + numequal)))
                {
                    // The sum of both counters in the if and else statement give us the total number of 
                    // times the comparisons were run all together
                    return count;
                }
            }
            return 0;  // Will only return 0 in case of an empty array
        }

        // Returns the median value in a given array A of n numbers. This is
        // the kth element, where k = |n/2|, if the array was sorted.
        public int BruteForceMedian(int[] A)
        {
            double k = Math.Ceiling((double)A.Length / 2);

            for (int i = 0; i <= A.Length - 1; i++)
            {
                int numsmaller = 0;     // How many elements are smaller than A[i]
                int numequal = 0;       // How many elements are equal to A[i]

                for (int j = 0; j <= A.Length - 1; j++)
                {
                    if (A[j] < A[i])
                    {
                        numsmaller = numsmaller + 1;
                    }
                    else
                    {
                        if (A[j] == A[i])
                        {
                            numequal = numequal + 1;
                        }
                    }
                }
                if ((numsmaller < k) && (k <= (numsmaller + numequal)))
                {
                    return A[i];
                }
            }
            return -1;  // Will only return -1 in case of an empty array
        }

        // BRIEF ANALYSIS FROM IMPLEMENTATION
        // Best-case scenario would be that the given array is in descending order
        // The best-case scenario is that the array only contains a single element
        // Worst-case scenario is if the given array contains equal or ascending values

    }
}
