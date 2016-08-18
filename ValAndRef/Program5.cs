using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValAndRef
{
    class Program5
    {
        public static void Main()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };

            //Program2.PrintArray(arr1);

            ModifyArrayWithRef(ref arr1);

            //Program2.PrintArray(arr1);

        }

        public static void ModifyArray(int[] a)
        {
            a = new int[] { 100, 200, 300 };
            //a[0] = 100;
        }

        public static void ModifyArrayWithRef(ref int[] a)
        {
            a = new int[] { 100, 200, 300 };
            //a[0] = 100;
        }
    
    }
}
