using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab.Searching_Algorithms
{
    internal class Binary_Search
    {
        static int binarySearchIterative(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            // If we reach here, the target was not found
            return -1;
        }

        static int binarySearchRecursive(int[] arr, int target, int left, int right)
        {
            if (left > right)
                return -1;

            int mid = (left + right) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                return binarySearchRecursive(arr, target, mid + 1, right);
            else
                return binarySearchRecursive(arr, target, left, mid - 1);
        }

        static void Main(string[] args)
        {
            // Iterative Binary Search
            int[] array = { -6, -3, 0, 7, 15, 17 };
            int x = 17;

            int result = binarySearchIterative(array, x);

            if (result == -1)
                Console.WriteLine("Aranan Eleman Bulunamadı.");
            else
                Console.WriteLine("Aranan Elemanın Bulunduğu İndis: " + result);

            
            // Recursive Binary Search
            x = -3;

            result = binarySearchRecursive(array, x, 0, array.Length - 1);

            if (result == -1)
                Console.WriteLine("Aranan Eleman Bulunamadı.");
            else
                Console.WriteLine("Aranan Elemanın Bulunduğu Dizin: " + result);
        }
    }
}
