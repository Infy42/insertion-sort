using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertion_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedList = { 3, 5, 8, 2, 1, 7, 4 };

            int i = 1, j = 1;
            int temp = 0;

            Console.WriteLine("Before Insertion Sort: ");

            for (int index = 0; index < unsortedList.Length; index++)
            {
                Console.Write(unsortedList[index] + " ");
            }

            while (i < unsortedList.Length)
            {
                j = i;

                while (j > 0 && unsortedList[j - 1] > unsortedList[j])
                {
                    temp = unsortedList[j];
                    unsortedList[j] = unsortedList[j - 1];
                    unsortedList[j - 1] = temp;
                    j--;
                }

                i++;

            }

            Console.WriteLine("\nAfter Insertion Sort: ");

            for (int index = 0; index < unsortedList.Length; index++)
            {
                Console.Write(unsortedList[index] + " ");
            }

            Console.ReadLine();
        }
    }
}
