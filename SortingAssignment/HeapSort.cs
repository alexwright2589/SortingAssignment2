﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    public class Heapsort
    {
        public int[] HeapSort(int[] Heap)
        {
            int HeapSize = Heap.Length; int i;
            for (i = (HeapSize - 1) / 2; i >= 0; i--)
            {
                Max_Heapify(Heap, HeapSize, i);
            }
            for (i = Heap.Length - 1; i > 0; i--)
            {
                int temp = Heap[i]; Heap[i] = Heap[0]; Heap[0] = temp;
                HeapSize--;
                Max_Heapify(Heap, HeapSize, 0);
            }
            return Heap;
        }
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
