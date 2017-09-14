using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoko
{
    class Program
    {
        static void Main(string[] args)
        {
            string rad = "";
            int index = 0;
            int[,] board = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    board[i, j] = (int)Char.GetNumericValue(rad[index]);
                    index++;
                }
            }
        }
    }
}
