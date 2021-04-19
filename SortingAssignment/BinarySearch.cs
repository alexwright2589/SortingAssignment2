using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    public class BinarySearch
    {
        int j = 0;
        public int stepstaken { get; set; }
        public int Binary_Search(int key, int[] array)
        {
            stepstaken = 0;
            BinarySearch_R(key, array, 0, array.Length - 1);
            return key;
        }
        public int BinarySearch_R(int key, int[] array, int low, int high)
        {
            stepstaken++;
            int mid = (low + high) / 2;
            if (key == array[mid])
            {
                j++;
                Console.WriteLine("\nThis number is in array " + j + " at position " + mid);
                Console.WriteLine("The number of steps taken is: " + stepstaken);
                return mid;
            }
            if (low > high)
            {
                j++;
                Console.WriteLine("\nThis number is not in array " + j + " but the nearest value is at " + (mid + 1) + " and is " + array[mid]);
                Console.WriteLine("The number of steps taken is: " + stepstaken);
                return -1;
            }
            if (key < array[mid])
            {
                return BinarySearch_R(key, array, low, mid - 1);
            }
            else
            {
                return BinarySearch_R(key, array, mid + 1, high);
            }
        }
    }
}
