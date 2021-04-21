using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAssignment
{
    public class Linearsearch
    {
        // sets arraynumber to 0 so is can be increased respectively
        int ArrayNumber = 0;
        public int LinearSearch(int[] data, int key)
        {
            // sets the count and steps taken to 0
            // outputs print statement and does a for loop to check the data for the users number whist increating the array number once and the stepstaken everytime the for loops
            int Count = 0;
            int stepstaken = 0;
            ArrayNumber++;
            Console.Write("\nThe value you are looking for in array " + ArrayNumber + " at positions: ");
            for (int i = 0; i < data.Length; i++)
            {
                stepstaken++;
                // checks to see if the number its on matches the users
                if (data[i] == key)
                {
                    Count++;
                    // outputs the position if so
                    Console.Write($"{i + 1}, ");
                }
            }
            // uses the count to see if there was an increase if it still = 0 no numbers have been found so outputs the print line
            if (Count == 0)
            {
                Console.WriteLine("\nYour value doesn't exist in array " + ArrayNumber);
            }
            // if a number has been found outputs the number of steps taken which will always be the legth of the array
            else
            {
                Console.WriteLine("\nNum of Steps is : " + stepstaken);
            }
            return stepstaken;
        }
    }
}