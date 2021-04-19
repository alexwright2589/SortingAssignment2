using System;
namespace SortingAssignment
{
    public class Mergefiles
    {
        public int[] MergeFiles(int[] array1, int[] array2, int[] array3, string ANSWER, string ans)
        {
            int[] merged = new int[] { };
            int[] first = array1;
            int[] second = array3;

            Array.Resize(ref first, first.Length + second.Length);
            Array.Copy(second, 0, first, first.Length - second.Length, second.Length);
            SortingChoice sortingChoice = new SortingChoice();
            merged = sortingChoice.Sortingchoice(first, array2, array3, ANSWER, ans);
            return first;
        }
    }
}
