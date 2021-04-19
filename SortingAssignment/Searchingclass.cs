using System;
namespace SortingAssignment
{
    public class Searchingclass
    {
        public int[] SearchingClass(int[] array1, int[] array2, int[] array3, string ans)
        {
            int Number;
            Console.WriteLine("What number would you like to search for?");
            Number = Convert.ToInt32(Console.ReadLine());
            if (ans == "1")
            {
                BinarySearch binarySearch = new BinarySearch();
                int NumberSearch1 = binarySearch.Binary_Search(Number, array1);
                int NumberSearch2 = binarySearch.Binary_Search(Number, array2);
                int NumberSearch3 = binarySearch.Binary_Search(Number, array3);

                while (true)
                {
                    Console.WriteLine("Would you like to check if there are multiple of these values in the lists? \n type 1 for yes 2 for no");
                    string Answer = Console.ReadLine();
                    if (Answer == "1")
                    {
                        Linearsearch linearSearch = new Linearsearch();
                        int numbersearch1 = linearSearch.LinearSearch(array1, Number);
                        int numbersearch2 = linearSearch.LinearSearch(array2, Number);
                        int numbersearch3 = linearSearch.LinearSearch(array3, Number);
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
                return array1;
            }
            else
            {
                BinarySearch binarySearch = new BinarySearch();
                int NumberSearch1 = binarySearch.Binary_Search(Number, array1);
                while (true)
                {
                    Console.WriteLine("Would you like to check if there are multiple of these values in the lists? \n type 1 for yes 2 for no");
                    string Answer = Console.ReadLine();
                    if (Answer == "1")
                    {
                        Linearsearch linearSearch = new Linearsearch();
                        int numbersearch1 = linearSearch.LinearSearch(array1, Number);
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
            return array1;
        }
    }
}
