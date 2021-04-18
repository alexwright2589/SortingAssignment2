using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    public class Insertionsort
    {
        public int[] InsertionSort(int[] data)
        {
            int numSorted = 1;
            int index;
            {
                int temp = data[numSorted];
                for (index = numSorted; index > 0; index--)
                {
                    if (temp > data[index - 1])
                    {
                        data[index] = data[index - 1];
                    }
                    else
                    {
                        break;
                    }
                }
                data[index] = temp;
                numSorted++;
            }
            return data;
        }
    }
}
