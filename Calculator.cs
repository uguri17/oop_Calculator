using System;

namespace oop_Calculator
{
    class Calculator
    {
        // 필드 선언
        double a, b;
        double result;

        // 메서드 선언
        public void Plus()
        {
            result = a + b;
        }

        public void Minus() 
        {
            result = a - b;
        }

        public void Multiply()
        {
            result = a * b;
        }

        public void Divide()
        {
            result = a / b;
        }

        Calculator myCalculator = new Calculator();
    }
}
