using System;
namespace SortingAssignment
{
    public class SortingChoice
    {
        public int[] Sortingchoice(int[] array1, int[] array2, int[] array3, string answer)
        {
            int[] Sorted1 = new int[] { };
            int[] Sorted2 = new int[] { };
            int[] Sorted3 = new int[] { };
            int[] nthvalue1 = new int[] { };
            int[] nthvalue2 = new int[] { };
            int[] nthvalue3 = new int[] { };


            while (true)
            {
                Console.WriteLine("Which algorithm would you like to sort the data with? \n Enter 1 for QuickSort \n Enter 2 for HeapSort \n Enter 3 for InsertionSort \n Enter 4 for BubbleSort");
                string ans = Console.ReadLine();

                if (ans == "1")
                {
                    Quicksort quickSort = new Quicksort();
                    Sorted1 = quickSort.QuickSort(array1);
                    Sorted2 = quickSort.QuickSort(array2);
                    Sorted3 = quickSort.QuickSort(array3);
                    break;
                }
                if (ans == "2")
                {
                    Heapsort heapSort = new Heapsort();
                    Sorted1 = heapSort.HeapSort(array1);
                    Sorted2 = heapSort.HeapSort(array2);
                    Sorted3 = heapSort.HeapSort(array3);
                    break;
                }
                if (ans == "3")
                {
                    Insertionsort insertionSort = new Insertionsort();
                    Sorted1 = insertionSort.InsertionSort(array1);
                    Sorted2 = insertionSort.InsertionSort(array2);
                    Sorted3 = insertionSort.InsertionSort(array3);
                    break;
                }
                if (ans == "4")
                {
                    Bubblesort bubbleSort = new Bubblesort();
                    Sorted1 = bubbleSort.BubbleSort(array1, array1.Length - 1);
                    Sorted2 = bubbleSort.BubbleSort(array2, array2.Length - 1);
                    Sorted3 = bubbleSort.BubbleSort(array3, array3.Length - 1);
                    break;
                }
                else
                {
                    continue;
                }
            }

            GetEveryNthvalue getEveryNthvalue = new GetEveryNthvalue();
            nthvalue1 = getEveryNthvalue.GetEveryNthValue(array1, answer);
            nthvalue2 = getEveryNthvalue.GetEveryNthValue(array2, answer);
            nthvalue3 = getEveryNthvalue.GetEveryNthValue(array3, answer);

            return array1;
        }
    }
}