using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Calculator
{
    public abstract class Operation // 부모 클래스(추상)
    {       
        public double Operand1 { get; set; } // 피연산자  {읽기; 쓰기;}
        public double Operand2 { get; set; } // 피연산자

        public abstract double Calculate();
    }
}
