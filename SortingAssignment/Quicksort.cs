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
        public int stepstakenascending { get; set; }
        public int stepstakendescending { get; set; }
        public int[] QuickSortascending(int[] data)
        {
            // sets stepstaken increases arraynumber and calls the method for quick sorting
            stepstakenascending = 0;
            ArrayNumber++;
            Quick_Sortascending(data, 0, data.Length - 1);
            Console.WriteLine("\nNum of Steps to sort it in ascending values is : " + stepstakenascending + " in array " + ArrayNumber);
            return data;
        }
        public void Quick_Sortascending(int[] data, int left, int right)
        {
            // recursive so everytime the method is called it increases ascending steps taken
            stepstakenascending++;
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

            if (left < j) Quick_Sortascending(data, left, j);
            if (i < right) Quick_Sortascending(data, i, right);
        }
        public int[] QuickSortdescending(int[] data)
        {
            // sets stepstakendecending is set increases arraynumber and calls the method for quick sorting but sorts in decending order
            stepstakendescending = 0;
            Quick_Sortdescending(data, 0, data.Length - 1);
            Console.WriteLine("\nNum of Steps to sort it in decending values is : " + stepstakendescending + " in array " + ArrayNumber);
            return data;
        }
        public void Quick_Sortdescending(int[] data, int left, int right)
        {
            // recursive so everytime the method is called it increases decending steps taken
            stepstakendescending++;
            // creates a variable field for i,j,pivot and temp
            int i, j;
            int pivot, temp;
            // sets these variables respectively and carries out the quicksort algorithm
            i = left;
            j = right;
            pivot = data[(left + right) / 2];

            do
            {
                while ((i < right) && (data[i] > pivot)) i++;
                while ((j > left) && (pivot > data[j])) j--;

                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (left < j) Quick_Sortdescending(data, left, j);
            if (i < right) Quick_Sortdescending(data, i, right);
        }
    }
}