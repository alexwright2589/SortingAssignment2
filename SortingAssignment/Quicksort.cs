using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    public class Quicksort
    {
        // sets arraynumber and creates a field for steps taken
        int ArrayNumber = 0;
        public int stepstaken { get; set; }
        public int[] QuickSort(int[] data)
        {
            // sets stepstaken increases arraynumber and calls the method for quick sorting
            stepstaken = 0;
            ArrayNumber++;
            Quick_Sort(data, 0, data.Length - 1);
            Console.WriteLine("\nNum of Steps is : " + stepstaken + " in array " + ArrayNumber);
            return data;
        }
        public void Quick_Sort(int[] data, int left, int right)
        {
            // recursive so everytime the method is called it increases steps taken
            stepstaken++;
            // creates a variable field for i,j,pivot and temp
            int i, j;
            int pivot, temp;
            // sets these variables respectively and carries out the quicksort algorithm
            i = left;
            j = right;
            pivot = data[(left + right) / 2];

            do
            {
                while ((i < right) && (data[i] < pivot)) i++;
                while ((j > left) && (pivot < data[j])) j--;

                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (left < j) Quick_Sort(data, left, j);
            if (i < right) Quick_Sort(data, i, right);
        }
    }
}