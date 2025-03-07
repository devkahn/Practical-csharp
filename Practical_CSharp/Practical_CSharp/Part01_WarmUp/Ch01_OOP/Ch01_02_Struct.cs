using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_CSharp.Part01_WarmUp.Ch01_OOP
{
    internal class Ch01_02_Struct
    {
        public static void main()
        {
            /*
             클래스는 변수가 있는 곳과 다른 곳에 객체의 영역이 확보되고 변수에는 그 참조가 저장되지만
             구조체는 변수 자체에 객체가 저장된다.
             */
            MyClass myClass = new MyClass() { X = 1, Y = 2 };
            MyStruct myStruct = new MyStruct() { X = 1, Y = 2 };
        }


    }

    // 클래스
    class MyClass
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    // 구조체
    struct MyStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
