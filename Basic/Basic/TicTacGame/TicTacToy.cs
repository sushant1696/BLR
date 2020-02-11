using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.TicTacGame
{
    class TicTacToy
    {
        public char[,] board=new char[3,3];
       
        public char CurrentPlayer='x';
        //public void TicTacs()
        //{
        //    board = new char[3, 3];
        //    CurrentPlayer = 'x';
        //}
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
    }
}
