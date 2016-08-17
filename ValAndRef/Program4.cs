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
            int[] arr2 = new int[] { 10, 20, 30, 40, 50 };

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
        }

        public static void SwapValue (int a, int b)
        {
            int tmp = b;
            a = b;
            b = tmp;
        }

        public static void SwapValueWithRef(ref int a, ref int b)
        {
            int tmp = b;
            a = b;
            b = tmp;
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
    }
}
