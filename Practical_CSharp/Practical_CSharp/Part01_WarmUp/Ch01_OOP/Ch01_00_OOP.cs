using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_CSharp.Part01_WarmUp.Ch01_OOP
{
    public class Ch01_00_OOP
    {
        public static void main()
        {


            #region 1.1.2 클래스의 인스턴스를 생성한다

            // new연산사를 사용해 클래스의 인스턴스를 생성
            // 인스턴스란 컴퓨터의 메모리상에 확보된 클래스의 실체
            Product yakkwa = new Product(123, "약과", 180);

            #endregion

            #region 1.1.3 객체를 이용한다.

            // 약과 객체의 상품 가격을 꺼내는 코드
            int price = yakkwa.Price;
            // 약과 객체의 세금을 포함한 상품 가격을 꺼내는 코드
            int taxIncluded = yakkwa.GetPriceIncludeingTax();

            #endregion

            #region 1.1.4 인스턴스는 여러 개 만들 수 있다.
            // 하나의 클래스로부터 여러 개의 인스턴스를 생성할 수 있다.
            Product honeyYakkwa = new Product(123, "꿀약과", 250);
            Product chapssal = new Product(235, "찹쌀떡", 160);

            #endregion








        }


    }
}
