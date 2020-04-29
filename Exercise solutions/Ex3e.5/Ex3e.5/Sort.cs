using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3e._5
{
    static class Sort
    {
        public static void Bouble(ref int[] numbers)
        {
            int swap;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        swap = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = swap;
                    }
                }
            }
        }

        public static void Selection(ref int[] numbers)
        {
            int min, minIndex;
            for (int i = 0; i < numbers.Length; i++)
            {
                min = numbers[i];
                minIndex = i;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[j] < min)
                    {
                        min = numbers[j];
                        minIndex = j;
                    }
                }
                numbers[minIndex] = numbers[i];
                numbers[i] = min;
            }
        }

        public static void Quick(ref int[] numbers, int startIndex = 0, int stopIndex = 0)
        {
            int i, swap;
            int pivotIndex = startIndex; // Choose the pivot number as the first element in the array
            if (stopIndex == 0)
            {
                stopIndex = numbers.Length - 1; // If the stop index was 0, this means that the entire array should be sorted
            }
            i = stopIndex; // Set token to keep track of the lasy un examined number in the array

            while (pivotIndex < i) // let pivot index and i converge until all numbers in the array has been examined
            {
                if (numbers[i] < numbers[pivotIndex]) // If the examined number is smaller than the pivot number it is moved to the lower end of the array
                {
                    swap = numbers[i];
                    numbers[i] = numbers[pivotIndex + 1];
                    numbers[pivotIndex + 1] = numbers[pivotIndex];
                    numbers[pivotIndex] = swap;
                    pivotIndex++;
                }
                else
                {
                    i--;
                }
            }

            if (pivotIndex - 1 > startIndex) // if there is more to be sorted before the pivot, call it self with the lower end of the array
            {
                Quick(ref numbers, startIndex, pivotIndex - 1);
            }
            if (pivotIndex + 1 < stopIndex) // if there is more to be sorted after the pivot, call it self with the upper end of the array
            {
                Quick(ref numbers, pivotIndex + 1, stopIndex);
            }
        }
    }
}
