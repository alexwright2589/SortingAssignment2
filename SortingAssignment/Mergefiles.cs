using System;
namespace SortingAssignment
{
    public class Mergefiles
    {
        public int[] MergeFiles(int[] array1, int[] array2, int[] array3, string answer)
        {
            int[] nthvalue1 = new int[] { };
            int[] nthvalue2 = new int[] { };
            int[] nthvalue3 = new int[] { };
            int[] first = array1;
            int[] second = array3;

            Array.Resize(ref first, first.Length + second.Length);
            Array.Copy(second, 0, first, first.Length - second.Length, second.Length);
            SortingChoice sortingChoice = new SortingChoice();
            first = sortingChoice.Sortingchoice(Road1, Road2, Road3, ANSWER, ans);
            return first;
        }
    }
}
