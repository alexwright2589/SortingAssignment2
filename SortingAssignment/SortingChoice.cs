﻿using System;
namespace SortingAssignment
{
    public class SortingChoice
    {
        public int[] Sortingchoice(int[] array1, int[] array2, int[] array3, string ANSWER, string ans)
        {
            int[] Sorted1 = new int[] { };
            int[] Sorted2 = new int[] { };
            int[] Sorted3 = new int[] { };
            int[] Sorted4 = new int[] { };
            int[] nthvalue1 = new int[] { };
            int[] nthvalue2 = new int[] { };
            int[] nthvalue3 = new int[] { };
            int[] Search1 = new int[] { };
            int[] Search2 = new int[] { };
            int[] Search3 = new int[] { };



            while (true)
            {
                Console.WriteLine("Which algorithm would you like to sort the data with? \n Enter 1 for QuickSort \n Enter 2 for HeapSort \n Enter 3 for InsertionSort \n Enter 4 for BubbleSort");
                string answer = Console.ReadLine();
                if (ANSWER == "1")
                {
                    if (answer == "1")
                    {
                        Quicksort quickSort = new Quicksort();
                        Sorted1 = quickSort.QuickSort(array1);
                        Sorted2 = quickSort.QuickSort(array2);
                        Sorted3 = quickSort.QuickSort(array3);
                    }
                    if (answer == "2")
                    {
                        Heapsort heapSort = new Heapsort();
                        Sorted1 = heapSort.HeapSort(array1);
                        Sorted2 = heapSort.HeapSort(array2);
                        Sorted3 = heapSort.HeapSort(array3);
                    }
                    if (answer == "3")
                    {
                        Insertionsort insertionSort = new Insertionsort();
                        Sorted1 = insertionSort.InsertionSort(array1);
                        Sorted2 = insertionSort.InsertionSort(array2);
                        Sorted3 = insertionSort.InsertionSort(array3);
                    }
                    if (answer == "4")
                    {
                        Bubblesort bubbleSort = new Bubblesort();
                        Sorted1 = bubbleSort.BubbleSort(array1, array1.Length - 1);
                        Sorted2 = bubbleSort.BubbleSort(array2, array2.Length - 1);
                        Sorted3 = bubbleSort.BubbleSort(array3, array3.Length - 1);
                    }
                    else
                    {
                        continue;
                    }
                    GetEveryNthValue(Sorted1, ANSWER);
                    GetEveryNthValue(Sorted2, ANSWER);
                    GetEveryNthValue(Sorted3, ANSWER);

                    Searchingclass searchingclass = new Searchingclass();
                    Search1 = searchingclass.SearchingClass(array1, array2, array3, ans);
                    break;
                }
                else
                {
                    if (ans == "1")
                    {
                        Quicksort quickSort = new Quicksort();
                        Sorted4 = quickSort.QuickSort(array1);
                    }
                    if (ans == "2")
                    {
                        Heapsort heapSort = new Heapsort();
                        Sorted4 = heapSort.HeapSort(array1);
                    }
                    if (ans == "3")
                    {
                        Insertionsort insertionSort = new Insertionsort();
                        Sorted4 = insertionSort.InsertionSort(array1);
                    }
                    if (ans == "4")
                    {
                        Bubblesort bubbleSort = new Bubblesort();
                        Sorted4 = bubbleSort.BubbleSort(array1, array1.Length - 1);
                    }
                    else
                    {
                        continue;
                    }
                    GetEveryNthValue(Sorted1, answer);
                    Searchingclass searchingclass = new Searchingclass();
                    Search1 = searchingclass.SearchingClass(Sorted1, Sorted2, Sorted3, ans);
                    break;
                }
            }
            return array1;
        }

        private static void GetEveryNthValue(int[] data, string ANSWER)
        {
            if (ANSWER == "1")
            {
                for (int i = 0; i < data.Length; i++)
                    if ((i == 0) || (i % 9 == 0))
                    {
                        Console.WriteLine(data[i]);
                    }
            }
            else
            {
                for (int i = 0; i < data.Length; i++)
                    if ((i == 0) || (i % 49 == 0))
                    {
                        Console.WriteLine(data[i]);
                    }

            }
        }
    }
}