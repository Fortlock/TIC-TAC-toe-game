using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_tac_toe_game.model;

namespace Tic_tac_toe_game
{
    public partial class TicTacToe : Form
    {
        bool ChFirst = true;
        public TicTacToe()
        {
            InitializeComponent();
        }

        private bool DrawInCell(int x, int y, bool type = true)                //Функция для рисования крестика или нолика. type == false - нолик. 
        {
                int nx = x / 101,
                    ny = y / 101;
                if (Game.Field[nx, ny] == 0 || Game.First!=type)
                {
                    MessageField.Text = String.Empty;
                    if (nx < 3 && nx >= 0 && ny < 3 && ny >= 0)
                    {
                        Graphics GF = GameField.CreateGraphics();
                        Pen p = new Pen(Color.RosyBrown, 3);
                        if (type)                                               //Рисуем крестик
                        {
                            GF.DrawLine(p, 100 * nx + 5,
                                           100 * ny + 5,
                                           100 * (nx + 1) - 5,
                                           100 * (ny + 1) - 5);

                            GF.DrawLine(p, 100 * (nx + 1) - 5,
                                           100 * ny + 5,
                                           100 * nx + 5,
                                           100 * (ny + 1) - 5);
                            Game.Field[nx, ny] = 1;
                        }
                        else                                                    //Рисуем нолик
                        {
                            p.Color = Color.DarkRed;
                            GF.DrawEllipse(p, 100 * nx + 5,
                                              100 * ny + 5,
                                              90,
                                              90);
                            Game.Field[nx, ny] = 3;
                        }
                   
                    }
                    return true;
                }
                else
                {
                    MessageField.Text = "Клетка занята!";
                    return false;
                }
        }

        public void ShowCompSteps()
        {
            int check = Game.First ? 3 : 1;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (Game.Field[i, j] == check) DrawInCell(i * 101, j * 101, !Game.First);
        }

        public void ShowWinner(bool Winner)
        {
            if (!Winner)
                ShowCompSteps();
            Graphics GF = GameField.CreateGraphics();
            Pen p = new Pen(Color.DarkGreen, 2);
            switch (Game.WinLine)
            {
                case 1: GF.DrawLine(p, 2, 50, 298, 50); break;
                case 2: GF.DrawLine(p, 2, 150, 298, 150); break;
                case 3: GF.DrawLine(p, 2, 250, 298, 250); break;
                case 4: GF.DrawLine(p, 50, 2, 50, 298); break;
                case 5: GF.DrawLine(p, 150, 2, 150, 298); break;
                case 6: GF.DrawLine(p, 250, 2, 250, 298); break;
                case 7: GF.DrawLine(p, 2, 2, 298, 298); break;
                case 8: GF.DrawLine(p, 298, 2, 2, 298); break;
            }
            if (Winner) MessageField.Text = "Вы победили!";
            else MessageField.Text = "Вы проиграли!";
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            Game.NewGame(ChFirst);
        }

        private void GameField_Paint(object sender, PaintEventArgs e)   //Рисуем поле для игры.
        {
            Graphics GF = GameField.CreateGraphics();

            Pen p1 = new Pen(Color.Gray, 2);

            GF.DrawLine(p1, 101, 0, 101, 302);
            GF.DrawLine(p1, 202, 0, 202, 302);
            GF.DrawLine(p1, 0, 101, 302, 101);
            GF.DrawLine(p1, 0, 202, 302, 202);
            if (!Game.First) { Game.Step(); ShowCompSteps(); }
        }

        private void GameField_MouseClick(object sender, MouseEventArgs e)
        {
            bool st=false;
            if (Game.isStarted)
                st = DrawInCell(e.X, e.Y, Game.First);
            if (Game.isStarted && st)
                Game.Step();
            if (Game.isStarted && st) ShowCompSteps();
            if (!Game.isStarted) ShowWinner(Game.Winner);
            
        }

        private void Gamer_CheckedChanged(object sender, EventArgs e)
        {
            ChFirst = true;
        }

        private void Comp_CheckedChanged(object sender, EventArgs e)
        {
            ChFirst = false;
        }

        private void NGame_Click(object sender, EventArgs e)
        {
            Game.NewGame(ChFirst);
            MessageField.Text = String.Empty;
            GameField.Invalidate();

        }
    }
}
