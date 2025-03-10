using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Calculator
{
    public class Minus : Operation
    {
        public Minus(double operand1, double operand2)
        {
            Operand1 = operand1;
            Operand2 = operand2;
        }

        public override double Calculate()
        {
            return Operand1 - Operand2;
        }
    }
}
