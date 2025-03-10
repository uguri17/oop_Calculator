using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using oop_Calculator;

namespace oopCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator_Program");
            Console.WriteLine("------------------");


            // 첫번째 피연산자 입력
            double num1;
            while (true)
            {
                Console.Write("Num1: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out num1))
                {               // 입력값이 double로 변환이 잘 되었다면 num1에 저장
                    break;
                }
                else
                {
                    Console.WriteLine($"Error: <{input}> Invaild input, Please re-enter");
                    Console.WriteLine();
                }
            }            
            //
            //
            Console.WriteLine(); // 줄바꿈
            //
            //
            // 연산자 선택
            char opr;
            char[] source = { '+', '-', '*', '/' };
            
            Console.WriteLine("EX. [+,  -,  *,  /]");
            Console.WriteLine();

            while (true)
            {
                // input을 입력 했을 때 source중에 없다면
                // 경고창 & 입력창 띄우기
                // 제대로 입력 할 때 까지 반복
                // 잘 했다면 빠져나오기
                Console.Write("User Input: ");
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && input.Length == 1) // input값이 빈칸이 아니거나 input값 길이가 1인 경우만
                {
                    opr = input[0]; // 타입 불일치(char, string)로 인한 인덱싱
                                    // 
                    if (Array.Exists(source, element => element == opr))
                              // 검사할 배열, 람다식(조건 검사)
                    {
                        break;
                    }
                }
                Console.WriteLine($"Error: <{input}> Invaild input, Please re-enter");
                Console.WriteLine();
            }
            //          
            //    
            Console.WriteLine(); // 줄바꿈
            //
            //
            // 두번째 피연산자 입력
            double num2;
            while (true)
            {
                Console.Write("Num2: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out num2))
                {               // 입력값이 double로 변환이 잘 되었다면 num1에 저장
                    break;
                }
                else
                {
                    Console.WriteLine($"Error: <{input}> Invaild input, Please re-enter");
                    Console.WriteLine();
                }
            }
            //
            //
            Console.WriteLine(); // 줄바꿈
            //
            //
            // 연산자 구현
            Operation operation = null; // 부모 클래스(Operation) 객체 생성
            
            switch (opr)
            {
                case '+':
                    operation = new Plus(num1, num2);
                    break;
                case '-':
                    operation = new Minus(num1, num2);
                    break;
                case '*':
                    operation = new Multiply(num1, num2);
                    break;
                case '/':
                    operation = new Divide(num1, num2);
                    break;                
            }
            
            // 부모 클래스의 필드를 이용하여 피연산자 할당
            //operation.Operand1 = num1;
            //operation.Operand2 = num2;

            
            // 결과
            double result = operation.Calculate();
            Console.WriteLine("Result: " + result);
        }
    }
}
