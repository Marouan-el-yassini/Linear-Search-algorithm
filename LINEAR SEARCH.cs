using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linear_search_algorithm
{
    internal class Program
    {
        // Linearly search target in arr.
        // If target is present, return the index;
        // otherwise, return -1
        public static int Search(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }

        public static void Main()
        {
            int[] arr = { 1, 10, 30, 15 };
            int target = 3;
            Console.WriteLine(Search(arr, target));
        }
    }
}

