using System;
namespace SortingAssignment
{
    public class Mergefiles
    {
        public int[] MergeFiles(int[] array1, int[] array2)
        {
            int[] first = array1;
            int[] second = array2;

            Array.Resize(ref first, first.Length + second.Length);
            Array.Copy(second, 0, first, first.Length - second.Length, second.Length);

            Console.WriteLine(String.Join(",", first));
            return first;
        }
    }
}
