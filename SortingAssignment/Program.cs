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

            Quicksort quickSort = new Quicksort();
            int[] SortedRoad1 = quickSort.QuickSort(Road1);
            int[] SortedRoad2 = quickSort.QuickSort(Road2);
            int[] SortedRoad3 = quickSort.QuickSort(Road3);
            GetEveryNthValue(SortedRoad1);
            GetEveryNthValue(SortedRoad2);
            GetEveryNthValue(SortedRoad3);

            Console.WriteLine("What number would you like to search for?");
            int Number = Convert.ToInt32(Console.ReadLine());

            BinarySearch binarySearch = new BinarySearch();
            int NumberSearch1 = binarySearch.BinarySearch_R(Number, SortedRoad1, 0, SortedRoad1.Length - 1);
            int NumberSearch2 = binarySearch.BinarySearch_R(Number, SortedRoad2, 0, SortedRoad2.Length - 1);
            int NumberSearch3 = binarySearch.BinarySearch_R(Number, SortedRoad3, 0, SortedRoad3.Length - 1);


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