using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class PrintTypes
    {   
        public void PrintSelectedType(int selectNumber, int inputNumber)  //입력된 정수에 따라 선택된 타입의 별 찍기 메소드 호출 메소드
        {            
            switch (selectNumber)
            {
                case 1:
                    PrintPramid(inputNumber);
                    break;
                case 2:
                    PrintReversedPramid(inputNumber);
                    break;
                case 3:
                    PrintSandglass(inputNumber);
                    break;
                case 4:
                    PrintDiamond(inputNumber);
                    break;
                default:
                    break;
            }
        }
        private void PrintPramid(int inputNumber)
        {
            int i, j;

            Console.WriteLine();
            for (i = 0; i < inputNumber; i++)
            {
                Console.SetCursorPosition(5, 6 + i);                 //별찍기 시작 위치
                for (j = 0; j < inputNumber - i - 1; j++) Console.Write(" ");
                for (j = 0; j < 2 * i + 1; j++) Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        private void PrintReversedPramid(int inputNumber)
        {
            int i, j;

            Console.WriteLine();
            for (i = 0; i < inputNumber; i++)
            {
                Console.SetCursorPosition(5, 6+i);
                for (j = 0; j < i; j++) Console.Write(" ");
                for (j = 0; j < 2 * (inputNumber - i) - 1; j++) Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        private void PrintSandglass(int inputNumber)
        {
            int i, j;

            Console.WriteLine();

            for (i = 0; i < inputNumber; i++)
            {
                Console.SetCursorPosition(5, 6 + i);
                for (j = 0; j < i; j++) Console.Write(" ");
                for (j = 0; j < 2 * (inputNumber - i) - 1; j++) Console.Write("*");
                Console.WriteLine();
            }
            for (i = 0; i < inputNumber; i++)
            {
                Console.SetCursorPosition(5, 6 + i + inputNumber);
                for (j = 0; j < inputNumber - i - 1; j++) Console.Write(" ");
                for (j = 0; j < 2 * i + 1; j++) Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine();
        }
        private void PrintDiamond(int inputNumber)
        {
            int i, j;

            Console.WriteLine();

            for (i = 0; i < inputNumber; i++)
            {
                Console.SetCursorPosition(5, 6 + i);
                for (j = 0; j < inputNumber - i - 1; j++) Console.Write(" ");
                for (j = 0; j < 2 * i + 1; j++) Console.Write("*");
                Console.WriteLine();
            }
            for (i = 1; i < inputNumber; i++)
            {
                Console.SetCursorPosition(5, 6 + i + inputNumber - 1);
                for (j = 0; j < i; j++) Console.Write(" ");
                for (j = 0; j < 2 * (inputNumber - i) - 1; j++) Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine();
        }   
    }
}
