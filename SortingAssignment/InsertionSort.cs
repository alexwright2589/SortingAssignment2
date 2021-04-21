using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    public class Insertionsort
    {
        // sets arraynumber
        int ArrayNumber = 0;
        public int[] InsertionSort(int[] data)
        {
            //sets steps taken, numSorted and index and increases arraynumber by one
            int stepstaken = 0;
            ArrayNumber++;
            int numSorted = 1;
            int index;
            // while loop so it carries on until the last number in the array
            while (numSorted < data.Length)
            {
                // increases steps taken everytime the while loop moves up a value
                stepstaken++;
                int temp = data[numSorted];
                //for loops to carry out the necessary steps for the inserion sort algorithm
                for (index = numSorted; index > 0; index--)
                {
                    stepstaken++;
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
            // outputs the number of steps taken one it breaks out of the while loop
            Console.WriteLine("\nNum of Steps is : " + stepstaken + " in array " + ArrayNumber);
            return data;
        }
    }
}