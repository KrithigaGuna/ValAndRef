using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValAndRef
{
    class Program3
    {
        public static void Main()
        {
            int x = 10;
            int y = 500;

            Console.WriteLine("x={0}, y={1}", x, y);

            SwapValue(x, y);
            Console.WriteLine("x={0}, y={1}", x, y);

            SwapValueWithRef(ref x, ref y);
            Console.WriteLine("x={0}, y={1}", x, y);
        }

        public static void SwapValue (int a, int b)
        {
            int tmp = b;
            b = a;
            a = tmp;
        }

        public static void SwapValueWithRef(ref int a, ref int b)
        {
            int tmp = b;
            b = a;
            a = tmp;
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
