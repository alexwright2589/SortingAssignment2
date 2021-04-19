using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    public class Linearsearch
    {
        int ArrayNumber = 0;
        public int LinearSearch(int[] data, int key)
        {
            int Count = 0;
            int stepstaken = 0;
            ArrayNumber++;
            Console.Write("\nThe value you are looking for in array " + ArrayNumber + " at positions: ");
            for (int i = 0; i < data.Length; i++)
            {
                stepstaken++;
                if (data[i] == key)
                {
                    Count++;
                    Console.Write($"{i + 1}, ");
                }
            }
            if (Count == 0)
            {
                Console.WriteLine("\nYour value doesn't exist in array " + ArrayNumber);
            }
            else
            {
                Console.WriteLine("\nNum of Steps is : " + stepstaken);
            }
            return stepstaken;
        }
    }
}