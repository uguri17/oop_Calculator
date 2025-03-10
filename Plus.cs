using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Calculator
{
    public class Plus : Operation
    {
        public Plus(double operand1, double operand2)
        {
            Operand1 = operand1;
            Operand2 = operand2;
        }

        public override double Calculate()
        {
            return Operand1 + Operand2;
        }
    }


    /*public class Plus : Operation // 자식 클래스
    {
        public override double Calculate() // override: 부모 클래스 메서드 -> 자식 클래스에 재정의
        {
            return Operand1 + Operand2; // 메서드 앞에 데이터 타입이 명시되었기에 return값 필요
        }
    }*/
}
