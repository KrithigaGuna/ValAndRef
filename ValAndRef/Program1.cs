using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValAndRef
{
    class Program1
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int x2 = 2;
            int x3 = 3;
            int x4 = 4;
            int x5 = 5;
            int y, z;

            SumAndAvgOut(x1, x2, x3, out x4, out x5);
            SumAndAvgOut(x1, x2, x3, out y, out z);

            Console.WriteLine("x4={0}, x5={1}, y={2}, z={3}", x4, x5, y, z);

            SumAndAvgRef(x1, x2, x3, ref x4, ref x5);
            SumAndAvgRef(x1, x2, x3, ref y, ref z);
            Console.WriteLine("x4={0}, x5={1}, y={2}, z={3}", x4, x5, y, z);
        }

        public static void SumAndAvgOut(int a, int b, int c, out int sum, out int avg)
        {
            sum = a + b + c;
            avg = (a + b + c) / 3;
        }

        public static void SumAndAvgRef(int a, int b, int c, ref int sum, ref int avg)
        {
            sum = a + b + c;
            avg = (a + b + c) / 3;
        }

    }
}
