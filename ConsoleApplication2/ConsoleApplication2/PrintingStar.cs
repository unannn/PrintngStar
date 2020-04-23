using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class PrintingStar
    {
        private int selectIndex;
        private int inputNumber;
        private bool inputSucess;

        public PrintingStar()
        {
            selectIndex = 0;
            inputSucess = false;
        }
        public void StartGame()
        {
            PrintTypes printTypes = new PrintTypes();

            while (true)
            {
                MakeMenu();
                InputNubmer();             
                printTypes.PrintSelected(selectIndex + 1, inputNumber);   //선택된 찍기를 입력받은 정수에 맞게 선택 후 출력
                ContinueGame();
            }
        }
        public void MakeMenu() { 

            int i;
            bool isSelected = false;
            ConsoleKeyInfo ckey;

            List<string> menuItem = new List<string>()
            {
                "1. 가운데 정렬로 찍기",
                "2. 1번 반대로 찍기",
                "3.모래시계 찍기",
                "4.다이아 찍기",
                "5.프로그램 종료"
            };

            Console.CursorVisible = false;

            while (!isSelected)
            {
                Console.WriteLine("\n      PRINTING STAR"); 
                for (i = 0; i < menuItem.Count; i++)
                {
                    Console.SetCursorPosition(5, 4 + i * 2);
                    if (i == selectIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine(menuItem[i]);
                    Console.ResetColor();
                }
                Console.WriteLine("\n↑↓방향키 이동, spacebar 선택");

                ckey = Console.ReadKey();


                switch (ckey.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (selectIndex >= menuItem.Count - 1) selectIndex = 0;
                        else selectIndex++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (selectIndex <= 0) selectIndex = menuItem.Count - 1;
                        else selectIndex--;
                        break;
                    case ConsoleKey.Spacebar:
                        if (selectIndex + 1 == 5) Environment.Exit(0);
                        isSelected = true;
                        Console.Clear();
                        break;
                    default:
                        break;

                }
                Console.Clear();
            }
        }
        public void InputNubmer()
        {
            while (true)
            {
                Console.SetCursorPosition(5, 4);
                Console.Write("1 이상의 정수 입력 : ");

                inputSucess = int.TryParse(Console.ReadLine(), out inputNumber);

                if (inputNumber < 1 || inputSucess == false)
                {
                    Console.SetCursorPosition(5, 2);
                    Console.WriteLine("1 이상의 정수를 입력해 주세요.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            
        }
        public void ContinueGame()
        {
            ConsoleKeyInfo ckey;
            bool isQ = false;
            Console.WriteLine("     q 입력");

            while (!isQ)
            {
                ckey = Console.ReadKey();
                if (ckey.Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    isQ = true;
                }
            }
            selectIndex = 0;
        }
    }
}
