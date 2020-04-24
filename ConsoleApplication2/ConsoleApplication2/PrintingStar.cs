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

        public PrintingStar()        //생성자
        {
            selectIndex = 0;
            inputNumber = 0;
        }
        public void StartGame()
        {
            GameFlow gameFlow = new GameFlow(); //gameFlow 인스턴스 생성

            while (true)
            {
                gameFlow.SelectMenu(ref selectIndex);                       //메뉴 선택
                gameFlow.InputPositiveNubmer(ref inputNumber);              //정수 입력
                gameFlow.PrintSelectedType(selectIndex + 1, inputNumber);   //별 찍기 출력
                gameFlow.ContinueGame(ref selectIndex);                    

                //selectIndex = gameFlow.SelectMenu();
                //inputNumber = gameFlow.InputPositiveNubmer();
                //gameFlow.PrintSelected(selectIndex + 1, inputNumber);
                //selectIndex = gameFlow.ContinueGame();
            }
        }
    }
}
