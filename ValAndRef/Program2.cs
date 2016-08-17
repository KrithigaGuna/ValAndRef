using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValAndRef
{
    class Program2
    {
        public static void Main()
        {
            int[] arr = new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

            int[] arr1, arr2;

            PrintArray(arr);

            SplitArray(arr, 3, out arr1, out arr2);

            PrintArray(arr1);
            PrintArray(arr2);
        }

        //split the array into 2 arrays. 2nd argument indicates how many of the elements should go to the first 
        //array and the rest will go to the second array
        public static void SplitArray(int[] theArray, int firstArraySize, out int[] firstArray, out int[] secondArray)
        {
            firstArray = new int[firstArraySize];
            secondArray = new int[theArray.Length - firstArraySize];

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = theArray[i];
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = theArray[firstArraySize + i];
            }
        }

        public static void PrintArray(int[] arr)
        {
            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " " );
            }
            Console.WriteLine("}");
        }
    }


}
