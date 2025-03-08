using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_CSharp.Part01_WarmUp.Ch01_OOP
{
    internal class Ch01_03_ValueTypeAndReferanceType
    {
        public static void main()
        {
            MyPoint a = new MyPoint(10, 20);
            MyPoint b = a;
            Console.WriteLine("a : ({0},{1})", a.X, a.Y);
            Console.WriteLine("b : ({0},{1})", b.X, b.Y);

            a.X = 80;
            Console.WriteLine("a : ({0},{1})", a.X, a.Y);
            Console.WriteLine("b : ({0},{1})", b.X, b.Y);

            MyPoint2 a2 = new MyPoint2(10, 20);
            MyPoint2 b2 = a2;
            Console.WriteLine("a2 : ({0},{1})", a2.X, a2.Y);
            Console.WriteLine("b2 : ({0},{1})", b2.X, b2.Y);

            a2.X = 80;
            Console.WriteLine("a2 : ({0},{1})", a2.X, a2.Y);
            Console.WriteLine("b2 : ({0},{1})", b2.X, b2.Y);

        }
    }

    // 1.3.1. 값형에 대하여
    struct MyPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public MyPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    // 1.3.2 참조형에 대하여
    class MyPoint2
    {
        public int X { get; set; }
        public int Y { get; set; }

        public MyPoint2(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
