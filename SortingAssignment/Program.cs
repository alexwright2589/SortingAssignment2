using System;

namespace SortingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Road1 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_1_256.txt"), int.Parse);
            int[] Road2 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_2_256.txt"), int.Parse);
            int[] Road3 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_3_256.txt"), int.Parse);

            int[] Sorted1 = new int[] { };
            int[] Sorted2 = new int[] { };
            int[] Sorted3 = new int[] { };

            while (true)
            {
                Console.WriteLine("Which algorithm would you like to sort the data with? \n Enter 1 for QuickSort \n Enter 2 for HeapSort \n Enter 3 for InsertionSort \n Enter 4 for BubbleSort");
                string answer = Console.ReadLine();

                if (answer == "1")
                {
                    Quicksort quickSort = new Quicksort();
                    Sorted1 = quickSort.QuickSort(Road1);
                    Sorted2 = quickSort.QuickSort(Road2);
                    Sorted3 = quickSort.QuickSort(Road3);
                    break;
                }
                if (answer == "2")
                {
                    Heapsort heapSort = new Heapsort();
                    Sorted1 = heapSort.HeapSort(Road1);
                    Sorted2 = heapSort.HeapSort(Road2);
                    Sorted3 = heapSort.HeapSort(Road3);
                    break;
                }
                if (answer == "3")
                {
                    Insertionsort insertionSort = new Insertionsort();
                    Sorted1 = insertionSort.InsertionSort(Road1);
                    Sorted2 = insertionSort.InsertionSort(Road2);
                    Sorted3 = insertionSort.InsertionSort(Road3);
                    break;
                }
                if (answer == "4")
                {
                    Bubblesort bubbleSort = new Bubblesort();
                    Sorted1 = bubbleSort.BubbleSort(Road1, Road1.Length - 1);
                    Sorted2 = bubbleSort.BubbleSort(Road2, Road2.Length - 1);
                    Sorted3 = bubbleSort.BubbleSort(Road3, Road3.Length - 1);
                    break;
                }
                else
                {
                    continue;
                }
            }

            GetEveryNthValue(Sorted1);
            GetEveryNthValue(Sorted2);
            GetEveryNthValue(Sorted3);

            Console.WriteLine("What number would you like to search for?");
            int Number = Convert.ToInt32(Console.ReadLine());

            BinarySearch binarySearch = new BinarySearch();
            int NumberSearch1 = binarySearch.BinarySearch_R(Number, Sorted1, 0, Sorted1.Length - 1);
            int NumberSearch2 = binarySearch.BinarySearch_R(Number, Sorted2, 0, Sorted2.Length - 1);
            int NumberSearch3 = binarySearch.BinarySearch_R(Number, Sorted3, 0, Sorted3.Length - 1);


        }
        private static void GetEveryNthValue(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((i == 0) || (i % 9 == 0))
                {
                    Console.WriteLine(data[i]);
                }
            }
        }

    }
}