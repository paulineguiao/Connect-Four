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
        private Model model;

        public Controller()
        {
            view = new ConsoleView();
            model = new Model();
        }

        public void Start()
        {
            bool keepPlaying = true;

            while (keepPlaying)
            {
                view.ShowWelcome();
                view.ShowMessage("\nPress any key to start the match...");
                Console.ReadKey();

                player1 = new HumanPlayer("Player 1", 'X');
                player2 = new HumanPlayer("Player 2", 'O');

                model.ResetBoard();

                PlayGame();

                keepPlaying = AskToRestart();
            }

            view.ShowMessage("\nThanks for playing Connect Four! Goodbye.");
        }

        private void PlayGame()
        {
            Player currentPlayer = player1;
            int totalMoves = 0;
            bool hasWinner = false;

            while (!hasWinner && totalMoves < 42) 
            {
                view.ShowBoard(model.GetGrid());

                int column = currentPlayer.ChooseColumn();

                if (model.IsColumnFull(column)) 
                {
                    view.ShowMessage("That column is full! Pick another one.");
                    Console.ReadKey();
                    continue;
                }

                int row = model.DropPiece(column, currentPlayer.Symbol);
                totalMoves++;

                if (model.CheckWin(row, column))
                {
                    hasWinner = true;
                    view.ShowBoard(model.GetGrid());
                    view.ShowMessage($"\nCongratulations! {currentPlayer.Name} ({currentPlayer.Symbol}) wins!");
                }
                else
                {
                    currentPlayer = (currentPlayer == player1) ? player2 : player1;
                }
            }

            if (!hasWinner)
            {
                view.ShowBoard(model.GetGrid());
                view.ShowMessage("\nIt's a draw game!");
            }
        }
        private bool AskToRestart()
        {
            while (true)
            {
                Console.Write("\nRestart? Yes(1) No(2): ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    return true;
                }
                if (input == "2")
                {
                    return false;
                }
                view.ShowMessage("Invalid option. Please type 1 or 2.");
            }
        }
    }
}
