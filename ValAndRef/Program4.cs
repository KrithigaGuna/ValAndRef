using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValAndRef
{
    class Program4
    {
        public static void Main()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 10, 20, 30, 40, 50,60,70 };

            Program2.PrintArray(arr1);
            Program2.PrintArray(arr2);

            Console.WriteLine("==============");
            SwapArray(arr1, arr2);
            Program2.PrintArray(arr1);
            Program2.PrintArray(arr2);

            Console.WriteLine("==============");
            SwapArrayWithRef(ref arr1, ref arr2);
            Program2.PrintArray(arr1);
            Program2.PrintArray(arr2);

            int[] arr3 = CopyArray(arr2);
            Program2.PrintArray(arr3);

            int[] arr4 = new int[arr2.Length];
            Array.Copy(arr2, arr4, arr2.Length);
            Program2.PrintArray(arr4);

            int[] arr5 = (int[]) arr2.Clone();
            arr5[0] = 1000;
            Program2.PrintArray(arr5);
            Program2.PrintArray(arr2);


        }

        public static void SwapArray(int[] a, int[] b)
        {
            int[] temp = b;
            b = a;
            a = temp;
        }

        public static void SwapArrayWithRef(ref int[] a, ref int[] b)
        {
            int[] temp = b;
            b = a;
            a = temp;
        }

        public static int[] CopyArray(int[] a)
        {
            int[] theCopy = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                theCopy[i] = a[i];
            }

            return theCopy;
        }
    }
}
