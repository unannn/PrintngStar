using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class PrintingStar
    {
        private int selectNumber;
        private int inputNumber;
        public void StartGame()
        {
            while (true)
            {
                Console.WriteLine("1. 가운데 정렬로 찍기  2. 1번 반대로 찍기  3.모래시계 찍기  4.다이아 찍기 5.프로그램 종료");
                Console.Write("찍기 선택 : ");
                selectNumber = int.Parse(Console.ReadLine());

                if (selectNumber < 1 || selectNumber > 5)
                {
                    Console.WriteLine("1~5의 정수를 입력해 주세요.");
                    continue;
                }
                else if (selectNumber == 5) break;

                Console.Write("1이상의 정수 입력 : ");
                inputNumber = int.Parse(Console.ReadLine());
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
        }
        private void PrintPramid(int inputNumber)
        {
            Console.WriteLine("1 : " + inputNumber);
        }
        private void PrintReversedPramid(int inputNumber)
        {
            Console.WriteLine("2 : " + inputNumber);

        }
        private void PrintSandglass(int inputNumber)
        {
            Console.WriteLine("3 : " + inputNumber);

        }
        private void PrintDiamond(int inputNumber)
        {
            Console.WriteLine("4 : " + inputNumber);

        }
    }
}
