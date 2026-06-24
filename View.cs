using System;
using System.Collections.Generic;
using System.Text;

    namespace ConnectFour
    {
        public class ConsoleView
        {
            public void ShowWelcome()
            {
                Console.Clear();
                Console.WriteLine("===============================================");
                Console.WriteLine("     Connect 4 Game Development Project:       ");
                Console.WriteLine("===============================================");
            }

            public void ShowBoard(char[,] grid)
            {
                Console.Clear();

                int rows = grid.GetLength(0);
                int columns = grid.GetLength(1);


                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {

                        Console.Write("| " + grid[r, c] + " ");
                    }
                    Console.WriteLine("|");
                }

                Console.WriteLine("-----------------------------");

                Console.WriteLine("  1   2   3   4   5   6   7  ");
            }

            public void ShowMessage(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
