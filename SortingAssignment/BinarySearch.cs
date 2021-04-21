using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    public class BinarySearch
    {
        // sets j to 0 which is used to caluclate which array we are searching
        int j = 0;
        // creates a field for stepstaken to be set
        public int stepstaken { get; set; }
        // sets the steps taken to 0 and calls the search method
        public int Binary_Search(int key, int[] array)
        {
            stepstaken = 0;
            BinarySearch_R(key, array, 0, array.Length - 1);
            return key;
        }
        // method to search the sorted data by taking in each sorted array and preforming a divide of the data to get the midpoint
        // then checks if the midpoint is the value if so outputs the necessary array number and position
        // if not checks that the data has not been fully searched and resets the lower/higher boundarys depending on if the number we are looking for is higher or lower than the mid
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
                Console.WriteLine("\nThis number is not in array " + j + " but the nearest value is at position " + (mid + 1) + " and is " + array[mid]);
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
