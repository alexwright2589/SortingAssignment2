using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    public class Bubblesort
    {
        // sets arraynumber
        int ArrayNumber = 0;
        public int[] BubbleSort(int[] a, int n)
        {
            //sets steps taken and increases arraynumber
            int stepstaken = 0;
            ArrayNumber++;
            // for loop that runs through for the legth of the array checking each number
            for (int i = 0; i < n - 1; i++)
            {
                // increases steps taken and for loop so it moves the first number to the correct spot in the array
                stepstaken++;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    stepstaken++;
                    if (a[j + 1] < a[j])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            // outputs the steps taken for each array and returns the data
            Console.WriteLine("\nNum of Steps is : " + stepstaken + " in array " + ArrayNumber);
            return a;
        }
    }
}