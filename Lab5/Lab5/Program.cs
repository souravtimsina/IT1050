using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        private static void Main (string[] args)
        { }




        public const int size = 8;
        public static string[][] board;


        static void Main()


        {
            CreateBoard();

            string[] input = { "1", "1", "1", "1" };

            while (input.Length == 4)
            {
                System.Console.Clear();
                PrintBoard();

                input = Console.ReadLine().Split();

                if (input.Length == 4)
                {
                    int tx = int.Parse(input[0]);
                    int ty = int.Parse(input[1]);
                    int dx = int.Parse(input[2]);
                    int dy = int.Parse(input[3]);

                  
                }
            }
        }

        static void CreateBoard()
        {
            board = new string[size][];

            for (int i = 0; i < size; i++)
            {
                board[i] = new string[size];

                for (int j = 0; j < size; j++)
                {
                    
                    board[i][j] = (i < 2 || i > 5) ? "X" : " ";
                }
            }
        }

        static void PrintBoard()
        {
            PrintLine();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    
                    System.Console.Write(" | " + board[i][j]);
                }

                System.Console.Write(" |");
                System.Console.WriteLine();
                PrintLine();
            }
        }

        static void PrintLine()
        {
            System.Console.WriteLine(" +-------------------------------+");
        }
    }
}

