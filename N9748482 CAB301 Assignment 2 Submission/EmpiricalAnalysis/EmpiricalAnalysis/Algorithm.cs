using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricalAnalysis
{
    class Algorithm
    {
        // The MinDistance() and MinDistance2() algorithms calculate the minimum difference 
        // between any two elements in a given array, A.
        public int MinDistance(int[] A)
        {
            // Input: Array A[0..n - 1] of numbers
            // Output: Minimum distance between two of its elements
            int dmin = int.MaxValue;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if ( (i != j) && (Math.Abs(A[i] - A[j]) < dmin) )
                    {
                        dmin = Math.Abs(A[i] - A[j]);
                    }
                }
            }
            return dmin;
        }

        public int MinDistance2(int[] A)
        {
            // Input: Array A[0..n - 1] of numbers
            // Output: Minimum distance between two of its elements
            int dmin = int.MaxValue;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    int temp = Math.Abs(A[i] - A[j]);
                    if (temp < dmin)
                    {
                        dmin = temp;
                    }
                }
            }
            return dmin;
        }

        public int MinDistanceCounter(int[] A)
        {
            // Input: Array A[0..n - 1] of numbers
            // Output: Integer indicating the number of times the basic operation is 
            //          executed
            int c = 0;

            int dmin = int.MaxValue;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if ( (i != j) && (++c >= 0) && (Math.Abs(A[i] - A[j]) < dmin) )
                    {
                        dmin = Math.Abs(A[i] - A[j]);
                    }
                }
            }
            return c;
        }

        public int MinDistance2Counter(int[] A)
        {
            // Input: Array A[0..n - 1] of numbers
            // Output: Integer indicating the number of times the basic operation is 
            //          executed
            int c = 0;

            int dmin = int.MaxValue;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    int temp = Math.Abs(A[i] - A[j]);
                    if ( (++c >= 0) && (temp < dmin) )
                    {
                        dmin = temp;
                    }
                }
            }
            return c;
        }
    }
}
