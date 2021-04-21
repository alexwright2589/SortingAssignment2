using System;
namespace SortingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating/declaring a template for the arrays/variables we will need in the following code
            int[] Road1 = new int[] { };
            int[] Road2 = new int[] { };
            int[] Road3 = new int[] { };
            int[] Road4 = new int[] { };
            int[] Road5 = new int[] { };
            int[] Road6 = new int[] { };
            int[] Sorted1 = new int[] { };
            int[] Sorted2 = new int[] { };
            int[] Sorted3 = new int[] { };
            int[] Sorted4 = new int[] { };
            int[] Sorted5 = new int[] { };
            int[] Sorted6 = new int[] { };
            int count;
            string ANSWER;
            // simple while loops to ensure the user is entering the right input
            // lets the user decide which data set they would like to search and sort and then reads and sets the data to arrays Road1,Road2,Road3
            while (true)
            {
                Console.WriteLine("Would you like to sort and search the small road data or the large \n enter 1 for small 2 for large");
                ANSWER = Console.ReadLine();
                if (ANSWER == "1")
                {
                    Road1 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_1_256.txt"), int.Parse);
                    Road2 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_2_256.txt"), int.Parse);
                    Road3 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_3_256.txt"), int.Parse);
                    Road4 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_1_256.txt"), int.Parse);
                    Road5 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_2_256.txt"), int.Parse);
                    Road6 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_3_256.txt"), int.Parse);
                    break;
                }
                if (ANSWER == "2")
                {
                    Road1 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_1_2048.txt"), int.Parse);
                    Road2 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_2_2048.txt"), int.Parse);
                    Road3 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_3_2048.txt"), int.Parse);
                    Road4 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_1_256.txt"), int.Parse);
                    Road5 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_2_256.txt"), int.Parse);
                    Road6 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_3_256.txt"), int.Parse);
                    break;
                }
                else
                {
                    Console.WriteLine("This is not a valid input");
                    continue;
                }
            }
            // again while loop to ensure the input is right
            // this asks the user which sorting method they would like to use giving them 4 different options and then takes the arrays to the necessary class to preform the sort
            while (true)
            {
                Console.WriteLine("Which algorithm would you like to sort the data with? \n Enter 1 for QuickSort \n Enter 2 for HeapSort \n Enter 3 for InsertionSort \n Enter 4 for BubbleSort");
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    Quicksort quickSort = new Quicksort();
                    Sorted1 = quickSort.QuickSortascending(Road1);
                    Sorted4 = quickSort.QuickSortdescending(Road4);
                    Sorted2 = quickSort.QuickSortascending(Road2);
                    Sorted5 = quickSort.QuickSortdescending(Road5);
                    Sorted3 = quickSort.QuickSortascending(Road3);
                    Sorted6 = quickSort.QuickSortdescending(Road6);
                    break;
                }
                if (answer == "2")
                {
                    Heapsort heapSort = new Heapsort();
                    Sorted1 = heapSort.HeapSortascending(Road1);
                    Sorted4 = heapSort.HeapSortDescending(Road4);
                    Sorted2 = heapSort.HeapSortascending(Road2);
                    Sorted5 = heapSort.HeapSortDescending(Road5);
                    Sorted3 = heapSort.HeapSortascending(Road3);
                    Sorted6 = heapSort.HeapSortDescending(Road6);
                    break;
                }
                if (answer == "3")
                {
                    Insertionsort insertionSort = new Insertionsort();
                    Sorted1 = insertionSort.InsertionSortascending(Road1);
                    Sorted4 = insertionSort.InsertionSortdescending(Road4);
                    Sorted2 = insertionSort.InsertionSortascending(Road2);
                    Sorted5 = insertionSort.InsertionSortdescending(Road5);
                    Sorted3 = insertionSort.InsertionSortascending(Road3);
                    Sorted6 = insertionSort.InsertionSortdescending(Road6);
                    break;
                }
                if (answer == "4")
                {
                    Bubblesort bubbleSort = new Bubblesort();
                    Sorted1 = bubbleSort.BubbleSortascending(Road1, Road1.Length - 1);
                    Sorted4 = bubbleSort.BubbleSortdescending(Road4, Road4.Length - 1);
                    Sorted2 = bubbleSort.BubbleSortascending(Road2, Road2.Length - 1);
                    Sorted5 = bubbleSort.BubbleSortdescending(Road5, Road5.Length - 1);
                    Sorted3 = bubbleSort.BubbleSortascending(Road3, Road3.Length - 1);
                    Sorted6 = bubbleSort.BubbleSortdescending(Road6, Road6.Length - 1);
                    break;
                }
                else
                {
                    continue;
                }
            }
            // bit of code so the GetEveryNthValue method can display which array its outputting
            count = 1;
            // sends the sorted arrays over to the method
            GetEveryNthValue(Sorted1, ANSWER, count);
            count++;
            GetEveryNthValue(Sorted2, ANSWER, count);
            count++;
            GetEveryNthValue(Sorted3, ANSWER, count);
            count--;
            count--;
            GetEveryNthValue(Sorted4, ANSWER, count);
            count++;
            GetEveryNthValue(Sorted5, ANSWER, count);
            count++;
            GetEveryNthValue(Sorted6, ANSWER, count);

            // Gets the user to enter a number they would like to search for
            Console.WriteLine("What number would you like to search for?");
            int Number = Convert.ToInt32(Console.ReadLine());
             // does this binary search on the users number they have entered
            BinarySearch binarySearch = new BinarySearch();
            int NumberSearch1 = binarySearch.BinarySearch_R(Number, Sorted1, 0, Sorted1.Length - 1);
            int NumberSearch2 = binarySearch.BinarySearch_R(Number, Sorted2, 0, Sorted2.Length - 1);
            int NumberSearch3 = binarySearch.BinarySearch_R(Number, Sorted3, 0, Sorted3.Length - 1);
            // again while loop to ensure correct input is inputted
            // uses a linear search to see if there are more than one of the values the user has entered in the dat sets
            while (true)
            {
                Console.WriteLine("Would you like to check if there are multiple of these values in the lists? \n type 1 for yes 2 for no");
                string Answer = Console.ReadLine();
                if (Answer == "1")
                {
                    Linearsearch linearSearch = new Linearsearch();
                    int numbersearch1 = linearSearch.LinearSearch(Sorted1, Number);
                    int numbersearch2 = linearSearch.LinearSearch(Sorted2, Number);
                    int numbersearch3 = linearSearch.LinearSearch(Sorted3, Number);
                    break;
                }
                if (Answer == "2")
                    break;
                else
                {
                    continue;
                }
            }
        }

        // simple method to display every 10th value if the user chooses the smaller data sets or every 50th value if they choose the larger one
        // just outputs the first value in the sets and then divides by the respected value to see if the remainder is 0 to get every 10th or 50th value
        private static void GetEveryNthValue(int[] data, string ANSWER, int count)
        {
            Console.WriteLine("Array " + count + ": ");
            if (ANSWER == "1")
            {
                for (int i = 0; i < data.Length + 1; i++)
                {
                    if ((i == 0) || (i % 10 == 0))
                    {
                        Console.WriteLine(data[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < data.Length + 1; i++)
                {
                    if ((i == 0) || (i % 50 == 0))
                    {
                        Console.WriteLine(data[i]);
                    }
                }
            }
        }

    }
} 
            