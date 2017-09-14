using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sudoko
{

    public class Game
    {
        //fields  
        public int[,] board = new int[9, 9];
        public string numbs = "";
        public int index = 0;

        public Game(string nummer)//Constructor som k�r createboard metod.
        {
            numbs = nummer;
            CreateBoard();

        }
        public void CreateBoard()//siffrorna blir en 2d-array.
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    board[i, j] = (int)Char.GetNumericValue(numbs[index]);
                    index++;
                }
            }
            DisplayBoard();
        }

        public void DisplayBoard()//br�det skrivs ut.
        {
            for (int i = 0; i < 9; i++)//utskrift  
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(board[i, j]);
                    if (j == 2 || j == 5)
                    {
                        Console.Write("|");
                    }

                }
                Console.WriteLine();
                if (i == 2 || i == 5)
                {
                    Console.WriteLine("-----------");
                }
            }
        }
       
    }
}
        
    
