using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    public class Heapsort
    {
        // sets arraynumber
        int ArrayNumber = 0;
        public int[] HeapSort(int[] Heap)
        {
            //sets steps taken and increases arraynumber
            int stepstaken = 0;
            ArrayNumber++;
            // sets the heapsize so it knows the size of the data
            int HeapSize = Heap.Length; int i;
            for (i = (HeapSize - 1) / 2; i >= 0; i--)
            {
            // increases steps taken everytime the method is called
                stepstaken++;
                Max_Heapify(Heap, HeapSize, i);
            }
            for (i = Heap.Length - 1; i > 0; i--)
            {
            // increases steps taken everytime the method is called
                stepstaken++;
                int temp = Heap[i]; Heap[i] = Heap[0]; Heap[0] = temp;
                HeapSize--;
                Max_Heapify(Heap, HeapSize, 0);
            }
            Console.WriteLine("\nNum of Steps is : " + stepstaken + " in array " + ArrayNumber);
            return Heap;
        }
        // carries out the heapsort algorithm
        private static void Max_Heapify(int[] Heap, int HeapSize, int Index)
        {
            int Left = (Index + 1) * 2 - 1; int Right = (Index + 1) * 2; int largest = 0;
            if (Left < HeapSize && Heap[Left] > Heap[Index])
            {
                largest = Left;
            }
            else
            {
                largest = Index;
            }
            if (Right < HeapSize && Heap[Right] > Heap[largest])
            {
                largest = Right;
            }
            if (largest != Index)
            {
                int temp = Heap[Index];
                Heap[Index] = Heap[largest];
                Heap[largest] = temp;
                Max_Heapify(Heap, HeapSize, largest);
            }
        }
    }
}