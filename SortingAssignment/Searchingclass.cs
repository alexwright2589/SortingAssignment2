using System;
namespace SortingAssignment
{
    public class Searchingclass
    {
        public int[] SearchingClass()
        {
            Console.WriteLine("What number would you like to search for?");
            int Number = Convert.ToInt32(Console.ReadLine());

            BinarySearch binarySearch = new BinarySearch();
            int NumberSearch1 = binarySearch.Binary_Search(Number, Sorted1);
            int NumberSearch2 = binarySearch.Binary_Search(Number, Sorted2);
            int NumberSearch3 = binarySearch.Binary_Search(Number, Sorted3);

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
                {
                    break;
                }
                else
                {
                    Console.WriteLine("This is not a valid input");
                    continue;
                }
            }
        }
    }
}
