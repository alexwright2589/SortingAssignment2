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
        public int BinarySearch_R(int key, int[] array, int low, int high)
        {
            if (low > high)
            {
                j++;
                Console.WriteLine("This number is not in array " + j);
                return -1;
            }
            int mid = (low + high) / 2;
            if (key == array[mid])
            {
                j++;
                Console.WriteLine("This number is in array " + j + " at position " + mid);
                return mid;
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
