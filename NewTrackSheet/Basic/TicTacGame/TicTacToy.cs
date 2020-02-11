using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.TicTacGame
{
    class TicTacToy
    {
        public char[,] board;
       
        public char CurrentPlayer;
        public void TicTacs()
        {
            board = new char[3, 3];
            CurrentPlayer = 'x';
        }
        public void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = '-';
                }
            }
        }
        public void PrintBoard()
        {

            Console.WriteLine("****************");
            for (int i = 0; i < 3; i++)
                {
                    
                    for (int j = 0; j < 3; j++)
                    {
                    Console.Write("|   "+board[i, j]);
                    }
                Console.WriteLine("|");
                Console.WriteLine("****************");

            }
          
        }
        public bool isfullboard()
        {
            bool isfull = true;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (board[i,j] == '-')
                    {
                        isfull = false;
                    }
                }
            }
            return isfull;
        }
        public bool CheckForWin()
        {
            return (CheckRowWin() || checkColWin() || CheckDiaWin());
        }
        public bool CheckRowWin()
        {
            for(int i = 0; i < 3; i++)
            {

            }
        }
    }
}
