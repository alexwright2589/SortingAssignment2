using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    public class LinearSearch
    {
        int j = 0;
        public int Linearsearch(int[] data, int item)
        {
            j++;
            int N = data.Length;
            for (int i = 0; i < N; i++)
                if (data[i] == item)
                    Console.WriteLine("The item you are looking for is at position " + i + " in array " + j);
            return -1;
        }

    }
}
