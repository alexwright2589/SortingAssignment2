using System;
namespace SortingAssignment
{
    public class GetEveryNthvalue
    {
        public GetEveryNthvalue()
        {
            static void GetEveryNthValue(int[] data, string ANSWER)
            {
                if (ANSWER == "1")
                {
                    for (int i = 0; i < data.Length; i++)
                        if ((i == 0) || (i % 9 == 0))
                        {
                            Console.WriteLine(data[i]);
                        }
                }
                else
                {
                    for (int i = 0; i < data.Length; i++)
                        if ((i == 0) || (i % 49 == 0))
                        {
                            Console.WriteLine(data[i]);
                        }

                }

            }
        }
    }
}
