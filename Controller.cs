using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectFour
{
   public class Controller
    {
        private Player player1;
        private Player player2;
        private ConsoleView view;
        // private Board board;

        public Controller()
        {
            view = new ConsoleView();
        }

        public void Start()
        {
            view.ShowWelcome();
            
        }

        private void PlayGame()
        {
           
        }

        private bool CheckWin()
        {
            
            return false;
        }
    }
}
