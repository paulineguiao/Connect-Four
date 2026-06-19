using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectFour
{
   public class ConsoleView
    {
        public void ShowWelcome()
        {
            Console.WriteLine("Welcome to Connect Four!");
        }

        public void ShowBoard(char[,] grid)
        {
            //don't know yet.
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
