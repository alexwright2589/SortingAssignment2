using System;

namespace SortingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Road1 = new int[] { };
            int[] Road2 = new int[] { };
            int[] Road3 = new int[] { };
            string ANSWER;
            string ans;
            while (true)
            {
                int[] Choice1 = new int[] { };
                int[] Choice2 = new int[] { };
                int[] Choice3 = new int[] { };
                int[] Choice4 = new int[] { };
                Console.WriteLine("Would you like to sort and search the small road data or the large \n enter 1 for small 2 for large");
                ANSWER = Console.ReadLine();
                if (ANSWER == "1")
                {
                    Road1 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_1_256.txt"), int.Parse);
                    Road2 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_2_256.txt"), int.Parse);
                    Road3 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_3_256.txt"), int.Parse);
                    Console.WriteLine("Would you like to sort these three files normally or would you like to merge road 1 and 3 together and sorte them? \n Enter 1 for normally 2 for merge");
                    ans = Console.ReadLine();
                    if (ans == "1")
                    {
                        SortingChoice sortingChoice = new SortingChoice();
                        Choice1 = sortingChoice.Sortingchoice(Road1, Road2, Road3, ANSWER, ans);
                    }
                    if (ans == "2")
                    {
                        Mergefiles mergeFiles = new Mergefiles();
                        Choice2 = mergeFiles.MergeFiles(Road1, Road2, Road3, ANSWER, ans);
                    }
                }
                if (ANSWER == "2")
                {
                    Road1 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_1_2048.txt"), int.Parse);
                    Road2 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_2_2048.txt"), int.Parse);
                    Road3 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_3_2048.txt"), int.Parse);
                    Console.WriteLine("Would you like to sort these three files normally or would you like to merge road 1 and 3 together and sorte them? \n Enter 1 for normally 2 for merge");
                    ans = Console.ReadLine();
                    if (ans == "1")
                    {
                        SortingChoice sortingChoice = new SortingChoice();
                        Choice3 = sortingChoice.Sortingchoice(Road1, Road2, Road3);
                    }
                    if (ans == "2")
                    {
                        Mergefiles mergeFiles = new Mergefiles();
                        Choice4 = mergeFiles.MergeFiles(Road1, Road3);
                    }
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
            