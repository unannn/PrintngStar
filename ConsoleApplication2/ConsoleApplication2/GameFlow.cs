using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class GameFlow : PrintTypes
    {
        public void SelectMenu(ref int selectIndex)     //메뉴 선택 메소드
        {
            int i;
            bool isSelected = false;                //while문 조정
            ConsoleKeyInfo ckey;

            List<string> menuItem = new List<string>()   //메뉴 리스트 생성
            {
                "1. 가운데 정렬로 찍기",
                "2. 1번 반대로 찍기",
                "3.모래시계 찍기",
                "4.다이아 찍기",
                "5.프로그램 종료"
            };

            Console.CursorVisible = false;

            while (!isSelected)                   //스페이스바 입력까지 반복
            {
                Console.WriteLine("\n      PRINTING STAR");
                for (i = 0; i < menuItem.Count; i++)            //메뉴 출력
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

                ckey = Console.ReadKey();      //방향키 입력
                
                switch (ckey.Key)          //키 입력에 따라 메뉴바 이동, 선택
                {
                    case ConsoleKey.DownArrow:
                        if (selectIndex >= menuItem.Count - 1) selectIndex = 0;   //마지막 인덱스 메뉴에서 위 방향키 입력 시 처음 인덱스 메뉴로 이동
                        else selectIndex++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (selectIndex <= 0) selectIndex = menuItem.Count - 1;   //처음 인덱스 메뉴에서 위 방향키 입력 시 마지막 인덱스 메뉴로 이동
                        else selectIndex--;
                        break;
                    case ConsoleKey.Spacebar:
                        if (selectIndex + 1 == 5) Environment.Exit(0);       //5번이 입력 되면 프로그램 종료
                        isSelected = true;
                        Console.Clear();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }
        public void InputPositiveNubmer(ref int inputNumber)  //양의 정수를 입력받는 메소드
        {
            bool inputSucess = false;   //정수값을 입력받았는지 체크

            while (true)
            {
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("1 이상의 정수를 입력해 주세요.");
                Console.SetCursorPosition(5, 4);
                Console.Write("1 이상의 정수 입력 : ");
                inputSucess = int.TryParse(Console.ReadLine(), out inputNumber);  //정수 입력

                if (inputNumber < 1 || inputSucess == false)   //정수가 아니거나 1보다 작은 정수 입력시 다시 입력
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }
            }

        }
        public void ContinueGame(ref int selectIndex) //별찍기후 메뉴로 'q' 또는 'Q' 입력 시 메뉴로 이동 시키는 메소드
        {
            ConsoleKeyInfo ckey;
            bool isQ = false;
            Console.WriteLine("     q 입력");

            while (!isQ)  //q를 입력받으면 종료
            {
                ckey = Console.ReadKey();
                if (ckey.Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    isQ = true;
                }
                Console.Write("\r");

            }
            selectIndex = 0; 
        }
    }
}

