using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tic_tac_toe_game
{
    static class Game
    {
        public static int[,] Field = new int[3, 3];        //0 - пусто, 1-крестик, 3-нолик
        public static bool First;                          // true - человек
        public static bool isStarted;
        public static bool Winner;                         // true - человек
        public static int WinLine = 0;
        public static void NewGame(bool first)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Field[i, j] = 0;
            First = first;
            isStarted = true;
        }

        public static void Step()
        {
            WinLine = IsWin();
            if (WinLine != 0) { Win(true); return; } ;
            int nextx=-1, nexty=-1;
            if (IsNextWin(ref nextx,ref nexty))
            {
                Field[nextx, nexty] = First ? 3 : 1;
                WinLine = IsWin();
                Win(false);
            }
            if (nextx==-1)
            {
                bool t=true;
                int k = 0;
                while (t && k<9)
                {
                    if (Field[k / 3, k % 3] == 0) t = false;
                    if (t) k++;
                }
                if (k<9) Field[k/3,k%3] = First ? 3 : 1;
            }
        }
        

        public static bool IsNextWin(ref int xn, ref int yn)
        {
            int count = First ? 6 : 2;
            if (Field[0, 0] + Field[0, 1] + Field[0, 2] == count)
            {
                for(int i=0;i<3;i++)
                    if (Field[0,i]==0) { xn = 0; yn = i; }
                return true;
            }
            if (Field[1, 0] + Field[1, 1] + Field[1, 2] == count)
            {
                for (int i = 0; i < 3; i++)
                    if (Field[1, i] == 0) { xn = 1; yn = i; }
                return true;
            }
            if (Field[2, 0] + Field[2, 1] + Field[2, 2] == count)
            {
                for (int i = 0; i < 3; i++)
                    if (Field[2, i] == 0) { xn = 2; yn = i; }
                return true;
            }
            if (Field[0, 0] + Field[1, 0] + Field[2, 0] == count)
            {
                for (int i = 0; i < 3; i++)
                    if (Field[i, 0] == 0) { xn = i; yn = 0; }
                return true;
            }
            if (Field[0, 1] + Field[1, 1] + Field[2, 1] == count)
            {
                for (int i = 0; i < 3; i++)
                    if (Field[i, 1] == 0) { xn = i; yn = 1; }
                return true;
            }
            if (Field[0, 2] + Field[1, 2] + Field[2, 2] == count)
            {
                for (int i = 0; i < 3; i++)
                    if (Field[i, 2] == 0) { xn = i; yn = 2; }
                return true;
            }
            if (Field[0, 0] + Field[1, 1] + Field[2, 2] == count)
            {
                for (int i = 0; i < 3; i++)
                    if (Field[i, i] == 0) { xn = i; yn = i; }
                return true;
            }
            if (Field[2, 0] + Field[1, 1] + Field[0, 2] == count)
            {
                for (int i = 0; i < 3; i++)
                    if (Field[2-i, i] == 0) { xn = 2-i; yn = i; }
                return true;
            }
            return false;
        }

        public static int IsWin()
        {
            if (Field[0, 0] != 0 && Field[0, 0] == Field[0, 1] && Field[0, 0] == Field[0, 2])
                return 4;
            if (Field[1, 0] != 0 && Field[1, 0] == Field[1, 1] && Field[1, 0] == Field[1, 2])
                return 5;
            if (Field[2, 0] != 0 && Field[2, 0] == Field[2, 1] && Field[2, 0] == Field[2, 2])
                return 6;
            if (Field[0, 0] != 0 && Field[0, 0] == Field[1, 0] && Field[0, 0] == Field[2, 0])
                return 1;
            if (Field[0, 1] != 0 && Field[0, 1] == Field[1, 1] && Field[0, 1] == Field[2, 1])
                return 2;
            if (Field[0, 2] != 0 && Field[0, 2] == Field[1, 2] && Field[0, 2] == Field[2, 2])
                return 3;
            if (Field[0, 0] != 0 && Field[0, 0] == Field[1, 1] && Field[0, 0] == Field[2, 2])
                return 7;
            if (Field[2, 0] != 0 && Field[2, 0] == Field[1, 1] && Field[2, 0] == Field[0, 2])
                return 8;
            return 0;
        }

        public static void Win(bool winner)                 //true - человек
        {
            isStarted = false;
            Winner = winner;
        }
    }
}
