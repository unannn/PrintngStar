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
        private bool selectSucess;
        private int inputNumber;
        private bool inputSucess;

        public PrintingStar()
        {
            selectSucess = false;
            inputSucess = false;
        }
        public void StartGame()
        {
            PrintTypes printTypes = new PrintTypes();

            while (true)
            {
                Console.WriteLine("1. 가운데 정렬로 찍기  2. 1번 반대로 찍기  3.모래시계 찍기  4.다이아 찍기 5.프로그램 종료");
                Console.Write("찍기 선택 : ");

                selectSucess = int.TryParse(Console.ReadLine(),out selectNumber);

                if (selectNumber < 1 || selectNumber > 5 || selectSucess == false)
                {
                    Console.WriteLine("1~5의 정수를 입력해 주세요.");
                    continue;
                }
                else if (selectNumber == 5) break;              //프로그램 종료

                Console.Write("1 이상의 정수 입력 : ");
                inputSucess = int.TryParse(Console.ReadLine(),out inputNumber);
                if (inputNumber < 1 || selectSucess == false)
                {
                    Console.WriteLine("1 이상의 정수를 입력해 주세요.");
                    continue;
                }
                printTypes.PrintSelected(selectNumber, inputNumber);
                
            }
        }
    }
}
