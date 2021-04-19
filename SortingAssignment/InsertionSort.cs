using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    public class Insertionsort
    {
        int ArrayNumber = 0;
        public int[] InsertionSort(int[] data)
        {
            int stepstaken = 0;
            ArrayNumber++;
            int numSorted = 1;
            int index;

            while (numSorted < data.Length)
            {
                stepstaken++;
                int temp = data[numSorted];
                for (index = numSorted; index > 0; index--)
                {
                    if (temp < data[index - 1])
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
            Console.WriteLine("\nNum of Steps is : " + stepstaken + " in array " + ArrayNumber);
            return data;
        }
    }
}