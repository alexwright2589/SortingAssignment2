using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    public class Bubblesort
    {
        int ArrayNumber = 0;
        public int[] BubbleSort(int[] a, int n)
        {
            int stepstaken = 0;
            ArrayNumber++;
            for (int i = 0; i < n - 1; i++)
            {
                stepstaken++;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j + 1] < a[j])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nNum of Steps is : " + stepstaken + " in array " + ArrayNumber);
            return a;
        }
    }
}