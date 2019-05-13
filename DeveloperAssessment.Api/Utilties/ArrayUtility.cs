using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayManipulation.Api.Utilties
{
    public class ArrayUtility
    {
        /// <summary>
        /// This function reverses an integer array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] Reverse(int[] array)
        {
            int startIndex = 0;
            int temp = 0;
            int endIndex = array.Length - 1;

            while (startIndex < array.Length / 2)
            {
                temp = array[startIndex];
                array[startIndex] = array[endIndex];
                array[endIndex] = temp;
                startIndex++;
                endIndex--;
            }

            return array;
        }

        /// <summary>
        /// This function removes the element of an array at a specified index
        /// </summary>
        /// <returns></returns>
        public static int[] DeleteElementAtIndex(int index, int[] array)
        {
            int[] resizedArray = new int[array.Length - 1];

            for (int i = index; i < array.Length; i++)
            {
                array[i - 1] = array[i];
            }

            for (int i = 0; i < resizedArray.Length; i++)
            {
                resizedArray[i] = array[i];
            }

            return resizedArray;            
        }


    }
}
